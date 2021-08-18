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
    partial class addSession : Smobiler.Core.Controls.MobileUserControl
    {
        string Cno;
        string Mno;
        string Pdate;
        string Duration;
        public addSession(string a, string b, string c, string d) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            Cno = a;
            Mno = b;
            Pdate = c;
            Duration = d;
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
            string[] gettime = datePicker1.BindDisplayValue.ToString().Split(' ', '/', ':');
            string Time = gettime[3] +":"+ gettime[4];
            string database = "movie_ticket";
            string sure = "select * from Projection where Cno='" + Cno + "'and Mno='" + Mno + "'and Phall=" + gethall.Text.Substring(0, 1) +
                "and  Ptime = '" + Pdate + " " + Time + "';";
            DataSet data=Databaseconnect(database, sure);
            if(data.Tables[0].Rows.Count > 0)
            {
                Toast("添加场次失败，请重新添加！");
            }
            else
            {
                string insert = "insert into Projection values('" + Cno + "','" + Mno + "'," + gethall.Text.Substring(0, 1) +
                ",'" + Pdate + " " + Time + "','" + 0 + "'," + getprice.Text + ");";
                Databaseconnect(database, insert);
                string select = "select * from Projection,Movie where Movie.Mno=Projection.Mno and Cno='" + Cno + "'and Phall="
                    + gethall.Text.Substring(0, 1) + " and Ptime < '" + Pdate + " " + Time +
                     "'and Ptime >'" + Pdate + " " + "00:00:00'" +
                    "and date_add(Ptime,interval Mduration minute)>'" + Pdate + " " + Time + "';";
                DataSet dataSet = Databaseconnect(database, select);
                string delete = "delete from Projection where Cno='" + Cno + "'and Mno='" + Mno + "'and Phall=" + gethall.Text.Substring(0, 1) +
                    "and  Ptime like'" + Pdate + " " + Time + "'and Pprice =" + getprice.Text + ";";
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    Databaseconnect(database, delete);
                    Toast("添加场次失败，请重新添加！");
                }
                else
                {
                    string time = Pdate + Time;
                    string[] subs = time.Split(' ', '/', ':');
                    DateTime dateTime = new DateTime(int.Parse(subs[0]), int.Parse(subs[1]), int.Parse(subs[2]), int.Parse(subs[3]), int.Parse(subs[4]), int.Parse(subs[5]));
                    dateTime = dateTime.AddMinutes(int.Parse(Duration));
                    string select1 =
                      "select * from Projection,Movie where Movie.Mno=Projection.Mno and Cno='" + Cno + "'and Phall="
                  + gethall.Text.Substring(0, 1) + "and Ptime > '" + Pdate + " " + Time +
                   "'and Ptime <'" + Pdate + " " + "23:59:59'" +
                  "and Ptime<'" + dateTime + "';";

                    DataSet dataSet1 = Databaseconnect(database, select1);
                    if (dataSet1.Tables[0].Rows.Count > 0)
                    {
                        Databaseconnect(database, delete);
                        Toast("添加场次失败，请重新添加！");
                    }
                    else
                    {
                        Toast("添加成功！");
                        this.Form.Close();
                    }
                }
            }
            
         }
    



        private void popList1_Selected(object sender, EventArgs e)
        {
            gethall.Text = popList1.Selection.Text.ToString();
        }

        private void panel2_Press(object sender, EventArgs e)
        {
            popList1.ShowDialog();
        }
    }
}