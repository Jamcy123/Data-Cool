using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerAppTEST7._17
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class Moive_Control : Smobiler.Core.Controls.MobileUserControl
    {
        public Moive_Control() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void panel1_Press(object sender, EventArgs e)
        {
            MessageBox.Show("电影编号为" + Mname_lbl.BindDataValue.ToString());
            //movie_information movie_Information = new movie_information(Mname_lbl.BindDataValue.ToString());
            //this.Form.Show(movie_Information);
        }

        private void Moive_Control_Load(object sender, EventArgs e)
        {
            Mgrade_lbl.Text = Mgrade_lbl.Text + "分";
        }

        private void button1_Press(object sender, EventArgs e)
        {

        }
    }
}