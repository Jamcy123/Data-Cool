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
    partial class Arrange : Smobiler.Core.Controls.MobileForm
    {
        string Cno;
        string Mno;
      
        public Arrange(string a,string b) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Cno = a;
            Mno = b;
            showMovieMessage();
            showSession();
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
        private void title_Control1_Load_1(object sender, EventArgs e)
        {

        }

        private void showMovieMessage()
        {
            string database = "movie_ticket";
            string select = "SELECT * FROM movie_ticket.movie where Mno = '" + Mno + "';";
            DataSet dataSet = Databaseconnect(database, select);
            Mname_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            Mlanguage_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
            Mtype_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[3].ToString();
            Mduration_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[5].ToString();
            Mgrade_lbl.Text = dataSet.Tables[0].Rows[0].ItemArray[7].ToString();
            Mpicadress_image.ResourceID = dataSet.Tables[0].Rows[0].ItemArray[4].ToString();
        }
        private void showSession()
        {
            string[] a = { "今天"+DateTime.Now.ToShortDateString().ToString(), "明天"+DateTime.Now.AddDays(1).ToShortDateString().ToString(), "后天"+DateTime.Now.AddDays(2).ToShortDateString().ToString() };
            tabPageView1.Titles = a;
            string database = "movie_ticket";
            string select1 = "SELECT * FROM movie_ticket.Projection where Mno = '" + Mno + "'and Cno ='" + Cno + "'and Ptime like '" + DateTime.Now.ToString("yyyy-MM-dd") + "%' " +
                "order by Ptime";
            string select2 = "SELECT * FROM movie_ticket.Projection where Mno = '" + Mno + "'and Cno ='" + Cno + "'and Ptime like '" + DateTime.Now.AddDays(1).ToString("yyyy-MM-dd") + "%' " +
                "order by Ptime";
            string select3 = "SELECT * FROM movie_ticket.Projection where Mno = '" + Mno + "'and Cno ='" + Cno + "'and Ptime like '" + DateTime.Now.AddDays(2).ToString("yyyy-MM-dd") + "%'" +
                "order by Ptime";
            DataSet today = Databaseconnect(database, select1);
            DataSet tomorrow= Databaseconnect(database, select2);
            DataSet todayaftertomorrow = Databaseconnect(database, select3);


            if (today.Tables[0].Rows.Count>0)    //绑定数据源
            {
                listView1.DataSource = today;
                listView1.DataBind();
            }
            else
            {
                nothing1.Visible = true;
            }
            if (tomorrow.Tables[0].Rows.Count > 0)    //绑定数据源
            {
                listView2.DataSource = tomorrow;
                listView2.DataBind();
            }
            else
            {
                nothing2.Visible = true;
            }
            if (todayaftertomorrow.Tables[0].Rows.Count > 0)    //绑定数据源
            {
                listView3.DataSource = todayaftertomorrow;
                listView3.DataBind();
            }
            else
            {
                nothing3.Visible = true;
            }

        }

        private void title_Control1_ExitButtonpPress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_RowBind(object sender, ListViewTemplateBindEventArgs e)
        {
            ((Label)e.Row.Control.Controls.Find("getCno")).Text = Cno;
            ((Label)e.Row.Control.Controls.Find("getMno")).Text = Mno;
            ((Label)e.Row.Control.Controls.Find("getdate")).Text = DateTime.Now.ToString("yyyy-MM-dd");
            ((Label)e.Row.Control.Controls.Find("getlanguage",true)).Text = Mlanguage_lbl.Text;
            ((Label)e.Row.Control.Controls.Find("finish", true)).Text = Mduration_lbl.Text;
            ((Label)e.Row.Control.Controls.Find("price", true)).Text = "￥" + ((Label)e.Row.Control.Controls.Find("price", true)).BindDisplayValue.ToString();
            ((Label)e.Row.Control.Controls.Find("hall", true)).Text = ((Label)e.Row.Control.Controls.Find("hall", true)).BindDisplayValue.ToString()+"号放映厅";
            string[] subs = ((Label)e.Row.Control.Controls.Find("time", true)).BindDisplayValue.ToString().Split(' ', '/', ':');
            ((Label)e.Row.Control.Controls.Find("time", true)).Text = subs[3] + ":" + subs[4];
            DateTime dateTime = new DateTime(int.Parse(subs[0]), int.Parse(subs[1]), int.Parse(subs[2]), int.Parse(subs[3]), int.Parse(subs[4]), int.Parse(subs[5]));
            dateTime = dateTime.AddMinutes(int.Parse(((Label)e.Row.Control.Controls.Find("finish", true)).Text.ToString()));//计算电影结束时间
            string[] finish = dateTime.ToString().Split(' ', '/', ':');
            ((Label)e.Row.Control.Controls.Find("finish", true)).Text = finish[3] + ":" + finish[4] + "散场";
        }

        private void listView2_RowBind(object sender, ListViewTemplateBindEventArgs e)
        {
            ((Label)e.Row.Control.Controls.Find("getCno")).Text = Cno;
            ((Label)e.Row.Control.Controls.Find("getMno")).Text = Mno;
            ((Label)e.Row.Control.Controls.Find("getdate")).Text = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
            ((Label)e.Row.Control.Controls.Find("getlanguage",true)).Text = Mlanguage_lbl.Text;
            ((Label)e.Row.Control.Controls.Find("finish", true)).Text = Mduration_lbl.Text;
            ((Label)e.Row.Control.Controls.Find("price", true)).Text = "￥" + ((Label)e.Row.Control.Controls.Find("price", true)).BindDisplayValue.ToString();
            ((Label)e.Row.Control.Controls.Find("hall", true)).Text = ((Label)e.Row.Control.Controls.Find("hall", true)).BindDisplayValue.ToString() + "号放映厅";
            string[] subs = ((Label)e.Row.Control.Controls.Find("time", true)).BindDisplayValue.ToString().Split(' ', '/', ':');
            ((Label)e.Row.Control.Controls.Find("time", true)).Text = subs[3] + ":" + subs[4];
            DateTime dateTime = new DateTime(int.Parse(subs[0]), int.Parse(subs[1]), int.Parse(subs[2]), int.Parse(subs[3]), int.Parse(subs[4]), int.Parse(subs[5]));
            dateTime = dateTime.AddMinutes(int.Parse(((Label)e.Row.Control.Controls.Find("finish", true)).Text.ToString()));//计算电影结束时间
            string[] finish=dateTime.ToString().Split(' ', '/', ':');
            ((Label)e.Row.Control.Controls.Find("finish", true)).Text = finish[3]+":"+finish[4] + "散场";
        }

        private void listView3_RowBind(object sender, ListViewTemplateBindEventArgs e)
        {
            ((Label)e.Row.Control.Controls.Find("getCno")).Text = Cno;
            ((Label)e.Row.Control.Controls.Find("getMno")).Text = Mno;
            ((Label)e.Row.Control.Controls.Find("getdate")).Text = DateTime.Now.AddDays(2).ToString("yyyy-MM-dd");
            ((Label)e.Row.Control.Controls.Find("getlanguage",true)).Text = Mlanguage_lbl.Text;
            ((Label)e.Row.Control.Controls.Find("finish", true)).Text = Mduration_lbl.Text;
            ((Label)e.Row.Control.Controls.Find("price", true)).Text = "￥" + ((Label)e.Row.Control.Controls.Find("price", true)).BindDisplayValue.ToString();
            ((Label)e.Row.Control.Controls.Find("hall", true)).Text = ((Label)e.Row.Control.Controls.Find("hall", true)).BindDisplayValue.ToString() + "号放映厅";
            string[] subs = ((Label)e.Row.Control.Controls.Find("time", true)).BindDisplayValue.ToString().Split(' ', '/', ':');
            ((Label)e.Row.Control.Controls.Find("time", true)).Text = subs[3] + ":" + subs[4];
            DateTime dateTime = new DateTime(int.Parse(subs[0]), int.Parse(subs[1]), int.Parse(subs[2]), int.Parse(subs[3]), int.Parse(subs[4]), int.Parse(subs[5]));
            dateTime = dateTime.AddMinutes(int.Parse(((Label)e.Row.Control.Controls.Find("finish", true)).Text.ToString()));//计算电影结束时间
            string[] finish = dateTime.ToString().Split(' ', '/', ':');
            ((Label)e.Row.Control.Controls.Find("finish", true)).Text = finish[3] + ":" + finish[4] + "散场";
        }

        private void button1_Press(object sender, EventArgs e)
        {
            addSession addSession = new addSession(Cno, Mno, DateTime.Now.ToString("yyyy-MM-dd"));
            this.Form.ShowDialog(addSession);
        }

        private void button2_Press(object sender, EventArgs e)
        {
            addSession addSession = new addSession(Cno, Mno, DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"));
            this.Form.ShowDialog(addSession);
        }

        private void button3_Press(object sender, EventArgs e)
        {
            addSession addSession = new addSession(Cno, Mno, DateTime.Now.AddDays(2).ToString("yyyy-MM-dd"));
            this.Form.ShowDialog(addSession);
        }

        private void listView1_Refresh(object sender, EventArgs e)
        {
            string database = "movie_ticket";
            string select1 = "SELECT * FROM movie_ticket.Projection where Mno = '" + Mno + "'and Cno ='" + Cno + "'and Ptime like '" + DateTime.Now.ToString("yyyy-MM-dd") + "%' " +
                "order by Ptime";
            DataSet today = Databaseconnect(database, select1);
            if (today.Tables[0].Rows.Count > 0)    //绑定数据源
            {
                listView1.DataSource = today;
                listView1.DataBind();
            }
            else
            {
                nothing1.Visible = true;
            }
        }

        private void listView2_Refresh(object sender, EventArgs e)
        {
            string database = "movie_ticket";
            string select2 = "SELECT * FROM movie_ticket.Projection where Mno = '" + Mno + "'and Cno ='" + Cno + "'and Ptime like '" + DateTime.Now.AddDays(1).ToString("yyyy-MM-dd") + "%' " +
               "order by Ptime";
            DataSet tomorrow = Databaseconnect(database, select2);
            if (tomorrow.Tables[0].Rows.Count > 0)    //绑定数据源
            {
                listView2.DataSource = tomorrow;
                listView2.DataBind();
            }
            else
            {
                nothing2.Visible = true;
            }
           
        }

        private void listView3_Refresh(object sender, EventArgs e)
        {
            string database = "movie_ticket";
            string select3 = "SELECT * FROM movie_ticket.Projection where Mno = '" + Mno + "'and Cno ='" + Cno + "'and Ptime like '" + DateTime.Now.AddDays(2).ToString("yyyy-MM-dd") + "%'" +
                "order by Ptime";
            DataSet todayaftertomorrow = Databaseconnect(database, select3);
            if (todayaftertomorrow.Tables[0].Rows.Count > 0)    //绑定数据源
            {
                listView3.DataSource = todayaftertomorrow;
                listView3.DataBind();
            }
            else
            {
                nothing3.Visible = true;
            }
        }
    }
}