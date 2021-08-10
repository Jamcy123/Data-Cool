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
            string database = "movie_ticket";
            string select = "SELECT * FROM movie_ticket.movie where Mno =1" ;
            DataSet dataSet = Databaseconnect(database, select);
            Mname_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            Mlanguage_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
            Mtype_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[3].ToString();
            Mduration_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[5].ToString();
            Mgrade_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[7].ToString();
            Mpicadress_image.ResourceID = dataSet.Tables[0].Rows[0].ItemArray[4].ToString();

            string select1 = "SELECT cinema.Cname,ticket.Pprice,cinema.Caddress,projection.Ptime FROM movie_ticket.project,movie_ticket.cinema,movie_ticket.projection,movie_ticket.ticket where project.Mno =1 and project.Cno = cinema.Cno and project.Cno = ticket.Cno and project.Mno = ticket.Mno and projection.Cno = project.Cno and projection.Mno = project.Mno;";

            DataSet dataSet1 = Databaseconnect(database, select1);
            
            DataTable table = new DataTable();
            table = dataSet1.Tables[0];
            listView1.Rows.Clear();     //清除数据
            if (table.Rows.Count > 0)    //绑定数据源
            {
                listView1.DataSource = table;
                listView1.DataBind();
                listView2.DataSource = table;
                listView2.DataBind();
                listView3.DataSource = table;
                listView3.DataBind();
            }

            string[] a = { DateTime.Now.ToShortDateString().ToString(), DateTime.Now.AddDays(30).ToShortDateString().ToString(), DateTime.Now.AddDays(59).ToShortDateString().ToString() };
            tabPageView1.Titles = a;
        }

    }
}