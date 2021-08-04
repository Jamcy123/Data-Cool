using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Drawing;
using System.Data;
using MySql.Data.MySqlClient;

namespace SmobilerAppTEST7._17
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {

      
        public SmobilerForm1() : base()
        {
            InitializeComponent(); 
           
        }

        private void btnLogon_Press(object sender, EventArgs e)
        {
            try
            {
                string userID = txtUserName.Text.Trim();
                string PassWord = txtPassword.Text.Trim();
                if (userID.Length != 11)
                {
                    txtUserName.Text = "";
                    throw new Exception("请输入11位的账号");
                }
                if (string.IsNullOrEmpty(userID))
                    throw new Exception("请输入用户名");
                if (string.IsNullOrEmpty(PassWord))
                    throw new Exception("请输入密码");
                if (checkRemb.Checked == true)
                {
                    //记住密码

                    LoadClientData("PWD", PassWord);
                    //读取密码
                    ReadClientData("PWD", (object s, ClientDataResultHandlerArgs args) =>
                     {
                         if (string.IsNullOrEmpty(args.error))
                         {
                             Toast("密码为" + args.Value);
                         }
                     });
                }
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=127.0.0.1;Database=movie_ticket;uid=root;pwd=;";
                con.Open();
                string select = "Select Upassword from Userinf where Uphoneno=" + txtUserName.Text;
                MySqlDataAdapter find = new MySqlDataAdapter(select, con);
                DataSet save = new DataSet();//缓存
                find.Fill(save);//Fill(DataSet)	在 DataSet 中添加或刷新行。

                if (save.Tables[0].Rows.Count <= 0)
                {
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    throw new Exception("用户不存在，请重新输入！");
                }
                   

                string pwd = save.Tables[0].Rows[0][0].ToString();

                if (pwd == txtPassword.Text)
                {
                    MessageBox.Show("密码正确");
                    string a = txtUserName.Text;
                    moive_select moive_Select = new moive_select(a);
                    this.Show(moive_Select);
                }
                else
                {
                    throw new Exception("密码不正确，请重新输入！");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnForget_Press(object sender, EventArgs e)
        {
            try
            {
                RemoveClientData("PWD", (object s, ClientDataResultHandlerArgs args) =>
                {
                    if (string.IsNullOrEmpty(args.error))
                    {
                        Toast("密码已成功清除" );
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void button1_Press(object sender, EventArgs e)
        {
            string a = txtUserName.Text;
            moive_select moive_Select = new moive_select(a);
            this.Show(moive_Select);
        }

        private void btnregister_Press(object sender, EventArgs e)
        {
            register register= new register();
            this.Show(register);
        }
    }
}