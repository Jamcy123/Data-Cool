using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Drawing;

namespace SmobilerAppTEST7._17
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class Seat_Control : Smobiler.Core.Controls.MobileUserControl
    {
        bool pressbool = true;//判断座位是否到达四个
        public bool PressBool//pressbool属性
        {
            get { return pressbool; }
            set { pressbool = value; }
        }
        public Seat_Control() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public event EventHandler Seat_Ctrl_Press;//单击事件
        public Panel Seat_Panel//座位属性
        {
            get { return seat_panel; }
            set { seat_panel = value; }
        }
        public Panel Stop_Panel//实现不可选的属性
        {
            get { return stop_panel; }
            set { stop_panel = value; }
        }
        private void panel1_Press(object sender, EventArgs e)//单击选座变绿带勾，再点变灰
        {
            //事件响应
            if (Seat_Ctrl_Press != null)
            {
                Seat_Ctrl_Press.Invoke(this, EventArgs.Empty);
            }
            //颜色变化反馈
            if (seat_panel.BackColor == Color.White&&pressbool)
            {
                fontIcon1.Visible = true;
                seat_panel.BorderColor = Color.LimeGreen;
                seat_panel.BackColor = Color.LimeGreen;
            }
            else
            {
                fontIcon1.Visible = false;
                seat_panel.BorderColor = Color.LightGray;
                seat_panel.BackColor = Color.White;
            }

        }
    }
}