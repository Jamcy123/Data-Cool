using MySql.Data.MySqlClient;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
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
            string password = txtPassword.Text.Trim();
        }
    }
}