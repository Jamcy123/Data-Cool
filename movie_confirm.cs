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
    partial class movie_confirm : Smobiler.Core.Controls.MobileForm
    {
        string movie_no;//当前页面电影编号
        public movie_confirm(string a) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            movie_no = a;
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
        private void movie_confirm_Load(object sender, EventArgs e)
        {
            string[] a = {DateTime.Now.ToShortDateString().ToString(), DateTime.Now.AddDays(1).ToShortDateString().ToString(), DateTime.Now.AddDays(2).ToShortDateString().ToString()};
            tabPageView1.Titles = a;

            string database = "movie_ticket";
            string select = "SELECT * FROM movie_ticket.movie where Mno like '" + movie_no + "';";
            DataSet dataSet = Databaseconnect(database, select);
            Mname_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            Mlanguage_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
            Mtype_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[3].ToString();
            Mduration_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[5].ToString();
            Mgrade_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[7].ToString();
            Mpicadress_image.ResourceID = dataSet.Tables[0].Rows[0].ItemArray[4].ToString();

            string select1 = "SELECT DISTINCT cinema.Cno,cinema.Cname,cinema.Caddress,projection.Mno,projection.Ptime,projection.Pprice " +
                "FROM movie_ticket.cinema,movie_ticket.projection,movie_ticket.ticket " +
                "where projection.Mno like '" + movie_no + "' and projection.Cno like cinema.Cno and projection.Ptime like '" + DateTime.Now.ToString("yyyy-MM-dd") + "%'; ";

            string select2 = "SELECT DISTINCT cinema.Cno,cinema.Cname,cinema.Caddress,projection.Mno,projection.Ptime,projection.Pprice " +
                "FROM movie_ticket.cinema,movie_ticket.projection,movie_ticket.ticket " +
                "where projection.Mno like '" + movie_no + "' and projection.Cno like cinema.Cno and projection.Ptime like '" + DateTime.Now.AddDays(1).ToString("yyyy-MM-dd") + "%'; ";

            string select3 = "SELECT DISTINCT cinema.Cno,cinema.Cname,cinema.Caddress,projection.Mno,projection.Ptime,projection.Pprice " +
                "FROM movie_ticket.cinema,movie_ticket.projection,movie_ticket.ticket " +
                "where projection.Mno like '" + movie_no + "' and projection.Cno like cinema.Cno and projection.Ptime like '" + DateTime.Now.AddDays(2).ToString("yyyy-MM-dd") + "%'; ";


            DataSet dataSet1 = Databaseconnect(database, select1);
            DataSet dataSet2 = Databaseconnect(database, select2);
            DataSet dataSet3 = Databaseconnect(database, select3);


            DataTable table1 = new DataTable();
            table1 = dataSet1.Tables[0];
            DataTable table2 = new DataTable();
            table2 = dataSet2.Tables[0];
            DataTable table3 = new DataTable();
            table3 = dataSet3.Tables[0];
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

        }

    }
}