using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerAppTEST7._17
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    [System.ComponentModel.ToolboxItem(true)]
    partial class SeatMes_Control : Smobiler.Core.Controls.MobileUserControl
    {
        public SeatMes_Control() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public event EventHandler Delete_btn_Press;//删除事件
        public string Seat_Text//座位属性
        {
            get { return seat_Text.Text; }
            set { Seat_Text = value; }
        }
        public string Money_Text//价格属性
        {
            get { return money_Text.Text; }
            set { Money_Text = value; }
        }
        private void delete_btn_Press(object sender, EventArgs e)//单击事件
        {
            if (Delete_btn_Press != null)
                Delete_btn_Press.Invoke(this, EventArgs.Empty);
        }
    }
}