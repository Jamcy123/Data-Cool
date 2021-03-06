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
    partial class DelControl : Smobiler.Core.Controls.MobileUserControl
    {
        string Mno;
        public DelControl() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();     
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
            string Cno = getCno.Text;
            string database = "Movie_ticket";
            string Mname = Mname_lbl.Text;
            string select = "select Mno from Movie where Mname ='" + Mname + "'";
            DataSet getMno = Databaseconnect(database, select);
            Mno = getMno.Tables[0].Rows[0][0].ToString();
            string select1 = "select * from Pmessage where Cno='" + Cno + "' and Mno='" + Mno + "';";
            DataSet check = Databaseconnect(database, select1);
            if (check.Tables[0].Rows.Count <= 0)
            {
                Toast("该影片已下架，请下拉刷新！");
            }
            else
            {
                string del = "delete from Pmessage where Cno='" + Cno + "'and Mno='" + Mno + "'";
                Databaseconnect(database, del);
            }
            
        }

        private void panel1_Press(object sender, EventArgs e)
        {
            Movieinf movieinf = new Movieinf(Mno);
            this.Form.Show(movieinf);
            
        }

        private void DelControl_Load(object sender, EventArgs e)
        {
            Mgrade_lbl.Text = Mgrade_lbl.Text + "分";

        }

        private void button2_Press(object sender, EventArgs e)
        {
            string Cno = getCno.Text;
            string database = "Movie_ticket";
            string Mname = Mname_lbl.Text;
            string select = "select Mno from Movie where Mname ='" + Mname + "';";
            DataSet getMno = Databaseconnect(database, select);
            string Mno = getMno.Tables[0].Rows[0][0].ToString();
            Arrange arrange = new Arrange(Cno,Mno);
            this.Form.Show(arrange);

        }
    }
}