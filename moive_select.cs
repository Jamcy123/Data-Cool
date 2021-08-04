using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using MySql.Data.MySqlClient;

namespace SmobilerAppTEST7._17
{
    
    partial class moive_select : Smobiler.Core.Controls.MobileForm
    {
        string Uno;
        public moive_select(string a) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Uno = a;
        } 
       
        private void moive_select_Load(object sender, EventArgs e)//界面加载事件
        {
            toolBar1.SelectedIndex = 1;//底部栏默认选项
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=Movie_ticket;uid=root;pwd=;";
            con.Open();
            //增加数据并更新同步到数据库
            string select = "SELECT * FROM Movie_ticket.Movie;";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(select, con);
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            listView1.DataSource = dataSet;
            listView1.DataBind();
            con.Close();
        }

        private void ShowForm(string name)//界面选择
        {
            switch (name)
            {
                case "moive-icon":
                    toolBar1.SelectedIndex = 1;
                    break;
                case "cinema-icon":
                    cinema_select cinema_Select = new cinema_select(Uno);
                    cinema_Select.setToolbarIndex(0);
                    Show(cinema_Select, (obj, args) => { ShowForm(cinema_Select.ToolBarItemName); });
                    break;
                case "user-icon":
                    user user = new user(Uno);
                    user.setToolbarIndex(2);
                    Show(user, (obj, args) => { ShowForm(user.ToolBarItemName); });
                    break;
            }
        }

        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)//底部工具栏单击事件
        {
            ShowForm(e.Name);//e:单击的图标
        }

        private void button1_Press(object sender, EventArgs e)
        {
            gps1.GetGps();//获取位置信息
        }
        private string address(string location)//输入地址，返回城市
        {
            //直辖市，省，自治区
            //市，自治州，地区，盟
            string city = "";
            if (location.Contains("省"))
                city = location.Substring(location.IndexOf("省") + 1, location.IndexOf("市") - location.IndexOf("省"));
            else
            {
                if (location.Contains("自治区"))
                    city = location.Substring(location.IndexOf("区") + 1, location.IndexOf("市") - location.IndexOf("区"));
                else
                    city = location.Substring(0, location.IndexOf("市") + 1);
            }
            return city;
        }
        private void gps1_GotLocation(object sender, GPSResultArgs e)
        {
            //是否获取到了位置信息
            if ((e.isError).Equals(false))
            {
                if (e.Longitude != 0 & e.Latitude != 0)
                {
                    //lblAddress.Text = e.Location;  //位置信息
                    lblAddress.Text = address(e.Location);
                }
                else
                {
                    lblAddress.Text = "定位失败";
                }
            }
            else
            {
                lblAddress.Text = "定位失败";
            }
        }
    }
}