using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Drawing;

namespace SmobilerAppTEST7._17
{
    partial class Seat_Form : Smobiler.Core.Controls.MobileForm
    {
        int num=0;//当前座位总数
        double mon=1.2;//价格
        int[] mes = new int[8];//选择的座位数组
        Seat_Control[][] Controlss;
        
        public Seat_Form(string Mname,string Cname,string Week,string Dtime,string price) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Seat_Update(9, 9, 1);
            mon = double.Parse(price);
            ticketMes_Control1.MesInput(Mname, Week, Dtime);
            title_Control1.Text = Cname;
        }

        private void Seat_Form_Load(object sender, EventArgs e)//载入事件
        {
            ticketMes_Control1.Delete_Btn_Press += TicketMes_Control1_Delete_Btn_Press;//单击事件

        }

        private void TicketMes_Control1_Delete_Btn_Press(object sender, EventArgs e)//小票删除按钮
        {
            try
            {
                ImageButton del_btn = (ImageButton)sender;
                num--;
                int y = mes[2 * (int.Parse(del_btn.TextMember) - 1)];//y排x座
                int x = mes[2 * (int.Parse(del_btn.TextMember) - 1) + 1];//Controls[y][x]
                MesChange(x, y);//更新mes数组
                Seat_Update(x, y, 2);//取消勾选座位
                buyBtn_Control1.sure_panel_change(num, mon);//更改确认按钮信息
                ticketMes_Control1.Choice_ed(num, mes, mon);//选择座位后进行小票改动 num:选择位置的总个数 mes:选择的位置信息 mon:价格信息
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
            //throw new NotImplementedException();
        }
        private void Seat_Update(int x, int y,int which)//生成x列y行座位表 ******补充已选座位信息******
        {
            switch (which)
            {
                case 1:
                    {
                        this.Controlss = new Seat_Control[x][];
                        int i, j;
                        for (i = 0; i < x; i++)
                        {
                            Controlss[i] = new Seat_Control[y];
                            for (j = 0; j < y; j++)
                            {
                                Controlss[i][j] = new Seat_Control();
                                Controlss[i][j].Location = new Point(j * 30 + 15, i * 30 + 15);//i排j座位
                                panel1.Controls.Add(Controlss[i][j]);
                                Controlss[i][j].Seat_Ctrl_Press += Seat_Form_Seat_Ctrl_Press;//每个座位绑定相同的单击事件
                            }
                        }
                        //调用数据库中的数据，选过座位的位置设置为红色不可选
                        for (int a = 0; a < x; a++)
                        {
                            Controlss[3][a].Seat_Panel.BackColor = Color.FromArgb(200, Color.Red);
                            Controlss[3][a].Seat_Panel.BackColor = Color.FromArgb(200, Color.Red);
                            Controlss[3][a].Stop_Panel.Visible = true;//座位变红后变为不可选
                        }
                    } break;                   
                case 2:
                    {
                        this.Controlss[y - 1][x - 1].Fon_Bool = false;
                        this.Controlss[y - 1][x - 1].Seat_Panel.BorderColor = Color.LightGray;
                        this.Controlss[y - 1][x - 1].Seat_Panel.BackColor = Color.White;
                    } break;
            }
            

        }

        private void Seat_Form_Seat_Ctrl_Press(object sender, EventArgs e)//座位单击事件
        {
            try
            {
                Seat_Control control = (Seat_Control)sender;//获取用户单击的座位控件
                int X = (control.Location.X - 15) / 30;
                int Y = (control.Location.Y - 15) / 30;//Controls[X][Y]
                //判断加减座位               
                if (control.Seat_Panel.BackColor == Color.White)
                {
                    num ++;
                    if (num > 4)//加选座判断
                    {
                        control.PressBool = false;
                        num --;
                        throw new Exception("最多选择四个座位");
                    }
                    else
                    {
                        control.PressBool = true;
                        //数组之间不存在空隙
                        mes[2 * (num - 1)] = Y + 1;//(Y+1)排(X+1)座
                        mes[2 * (num - 1) + 1] = X + 1;
                        ticketMes_Control1.Choice_ed(num, mes, mon);//选择座位后进行小票改动
                        buyBtn_Control1.sure_panel_change(num, mon);//更改确认按钮信息
                    }
                }
                else
                {
                    num --;
                    MesChange(X + 1, Y + 1);//更新mes数组
                    ticketMes_Control1.Choice_ed(num, mes, mon);//选择座位后进行小票改动
                    buyBtn_Control1.sure_panel_change(num, mon);//更改确认按钮信息
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
            //throw new NotImplementedException();
        }
        private void MesChange(int x,int y)//删除mes数组元素 MesChange(X+1,Y+1)
        {
            if (num != 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (mes[2 * i] == y && mes[2 * i + 1] == x)//找到对应位置在数组的位置
                    {
                        i++;
                        for (;i<4; i++)//数组后面的数据往前推
                        {
                            mes[2 * (i - 1)] = mes[2 * i];
                            mes[2 * (i - 1) + 1] = mes[2 * i + 1];
                        }
                        break;
                    }
                }
            }
        }
    }
}