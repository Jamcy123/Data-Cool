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
    partial class cmTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        public cmTemplate() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void panel1_Press(object sender, EventArgs e)
        {
            string movie_name;
            movie_name = Mduration_lbl.BindDataValue.ToString();
            string movie_no;
            movie_no = Mtype_lbl.BindDataValue.ToString();
            string cinema_name;
            cinema_name = Phall_lbl.BindDataValue.ToString();
            string cinema_no;
            cinema_no = Ptime_lbl.BindDataValue.ToString();
            DateTime t = Convert.ToDateTime(shichang_lbl.BindDataValue.ToString());
            string week = t.ToString("yyyy年MM日dd日 dddd");
            Console.WriteLine(week);
            week = t.ToString("dddd");
            string projection_time = shichang_lbl.BindDataValue.ToString();
            string user_no = this.Client.Session[0].ToString();

            this.Form.Show(new Seat_Form(user_no,movie_name,movie_no,cinema_name,cinema_no,Convert.ToInt32(Phall_lbl.Text),week, projection_time, Pprice_lbl.Text));
        }

        private void button1_Press(object sender, EventArgs e)
        {
            string movie_name;
            movie_name = Mduration_lbl.BindDataValue.ToString();
            string movie_no;
            movie_no = Mtype_lbl.BindDataValue.ToString();
            string cinema_name;
            cinema_name = Phall_lbl.BindDataValue.ToString();
            string cinema_no;
            cinema_no = Ptime_lbl.BindDataValue.ToString();
            DateTime t = Convert.ToDateTime(shichang_lbl.BindDataValue.ToString());
            string week = t.ToString("yyyy年MM日dd日 dddd");
            Console.WriteLine(week);
            week = t.ToString("dddd");
            string projection_time = shichang_lbl.BindDataValue.ToString();
            string user_no = this.Client.Session[0].ToString();

            this.Form.Show(new Seat_Form(user_no, movie_name, movie_no, cinema_name, cinema_no, Convert.ToInt32(Phall_lbl.Text), week, projection_time, Pprice_lbl.Text));

        }

        private void cmTemplate_Load(object sender, EventArgs e)
        {
            Mduration_lbl.Text = Mduration_lbl.Text + "分钟";
        }
    }
}