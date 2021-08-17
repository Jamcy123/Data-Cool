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
            string sql1 =
                "select * from Movie_ticket.Sales " +
                "where Cno='" + Cno + "');";
            DataSet dataSet1 = Databaseconnect(database, sql1);            
            listView1.DataSource = dataSet1;
            listView1.DataBind();
 
        }
        private void searchBox_Control1_SearchButtonPress(object sender, EventArgs e)
        {

        }



        private void listView1_RowBind(object sender, ListViewTemplateBindEventArgs e)
        {
            ((Label)e.Row.Control.Controls.Find("getCno")).Text = Cno;
            
        }

        private void panel3_Press(object sender, EventArgs e)
        {
            popList1.ShowDialog();
        }

        private void panel4_Press(object sender, EventArgs e)
        {
            popList2.ShowDialog();
        }

        private void popList1_Selected(object sender, EventArgs e)
        {
            order.Text=popList1.Selection.Text.ToString();
            string database = "Movie_ticket";
            if (sequence.Text=="升序")
            {
                switch (order.Text)
                {
                    case "电影评分":
                        string sql1 =
                        "select * from Movie_ticket.Sales " +
                        "where Cno='" + Cno + "')" +
                        "order by Mgrade;";
                        DataSet dataSet1 = Databaseconnect(database, sql1);
                        listView1.DataSource = dataSet1;
                        listView1.DataBind();
                        break;
                    case "售出数量":
                        string sql2 =
                        "select * from Movie_ticket.Sales " +
                        "where Cno='" + Cno + "')" +
                        "order by Total;";
                        DataSet dataSet2 = Databaseconnect(database, sql2);
                        listView1.DataSource = dataSet2;
                        listView1.DataBind();
                        break;
                    case "售出数量/总数量":
                        string sql3 =
                        "select * from Movie_ticket.Sales " +
                        "where Cno='" + Cno + "')" +
                        "order by Total;";
                        DataSet dataSet3 = Databaseconnect(database, sql3);
                        listView1.DataSource = dataSet3;
                        listView1.DataBind();
                        break;
                }
            }
            else
            {
                switch (order.Text)
                {
                    case "电影评分":
                        string sql1 =
                        "select * from Movie_ticket.Sales " +
                        "where Cno='" + Cno + "')" +
                        "order by Mgrade desp;";
                        DataSet dataSet1 = Databaseconnect(database, sql1);
                        listView1.DataSource = dataSet1;
                        listView1.DataBind();
                        break;
                    case "售出数量":
                        string sql2 =
                        "select * from Movie_ticket.Sales " +
                        "where Cno='" + Cno + "')" +
                        "order by Total desp;";
                        DataSet dataSet2 = Databaseconnect(database, sql2);
                        listView1.DataSource = dataSet2;
                        listView1.DataBind();
                        break;
                    case "售出数量/总数量":
                        string sql3 =
                        "select * from Movie_ticket.Sales " +
                        "where Cno='" + Cno + "')" +
                        "order by Total/Amount desp;";
                        DataSet dataSet3 = Databaseconnect(database, sql3);
                        listView1.DataSource = dataSet3;
                        listView1.DataBind();
                        break;
                }
            }
        }

        private void popList2_Selected(object sender, EventArgs e)
        {
            sequence.Text = popList2.Selection.Text.ToString();
        }
    }
}