using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmobilerAppTEST7._17
{
    partial class cinema_confirm : Smobiler.Core.Controls.MobileForm
    {
        public cinema_confirm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void cinema_confirm_Load(object sender, EventArgs e)
        {
            tabPageView1.Controls.Add(new Label { Text = "第一页", Name = "lblShow", BackColor = System.Drawing.Color.Transparent });
            tabPageView1.Controls.Add(new Label { Text = "第二页", Name = "lblTest", BackColor = System.Drawing.Color.Transparent });
        }
    }
}