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
    partial class cinema_select : Smobiler.Core.Controls.MobileForm
    {
        string Uno;//当前登录用户手机号
        public cinema_select(string a) : base()
        {
            //toolBar1.SelectedIndex = 1;
            Uno = a;
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private DataSet Databaseconnect(string dabatase, string sql)//数据库连接调用函数
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=" + dabatase + ";uid=root;pwd=;";//连接数据库
            con.Open();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, con);//执行sql语句
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            con.Close();
            return dataSet;
        }
        private void cinema_select_Load(object sender, EventArgs e)//界面载入事件
        {
            //初始化"定位城市"数据
            string select = "select Ucity from Movie_ticket.Userinf where Uphoneno='" + Uno + "'";
            string database = "Movie_ticket";
            DataSet dataSet = Databaseconnect(database, select);
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                city_label.Text = "定位城市";
            }
            else
            {
                city_label.Text = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            //根据加载当地影院信息
            toolBar1.SelectedIndex = 0;//底部栏默认选项
            select = "SELECT * FROM Movie_ticket.Cinema where Ccity='"+city_label.Text+"'";
            database = "Movie_ticket";
            dataSet = Databaseconnect(database, select);
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                label1.Visible = true;
                listView1.DataSource = dataSet;
                listView1.DataBind();
            }
            else
            {
                label1.Visible = false;
                listView1.DataSource = dataSet;
                listView1.DataBind();
            }
        }
        public void setToolbarIndex(int i)
        {
            toolBar1.SelectedIndex = i;//底部栏默认选项
        }
        public string ToolBarItemName { get; set; }//底部工具栏选项
        public string City_Now { get; set; }//当前定位城市
        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)//底部栏单击事件
        {
            ToolBarItemName = e.Name;
            switch (e.Name)
            {
                case "cinema-icon":
                    break;
                default:
                    City_Now = city_label.Text;//将最新更改的地位信息传递给Movie_select
                    this.Close();
                    break;
            }
        }

        private void city_btn_Press(object sender, EventArgs e)//选择左上定位图标
        {
            string address_before = city_label.Text;
            city_select city_Select = new city_select(Uno);
            this.Form.ShowDialog(city_Select, (obj, args) => 
            { city_label.Text = city_Select.Address;//传递地址值到左上角显示
                //发生改动则刷新listview
                if (city_Select.Address != address_before)
                {
                    string select = "SELECT * FROM Movie_ticket.Cinema where Ccity='" + city_label.Text + "'";
                    string database = "Movie_ticket";
                    DataSet dataSet = Databaseconnect(database, select);
                    if (dataSet.Tables[0].Rows.Count <= 0)
                    {
                        label1.Visible = true;
                        listView1.DataSource = dataSet;
                        listView1.DataBind();
                    }
                    else
                    {
                        label1.Visible = false;
                        listView1.DataSource = dataSet;
                        listView1.DataBind();
                    }
                }
            });           
        }

        private void search_control1_Search_control_Press(object sender, EventArgs e)
        {
            Search_Form search_Form = new Search_Form(Uno);//查询界面
            this.Form.Show(search_Form);
        }

        private void listView1_Refresh(object sender, EventArgs e)//下拉刷新
        {
            listView1.Rows.Clear();
            string select = "SELECT * FROM Movie_ticket.Cinema where Ccity='" + city_label.Text + "'";
            string database = "Movie_ticket";
            DataSet dataSet = Databaseconnect(database, select);
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                label1.Visible = true;
                listView1.DataSource = dataSet;
                listView1.DataBind();
            }
            else
            {
                label1.Visible = false;
                listView1.DataSource = dataSet;
                listView1.DataBind();
            }
        }
    }
}