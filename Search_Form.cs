﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerAppTEST7._17
{
    partial class Search_Form : Smobiler.Core.Controls.MobileForm
    {
        public Search_Form() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title_Control1_ExitButtonpPress_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}