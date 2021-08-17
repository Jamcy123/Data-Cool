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
            string[] a = {"今天 " + DateTime.Now.ToShortDateString().ToString(), "明天 " + DateTime.Now.AddDays(1).ToShortDateString().ToString(), "后天 " + DateTime.Now.AddDays(2).ToShortDateString().ToString()};
            tabPageView1.Titles = a;

            string database = "movie_ticket";
            string select = "SELECT * FROM movie_ticket.movie where Mno = '" + movie_no + "';";
            DataSet dataSet = Databaseconnect(database, select);
            Mname_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            Mlanguage_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
            Mtype_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[3].ToString();
            Mduration_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[5].ToString();
            Mgrade_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[7].ToString();
            Mpicadress_image.ResourceID = dataSet.Tables[0].Rows[0].ItemArray[4].ToString();

            string select1 = "SELECT DISTINCT cinema.Cno,cinema.Cname,cinema.Caddress,projection.Mno,projection.Pprice " +
                "FROM movie_ticket.cinema,movie_ticket.projection,movie_ticket.ticket " +
                "where projection.Mno = '" + movie_no + "' and projection.Cno = cinema.Cno and projection.Ptime like '" + DateTime.Now.ToString("yyyy-MM-dd") + "%' and projection.Ptime > '" + DateTime.Now.ToString() + "'; ";

            string select2 = "SELECT DISTINCT cinema.Cno,cinema.Cname,cinema.Caddress,projection.Mno,projection.Pprice " +
                "FROM movie_ticket.cinema,movie_ticket.projection,movie_ticket.ticket " +
                "where projection.Mno = '" + movie_no + "' and projection.Cno = cinema.Cno and projection.Ptime like '" + DateTime.Now.AddDays(1).ToString("yyyy-MM-dd") + "%'; ";

            string select3 = "SELECT DISTINCT cinema.Cno,cinema.Cname,cinema.Caddress,projection.Mno,projection.Pprice " +
                "FROM movie_ticket.cinema,movie_ticket.projection,movie_ticket.ticket " +
                "where projection.Mno = '" + movie_no + "' and projection.Cno = cinema.Cno and projection.Ptime like '" + DateTime.Now.AddDays(2).ToString("yyyy-MM-dd") + "%'; ";


            DataSet dataSet1 = Databaseconnect(database, select1);
            DataSet dataSet2 = Databaseconnect(database, select2);
            DataSet dataSet3 = Databaseconnect(database, select3);


            DataTable table1 = new DataTable();
            table1 = dataSet1.Tables[0];
            table1.Columns.Add(new DataColumn() { ColumnName = "select_date", DataType = typeof(String) });
            DataTable table2 = new DataTable();
            table2 = dataSet2.Tables[0];
            table2.Columns.Add(new DataColumn() { ColumnName = "select_date", DataType = typeof(String) });
            DataTable table3 = new DataTable();
            table3 = dataSet3.Tables[0];
            table3.Columns.Add(new DataColumn() { ColumnName = "select_date", DataType = typeof(String) });

            listView1.Rows.Clear();     //清除数据
            if (table1.Rows.Count > 0)    //绑定数据源
            {
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    table1.Rows[i]["select_date"] = DateTime.Now.ToString("yyyy-MM-dd");
                }
                listView1.DataSource = table1;
                listView1.DataBind();
            }
            listView2.Rows.Clear();     //清除数据
            if (table2.Rows.Count > 0)    //绑定数据源
            {
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    table2.Rows[i]["select_date"] = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
                }
                listView2.DataSource = table2;
                listView2.DataBind();
            }
            listView3.Rows.Clear();     //清除数据
            if (table3.Rows.Count > 0)    //绑定数据源
            {
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    table3.Rows[i]["select_date"] = DateTime.Now.Date.AddDays(2).ToString("yyyy-MM-dd");
                }
                listView3.DataSource = table3;
                listView3.DataBind();
            }

        }

        private void title_Control1_ExitButtonpPress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_RowBind(object sender, ListViewTemplateBindEventArgs e)
        {
            string a = ((Label)e.Row.Control.Controls.Find("Pprice_lbl", true)).BindDataValue.ToString();
            string b = ((Label)e.Row.Control.Controls.Find("Cname_lbl", true)).BindDataValue.ToString();
            string c = ((Label)e.Row.Control.Controls.Find("date_lbl", true)).Text.ToString();

            string database = "movie_ticket";
            string select = "SELECT Ptime FROM movie_ticket.projection where Mno = '" + a + "' and Cno = '" + b + "' and Ptime like '" + c + "%' and Ptime > '" + DateTime.Now.ToString() + "'; ";
            DataSet dataSet = Databaseconnect(database, select);
            string shangying = "";
            string[] movie_time;
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                movie_time = dataSet.Tables[0].Rows[i].ItemArray[0].ToString().Split(' ');
                shangying = shangying + movie_time[1] + " ";
            }
            ((Label)e.Row.Control.Controls.Find("Ptime_lbl",true)).Text = shangying;
        }

        private void listView2_RowBind(object sender, ListViewTemplateBindEventArgs e)
        {
            string a = ((Label)e.Row.Control.Controls.Find("Pprice_lbl", true)).BindDataValue.ToString();
            string b = ((Label)e.Row.Control.Controls.Find("Cname_lbl", true)).BindDataValue.ToString();
            string c = ((Label)e.Row.Control.Controls.Find("date_lbl", true)).Text.ToString();

            string database = "movie_ticket";
            string select = "SELECT Ptime FROM movie_ticket.projection where Mno = '" + a + "' and Cno = '" + b + "' and Ptime like '" + c + "%'; ";
            DataSet dataSet = Databaseconnect(database, select);
            string shangying = "";
            string[] movie_time;
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                movie_time = dataSet.Tables[0].Rows[i].ItemArray[0].ToString().Split(' ');
                shangying = shangying + movie_time[1] + " ";
            }
            ((Label)e.Row.Control.Controls.Find("Ptime_lbl", true)).Text = shangying;
        }

        private void listView3_RowBind(object sender, ListViewTemplateBindEventArgs e)
        {
            string a = ((Label)e.Row.Control.Controls.Find("Pprice_lbl", true)).BindDataValue.ToString();
            string b = ((Label)e.Row.Control.Controls.Find("Cname_lbl", true)).BindDataValue.ToString();
            string c = ((Label)e.Row.Control.Controls.Find("date_lbl", true)).Text.ToString();

            string database = "movie_ticket";
            string select = "SELECT Ptime FROM movie_ticket.projection where Mno = '" + a + "' and Cno = '" + b + "' and Ptime like '" + c + "%'; ";
            DataSet dataSet = Databaseconnect(database, select);
            string shangying = "";
            string[] movie_time;
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                movie_time = dataSet.Tables[0].Rows[i].ItemArray[0].ToString().Split(' ');
                shangying = shangying + movie_time[1] + " ";
            }
            ((Label)e.Row.Control.Controls.Find("Ptime_lbl", true)).Text = shangying;
        }
    }
}