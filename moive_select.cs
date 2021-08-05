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
            con.ConnectionString = "server=127.0.0.1;Database=Movie_ticket;uid=root;pwd=;";//连接Movie_ticket数据库
            con.Open();
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

        private void city_btn_Press(object sender, EventArgs e)//选择左上定位图标
        {
            city_select city_Select = new city_select(Uno);
            this.Form.ShowDialog(city_Select, (obj, args) => { city_label.Text = city_Select.Address; });
        }
    }
}