using MySql.Data.MySqlClient;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SmobilerAppTEST7._17
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class Session : Smobiler.Core.Controls.MobileUserControl
    {
        public Session() : base()
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

        private void button1_Press(object sender, EventArgs e)
        {
            string database = "movie_ticket";
            string delete = "delete from Projection where Cno= '" + getCno.Text + "'and Mno='" + getMno.Text + "'and Phall =" + int.Parse(hall.Text.Substring(0, 1)) +
                " and Ptime = '" + getdate.Text + " "  + time.Text + "';";
            Databaseconnect(database, delete);
        }
    }
}