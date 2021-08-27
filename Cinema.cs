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
    partial class Cinema : Smobiler.Core.Controls.MobileForm
    {
        string Cno;
        string Uno;
        public Cinema(string a,string b) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Cno = a;
            Uno = b;
            showlabel(a);
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

        public void showlabel(string a)
        {

                string txt2 = "select Cname,Caddress from Cinema where Cno=" + a;
                string database = "Movie_ticket";
                DataSet name = Databaseconnect(database, txt2);
                label1.Text = name.Tables[0].Rows[0][0].ToString();
                label2.Text = name.Tables[0].Rows[0][1].ToString();
            
            
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
                case "cinema":
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void iconMenuView1_ItemPress(object sender, IconMenuViewItemPressEventArgs e)
        {

        }

        private void button1_Press(object sender, EventArgs e)
        {
            this.Form.Client.ReStart();
        }

        private void button2_Press(object sender, EventArgs e)
        {
            Alterpassword alterpassword = new Alterpassword();
            this.Show(alterpassword);
        }
    }
}