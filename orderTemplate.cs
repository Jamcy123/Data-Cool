using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmobilerAppTEST7._17
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class orderTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        public orderTemplate() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void orderTemplate_Load(object sender, EventArgs e)
        {
            label3.Text = label3.Text + "号厅";
            label6.Text = label6.Text + " >";
            label8.Text = label8.Text + "元";
        }

        private void panel2_Press(object sender, EventArgs e)//影院详情链接
        {
            this.Form.Show(new cinema_confirm(label6.BindDataValue.ToString()));
        }

        private void panel1_Press(object sender, EventArgs e)//电影链接详情
        {
            this.Form.Show(new movie_information(label1.BindDataValue.ToString()));
        }

        private void button1_Press(object sender, EventArgs e)
        {
            //label2.Text = "2021/8/15 9:00:00";
            string ptime = label2.BindDisplayValue.ToString();
            string[] subs = ptime.Split(' ');
            Toast(subs[1]);
        }
    }
}