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
    partial class Alterpassword : Smobiler.Core.Controls.MobileForm
    {
        public Alterpassword() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
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
        private void button1_Press(object sender, EventArgs e)
        {
            
            string select = "Select Upassword from Userinf where Uphoneno=" + txtUserphone.Text;
            string database = "Movie_ticket";
            DataSet save = Databaseconnect(database, select);
          

            if (save.Tables[0].Rows.Count <= 0)
            {
                txtUserphone.Text = "";
                txtPassword.Text = "";
                txtnewpassword.Text = "";
                txtsure.Text = "";
                Toast("该用户不存在，请重新输入！");
            }


            string pwd = save.Tables[0].Rows[0][0].ToString();

            if (pwd == txtPassword.Text)
            {
                if (txtPassword.Text != txtnewpassword.Text)
                {
                    string update = "Update Userinf set Upassword='" + txtnewpassword.Text + "' where Uphoneno='" + txtUserphone.Text + "'";
                    Databaseconnect(database, update);
                    string sure = "Select Upassword from Userinf where Uphoneno=" + txtUserphone.Text;
                    DataSet ta = Databaseconnect(database, sure);
                    
                    if (ta.Tables[0].Rows.Count <= 0)
                        Toast("修改失败！");
                    else
                    {
                        string update1 = "Update Userinf set Uip='" + 123456 + "' where Uphoneno='" + txtUserphone.Text + "'";
                        Toast("修改成功！");
                        this.Close();
                    }
                }
                else
                {
                    txtnewpassword.Text = "";
                    txtsure.Text = "";
                    Toast("新密码与旧密码重复，请重新输入");
                }
            }
            else
            {
                Toast("密码不正确，请重新输入！");
            }
        }
    }
}