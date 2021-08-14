using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace SmobilerAppTEST7._17
{
    partial class cinema_confirm : Smobiler.Core.Controls.MobileForm
    {
        string cinema_no;//当前页面影院编号
        public cinema_confirm(string b) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            cinema_no = b;
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

        private void cinema_confirm_Load(object sender, EventArgs e)
        {
            string database = "movie_ticket";

            string select1 = "SELECT DISTINCT * FROM movie_ticket.cinema where Cno like '" + cinema_no + "';";
            DataSet dataSet1 = Databaseconnect(database, select1);
            Cname_lbl.Text = dataSet1.Tables[0].Rows[0].ItemArray[2].ToString();
            Caddress_lbl.Text = dataSet1.Tables[0].Rows[0].ItemArray[3].ToString();


            string select = "SELECT DISTINCT projection.Cno,movie.* FROM movie_ticket.projection,movie_ticket.movie where projection.Cno like '" + cinema_no + "' and projection.Mno like movie.Mno;";
            DataSet dataSet = Databaseconnect(database, select);


            DataTable table = new DataTable();
            table = dataSet.Tables[0];
            listView1.Rows.Clear();     //清除数据
            if (table.Rows.Count > 0)    //绑定数据源
            {
                listView1.DataSource = dataSet;
                listView1.DataBind();
                listView2.DataSource = dataSet;
                listView2.DataBind();
                listView3.DataSource = dataSet;
                listView3.DataBind();
            }

            string[] cinema_time = { DateTime.Now.ToShortDateString().ToString(), DateTime.Now.AddDays(1).ToShortDateString().ToString(), DateTime.Now.AddDays(2).ToShortDateString().ToString() };
            tabPageView1.Titles = cinema_time;

            Cno_lbl.Text = cinema_no;
        }
    }
}