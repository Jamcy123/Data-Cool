using System;
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

        private void searchBox_Control1_SearchButtonPress(object sender, EventArgs e)
        {
            label3.Text=searchBox_Control1.TextBox_Text;
        }

        private void movie_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(movie_checkBox.Checked == false)
                cinema_checkBox.Checked = true;
            else
                cinema_checkBox.Checked = false;
        }

        private void cinema_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cinema_checkBox.Checked == false)
                movie_checkBox.Checked = true;
            else
                movie_checkBox.Checked = false;
        }
    }
}