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
    partial class Myorder : Smobiler.Core.Controls.MobileForm
    {
        string Uno;
        public Myorder(string a) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Uno = a;
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
        private void Myorder_Load(object sender, EventArgs e)
        {
            string select = "SELECT * FROM Movie_ticket.myorder where Uphoneno=" +Uno;
            string database = "Movie_ticket";
            DataSet dataSet = Databaseconnect(database, select);;
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                listView1.DataSource = dataSet;
                listView1.DataBind();
            }
        }

        private void title_Control1_ExitButtonpPress(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}