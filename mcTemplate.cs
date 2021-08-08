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
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class mcTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        public mcTemplate() : base()
        {
            //This call is required by the SmobilerUserControl.
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

        private void mcTemplate_Load(object sender, EventArgs e)
        {
            string database = "movie_ticket";
            string select1 = "SELECT Cname FROM movie_ticket.project,movie_ticket.cinema where project.Mno = 1 and project.Cno = cinema.Cno";
            string select2 = "SELECT Pprice FROM movie_ticket.project,movie_ticket.ticket where project.Mno = 1 and project.Cno = ticket.Cno and project.Mno = ticket.Mno";
            string select3 = "SELECT Caddress FROM movie_ticket.project,movie_ticket.cinema where project.Mno = 1 and project.Cno = cinema.Cno";
            string select4 = "SELECT Ptime FROM movie_ticket.project,movie_ticket.projection where project.Mno = 1 and projection.Cno = project.Cno and projection.Mno = project.Mno";

            DataSet Cname = Databaseconnect(database, select1);
            DataSet Pprice = Databaseconnect(database, select2);
            DataSet Caddress = Databaseconnect(database, select3);
            DataSet Ptime = Databaseconnect(database, select4);
        }

        private void panel1_Press(object sender, EventArgs e)
        {
            cinema_confirm cinema_Confirm = new cinema_confirm();
            this.Form.Show(cinema_Confirm);
        }
    }
}