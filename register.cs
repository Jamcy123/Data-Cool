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
            string sex;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=movie_ticket;uid=root;pwd=;";
            if (checkBox1.Checked == true)
                sex = "男";
            else
                sex = "女";
            string insert = "Insert into userinf (Uphoneno,Upassword,Ublance,Usex) values(" + txtUserphone.Text + ',' + txtPassword.Text + ','+ sex+") ";
            throw new Exception("注册成功");

        }
    }
}