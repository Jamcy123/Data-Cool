using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmobilerAppTEST7._17
{
    partial class cinema_known : Smobiler.Core.Controls.MobileForm
    {
        public cinema_known() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void cinema_known_Load(object sender, EventArgs e)
        {
            string[] cinema_time = { DateTime.Now.ToShortDateString().ToString(), DateTime.Now.AddDays(1).ToShortDateString().ToString(), DateTime.Now.AddDays(2).ToShortDateString().ToString() };
            tabPageView1.Titles = cinema_time;
        }
    }
}