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
    partial class Sale : Smobiler.Core.Controls.MobileForm
    {
        string Cno;
        public Sale(string a) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Cno = a;
            showmovie();
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
        public void setToolbarIndex(int i)
        {
            toolBar1.SelectedIndex = i;//底部栏默认选项
        }

        public string ToolBarItemName { get; set; }//底部工具栏选项
        private void toolBar1_ToolbarItemClick_1(object sender, ToolbarClickEventArgs e)
        {
            ToolBarItemName = e.Name;
            switch (e.Name)
            {
                case "sale":
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        public void showmovie()
        {
            string database = "Movie_ticket";
            string sql1 = "alter table Movie_ticket.Movie add column Cno varchar(10) default '" + Cno + "';" +
                "select * from Movie_ticket.Movie " +
                "where exists( select * from Project where Movie.Mno=Project.Mno and Project.Cno='" + Cno + "');";
            DataSet dataSet1 = Databaseconnect(database, sql1);   
            listView1.DataSource = dataSet1;
            listView1.DataBind();
            string sql = "alter table Movie_ticket.Movie drop column Cno";
            Databaseconnect(database, sql);

        }
        private void searchBox_Control1_SearchButtonPress(object sender, EventArgs e)
        {

        }

        private void searchBox_Control1_Load(object sender, EventArgs e)
        {

        }
    }
}