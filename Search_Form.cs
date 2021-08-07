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
    partial class Search_Form : Smobiler.Core.Controls.MobileForm
    {
        string Uno;//当前登录用户手机号
        public Search_Form(string a) : base()
        {
            Uno = a;
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title_Control1_ExitButtonpPress_1(object sender, EventArgs e)//单击左上箭头
        {
            this.Close();
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
        private void searchBox_Control1_SearchButtonPress(object sender, EventArgs e)
        {
            try
            {
                string database = "Movie_ticket";
                string sql = "";
                DataSet dataSet = new DataSet();
                string BoxText = searchBox_Control1.TextBox_Text.Replace("'", "''");//使数据库能正确识别字符串
                switch (tabPageView1.PageIndex)
                {
                    case 0://查询电影
                        sql = "select * from Movie_ticket.Movie where Mname like '%" + BoxText + "%'";
                        dataSet = Databaseconnect(database, sql);
                        if (dataSet.Tables[0].Rows.Count <= 0)
                        {
                            listView1.DataSource = dataSet;
                            listView1.DataBind();
                            throw new Exception("此处暂无符合要求的电影");
                        }
                        else
                        {
                            listView1.DataSource = dataSet;
                            listView1.DataBind();
                        }
                        break;
                    case 1://查询用户所在地的影院
                        sql = "select Cno,Cname,Caddress from Cinema,Userinf where Ucity=Ccity and Cname like '%" + BoxText + "%' and Uphoneno='" + Uno + "'";
                        dataSet = Databaseconnect(database, sql);
                        if (dataSet.Tables[0].Rows.Count <= 0)
                        {
                            listView2.DataSource = dataSet;
                            listView2.DataBind();
                            throw new Exception("此处暂无符合要求的影院");
                        }
                        else
                        {
                            listView2.DataSource = dataSet;
                            listView2.DataBind();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
    }
}