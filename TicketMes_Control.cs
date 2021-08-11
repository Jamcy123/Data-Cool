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
        public void MesInput(string Mname,string Week,string Dtime)//填入电影与时间信息
        {
            Mname_lbl.Text = Mname;
            Week_lbl.Text = Week;
            Dtime_lbl.Text = Dtime;
        }
        public void Choice_ed(int num,string []mes,string mon)//选择座位后进行小票改动 num:选择位置的总个数 mes:选择的位置信息 mon:价格信息
        {
            try
            {
                Panel[] tikMes = new Panel[4] { tikMes_Pan1, tikMes_Pan2, tikMes_Pan3, tikMes_Pan4 };
                Label[] seatText = new Label[4] { seat_Text1, seat_Text2, seat_Text3, seat_Text4 };
                Label[] moneyText = new Label[4] { money_Text1, money_Text2, money_Text3, money_Text4 };
                for (int i = 0; i < 4; i++)
                {
                    if (i >= num)//多余的小票不显示
                    {
                        tikMes[i].Visible = false;
                    }
                    else//显示选座信息
                    {
                        moneyText[i].Text = "¥" + mon;//显示价格                                                          
                        seatText[i].Text = mes[2 * i] + "排" + mes[2 * i + 1] + "座";//读取座位信息
                    }
                }
            }
            catch (Exception ex)
            { Toast(ex.Message); }
        }
    }
}