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
    partial class SaleControl : Smobiler.Core.Controls.MobileUserControl
    {
        public SaleControl() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            
        }

        private DataSet Databaseconnect(string dabatase, string sql)//数据库连接调用函数
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=" + dabatase + ";uid=root;pwd=;";//连接数据库
            con.Open();
            MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, con);//执行sql语句
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            con.Close();
            return dataSet;
        }
        //private void show()
        //{
        //    string database = "Movie_ticket";
        //    string sql1= "select Amount,Total from Movie_ticket.Sales" +
        //        "where Sales.Mno='" + getMno.Text + "' and Sales.Cno='" + getCno.Text + "';";
        //    //string sql1 =
        //    //    "select count(*)*81,sum(Pamount) from Movie_ticket.Projection " +
        //    //    "where Projection.Mno='"+ getMno.Text + "' and Projection.Cno='" + getCno.Text + "';";
        //    DataSet dataSet1 = Databaseconnect(database, sql1);
        //    All_lbl.Text = dataSet1.Tables[0].Rows[0][0].ToString();
        //    sale_lbl.Text= dataSet1.Tables[0].Rows[0][1].ToString();

        //}

    }
}