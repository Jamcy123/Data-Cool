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
    partial class Movieinf : Smobiler.Core.Controls.MobileForm
    {
        public Movieinf() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        string movie_no;//当前页面电影编号
        public Movieinf(string a) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            movie_no = a;
        }


        private System.Data.DataSet Databaseconnect(string dabatase, string sql)//数据库连接调用函数
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
        private void movie_information_Load(object sender, EventArgs e)
        {
            string database = "movie_ticket";
            string select = "SELECT * FROM movie_ticket.movie where Mno =" + movie_no + ";";
            DataSet dataSet = Databaseconnect(database, select);
            Mname_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            Mlanguage_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
            Mtype_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[3].ToString();
            Mduration_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[5].ToString();
            Mdetail_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[6].ToString();
            Mgrade_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[7].ToString();
            Mpicadress_image.ResourceID = dataSet.Tables[0].Rows[0].ItemArray[4].ToString();
            Mno_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();//不可见
        }


        private void title_Control1_ExitButtonpPress(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}