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
    partial class Myorder : Smobiler.Core.Controls.MobileForm
    {
        string Uno;
        public Myorder(string a) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Uno = a;
        }

        private void Myorder_Load(object sender, EventArgs e)
        {

        }
    }
}