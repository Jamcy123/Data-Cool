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
    partial class TicketMes_Control : Smobiler.Core.Controls.MobileUserControl
    {
        public TicketMes_Control() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public string Mname_Text//电影名称
        {
            get{ return Mname_lbl.Text; }
            set{ Mname_Text = value; }
        }
        public string Week_Text//星期
        {
            get { return Week_lbl.Text; }
            set { Week_Text = value; }
        }
        public string Dtime_Text//具体时间
        {
            get { return Dtime_lbl.Text; }
            set { Dtime_Text = value; }
        }
        public void Choice_ed(int num,string []mes,string mon)//选择座位后进行小票改动 num:选择位置的总个数 mes:选择的位置信息 mon:价格信息
        {
            SeatMes_Control[] seatMes = new SeatMes_Control[4] { seatMes_Control1,seatMes_Control2,seatMes_Control3,seatMes_Control4};
            for (int i=0; i < 4; i++)
            {
                if (i >= num)//多余的小票不显示
                {
                    seatMes[i].Visible = false;
                }
                else//显示选座信息
                {
                    seatMes[i].Money_Text = "¥"+mon;//显示价格
                    //读取座位信息
                    seatMes[i].Seat_Text = mes[2*i]+"排"+mes[2*i+1]+"座";
                }
            }
        }
    }
}