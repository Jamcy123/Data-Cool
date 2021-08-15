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
            string a = "004";
            string b = "0004";
            string c = date_lbl.Text.ToString();

            string database = "movie_ticket";
            string select = "SELECT Ptime FROM movie_ticket.projection where Mno like '" + a + "' and Cno like '" + b + "' and Ptime like '" + c + "%'; ";
            DataSet dataSet = Databaseconnect(database, select);
            Ptime_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
        }

        private void panel1_Press(object sender, EventArgs e)
        {
            string b = Cname_lbl.BindDataValue.ToString();
            string a = Pprice_lbl.BindDataValue.ToString();
            cinema_movie cinema_Movie = new cinema_movie(a,b);
            this.Form.Show(cinema_Movie);
        }
    }
}