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
    partial class DControl : Smobiler.Core.Controls.MobileUserControl
    {
        string Mno;
        public DControl() : base()
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
        private void button1_Press(object sender, EventArgs e)
        {
            string database = "Movie_ticket";
            string Mname = Mname_lbl.Text;
            string del = "delete from Movie where Mname='" + Mname + "'" ;
            Databaseconnect(database, del);
            string select= "select Mno from Movie where Mname='" + Mname + "'";
            DataSet dataSet= Databaseconnect(database, select);
            Mno = dataSet.Tables[0].Rows[0].ToString();
        }

        private void panel1_Press(object sender, EventArgs e)
        {
            Movieinf movieinf = new Movieinf(Mno);
            this.Form.Show(movieinf);
        }
    }
}