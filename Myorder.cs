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

        private void Myorder_Load(object sender, EventArgs e)
        {
            //连接数据库
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=movie_ticket;uid=root;pwd=;";
            con.Open();
            //查询数据
            DataTable table=
            //赋值数据
            listView1.DataSource = ;
            //绑定数据
            listView1.DataBind();

        }
    }
}