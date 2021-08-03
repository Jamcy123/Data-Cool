using MySql.Data.MySqlClient;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
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
            password = txtPassword.Text.Trim();
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
                string insert = "Insert into userinf (Uphoneno,Upassword,Ublance,Usex) values(" + txtUserphone.Text + ',' + txtPassword.Text + ',' + sex + ") ";
                Toast("注册成功");
            }
            con.Close();
        }
    }
}