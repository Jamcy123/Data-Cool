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
            string[] cinema_time = { "今天 " + DateTime.Now.ToShortDateString().ToString(), "明天 " + DateTime.Now.AddDays(1).ToShortDateString().ToString(), "后天 " + DateTime.Now.AddDays(2).ToShortDateString().ToString() };
            tabPageView1.Titles = cinema_time;

            string database = "movie_ticket";

            string select1 = "SELECT DISTINCT * FROM movie_ticket.cinema where Cno like '" + cinema_no + "';";
            DataSet dataSet1 = Databaseconnect(database, select1);
            Cname_lbl.Text = dataSet1.Tables[0].Rows[0].ItemArray[2].ToString();
            Caddress_lbl.Text = dataSet1.Tables[0].Rows[0].ItemArray[3].ToString();


            string select21 = "SELECT DISTINCT projection.Cno,movie.* FROM movie_ticket.projection,movie_ticket.movie where projection.Cno like '" + cinema_no + "' and projection.Mno like movie.Mno and projection.Ptime like '" + DateTime.Now.ToString("yyyy-MM-dd") + "%' and projection.Ptime > '" + DateTime.Now.ToString() + "'; ";
            string select22 = "SELECT DISTINCT projection.Cno,movie.* FROM movie_ticket.projection,movie_ticket.movie where projection.Cno like '" + cinema_no + "' and projection.Mno like movie.Mno and projection.Ptime like '" + DateTime.Now.AddDays(1).ToString("yyyy-MM-dd") + "%'; ";
            string select23 = "SELECT DISTINCT projection.Cno,movie.* FROM movie_ticket.projection,movie_ticket.movie where projection.Cno like '" + cinema_no + "' and projection.Mno like movie.Mno and projection.Ptime like '" + DateTime.Now.AddDays(2).ToString("yyyy-MM-dd") + "%'; ";

            DataSet dataSet21 = Databaseconnect(database, select21);
            DataSet dataSet22 = Databaseconnect(database, select22);
            DataSet dataSet23 = Databaseconnect(database, select23);

            DataTable table1 = new DataTable();
            table1 = dataSet21.Tables[0];
            DataTable table2 = new DataTable();
            table2 = dataSet22.Tables[0];
            DataTable table3 = new DataTable();
            table3 = dataSet23.Tables[0];
            listView1.Rows.Clear();     //清除数据
            if (table1.Rows.Count > 0)    //绑定数据源
            {
                listView1.DataSource = table1;
                listView1.DataBind();
            }
            if (table2.Rows.Count > 0)    //绑定数据源
            {
                listView2.DataSource = table2;
                listView2.DataBind();
            }
            if (table3.Rows.Count > 0)    //绑定数据源
            {
                listView3.DataSource = table3;
                listView3.DataBind();
            }
            Cno_lbl.Text = cinema_no;
        }

        private void title_Control1_ExitButtonpPress(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}