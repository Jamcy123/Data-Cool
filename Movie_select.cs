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
        string Uno;//当前登录用户手机号
        public moive_select(string a) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Uno = a;
        }
        private DataSet Databaseconnect(string dabatase, string sql)//数据库连接调用函数
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database="+dabatase+";uid=root;pwd=;";//连接数据库
            con.Open();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, con);//执行sql语句
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            con.Close();
            return dataSet;
        }

        private void moive_select_Load(object sender, EventArgs e)//界面加载事件
        {
            //加载电影信息
            toolBar1.SelectedIndex = 1;//底部栏默认选项
            string select = "SELECT * FROM Movie_ticket.Movie order by Mgrade DESC";
            string database = "Movie_ticket";
            DataSet dataSet = Databaseconnect(database, select);
            listView1.DataSource = dataSet;
            listView1.DataBind();
            //初始化"定位城市"数据
            select = "select Ucity from Movie_ticket.Userinf where Uphoneno='" + Uno + "'";
            database = "Movie_ticket";
            dataSet = Databaseconnect(database, select);
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                city_label.Text = "定位城市";
            }
            else
            {
                city_label.Text = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
            }
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
                    Show(cinema_Select, (obj, args) => { city_label.Text = cinema_Select.City_Now; ShowForm(cinema_Select.ToolBarItemName); });
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

        private void search_control1_Search_control_Press(object sender, EventArgs e)
        {
            Search_Form search_Form = new Search_Form(Uno);//查询界面
            this.Form.Show(search_Form);
        }

        private void listView1_Refresh(object sender, EventArgs e)//下拉刷新
        {
            listView1.Rows.Clear();
            string select = "SELECT * FROM Movie_ticket.Movie order by Mgrade DESC";
            string database = "Movie_ticket";
            DataSet dataSet = Databaseconnect(database, select);
            listView1.DataSource = dataSet;
            listView1.DataBind();
        }
    }
}