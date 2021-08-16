using MySql.Data.MySqlClient;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;

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
            try
            {
                string select = "SELECT * FROM Movie_ticket.myorder where Uphoneno=" + Uno;
                string database = "Movie_ticket";
                DataSet dataSet = Databaseconnect(database, select);
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
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void title_Control1_ExitButtonpPress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_RowBind(object sender, ListViewTemplateBindEventArgs e)//行绑定事件
        {
            //根据电影结束时间判断有没有完成订单
            string Mduration = ((Label)e.Row.Control.Controls.Find("label2", true)).BindDataValue.ToString();
            string Ptime = ((Label)e.Row.Control.Controls.Find("label2", true)).BindDisplayValue.ToString();
            string[] subs = Ptime.Split(' ', '/', ':');
            DateTime dateTime = new DateTime(int.Parse(subs[0]), int.Parse(subs[1]), int.Parse(subs[2]), int.Parse(subs[3]), int.Parse(subs[4]), int.Parse(subs[5]));
            dateTime = dateTime.AddMinutes(int.Parse(Mduration));//计算电影结束时间
            if (dateTime.CompareTo(DateTime.Now) >= 0)//当前时间早于结束时间
            {
                ((Label)e.Row.Control.Controls.Find("label7")).Text = "未完成";
                ((Label)e.Row.Control.Controls.Find("label7")).ForeColor = Color.Red;
            }
            else
            {
                ((Label)e.Row.Control.Controls.Find("label7")).Text = "已完成";
                ((Label)e.Row.Control.Controls.Find("label7")).ForeColor = Color.DarkGray;
            }
        }
    }
}