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
    partial class register : Smobiler.Core.Controls.MobileForm
    {

        public register() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            string sex,password;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=movie_ticket;uid=root;pwd=;";
            con.Open();
            password = txtPassword.Text.Trim();
            string judge = "Select Upassword from Userinf where Uphoneno=" + txtUserphone.Text;
            MySqlCommand da = new MySqlCommand(judge, con);
            MySqlDataReader dr = da.ExecuteReader();
            bool b = dr.Read();
            con.Close();
            con.Open();
            if (b)
            {
                Toast("该电话号码已注册");
                this.Close();
            }
            else
            {
                if (password.Length < 6)
                {
                    txtPassword.Text = "";
                    txtsure.Text = "";
                    Toast("请至少输入6位密码");
                }
                else
                {
                    if (txtPassword.Text != txtsure.Text)
                    {
                        txtsure.Text = "";
                        Toast("密码错误，请重新输入");
                    }
                    if (checkBox1.Checked == true)
                        sex = "男";
                    else
                        sex = "女";
                    string insert = "Insert into Userinf (Uphoneno,Upassword,Ublance,Usex) values(\"" + txtUserphone.Text + "\",\"" + txtPassword.Text + "\",\"" + "0" + "\",\"" + sex + "\")";
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(insert, con);
                    DataSet dataSet = new DataSet();
                    mySqlDataAdapter.Fill(dataSet);
                    string select = "Select Upassword from Userinf where Uphoneno=" + txtUserphone.Text;
                    MySqlDataAdapter find = new MySqlDataAdapter(select, con);
                    DataSet save = new DataSet();//缓存
                    find.Fill(save);//Fill(DataSet)	在 DataSet 中添加或刷新行。
                    if (save.Tables[0].Rows.Count <= 0)
                        Toast("注册失败！");
                    else
                        Toast("注册成功！");
                }
            }
            con.Close();
        }
    }
}