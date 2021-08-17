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
        public addSession(string a,string b,string c) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            Cno = a;
            Mno = b;
            Pdate = c;
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
            string database = "movie_ticket";
            string insert="insert into Projection values('"+Cno+"','"+Mno + "',"+gethall.Text.Substring(0,1) +
                ",'" +Pdate+ " "+ datePicker1.BindDisplayValue+"','" +0 + "'," +getprice.Text+");";
            Databaseconnect(database, insert);
            string select = "select * from Projection where Cno='" + Cno + "'and Phall=" + gethall.Text.Substring(0, 1) + "and Ptime = '" +
                Pdate + " " + datePicker1.BindDisplayValue + "';";//判断是否存在同一影院同一放映厅同一时间的电影
            DataSet dataSet = Databaseconnect(database, select);
            string delete = "delete from Projection where Cno='" + Cno + "'and Mno='" + Mno + "'and Phall=" + gethall.Text.Substring(0, 1) +
                "and  Ptime like'" + Pdate + " " + datePicker1.BindDisplayValue + "'and Pprice =" + getprice.Text + ";";
            if (dataSet.Tables[0].Rows.Count>0)
            {
                Databaseconnect(database, delete);
                Toast("添加场次失败，请重新添加！");
            }
            else
            {
                string select1 = "select* from Projection where Cno='" + Cno + "'and Phall=" + gethall.Text.Substring(0, 1) + "and Ptime < '" +
                Pdate + " " + datePicker1.BindDisplayValue + "'and Ptime >'" + Pdate + " " + "00:00:00';";//判断是否存在同一影院同一放映厅早于该时间的电影
                DataSet dataSet1 = Databaseconnect(database, select1);
                if (dataSet1.Tables[0].Rows.Count > 0)
                {

                }
                else
                {
                    string select2 = "select* from Projection where Cno='" + Cno + "'and Phall=" + gethall.Text.Substring(0, 1) + "and Ptime >'" +
                Pdate + " " + datePicker1.BindDisplayValue + "'and Ptime <'" + Pdate + " " + "23:59:59';";//判断是否存在同一影院同一放映厅晚于该时间的电影
                    DataSet dataSet2 = Databaseconnect(database, select2);
                    if (dataSet2.Tables[0].Rows.Count > 0)
                    {

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