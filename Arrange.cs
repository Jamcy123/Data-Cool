using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmobilerAppTEST7._17
{
    partial class Arrange : Smobiler.Core.Controls.MobileForm
    {
        string Cno;
        string Mno;
        public Arrange(string a,string b) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Cno = a;
            Mno = b;
        }

        private void title_Control1_Load_1(object sender, EventArgs e)
        {

        }

        private void title_Control1_ExitButtonpPress(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}