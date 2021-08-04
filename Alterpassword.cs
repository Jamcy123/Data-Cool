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

        private void button1_Press(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=movie_ticket;uid=root;pwd=;";
            con.Open();
            //string password = txtPassword.Text.Trim();
            string select = "Select Upassword from Userinf where Uphoneno=" + txtUserphone.Text;
            MySqlDataAdapter find = new MySqlDataAdapter(select, con);
            DataSet save = new DataSet();//缓存
            find.Fill(save);//Fill(DataSet)	在 DataSet 中添加或刷新行。

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
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(update, con);
                    DataSet dataSet = new DataSet();
                    mySqlDataAdapter.Fill(dataSet);
                    string sure = "Select Upassword from Userinf where Uphoneno=" + txtUserphone.Text;
                    MySqlDataAdapter right = new MySqlDataAdapter(sure, con);
                    DataSet ta = new DataSet();//缓存
                    right.Fill(ta);//Fill(DataSet)	在 DataSet 中添加或刷新行。
                    if (ta.Tables[0].Rows.Count <= 0)
                        Toast("修改失败！");
                    else
                    {
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