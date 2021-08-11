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
        public Seat_Form() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void Seat_Form_Load(object sender, EventArgs e)//载入事件
        {
            ticketMes_Control1.MesInput("是什么电影", "周三", "月月日日 00：00");
            Seat_Create(9, 9);
        }

        private void Seat_Create(int x, int y)//生成x列y行座位表 ******补充已选座位信息******
        {
            Seat_Control[][] control2 = new Seat_Control[x][];
            int i, j;
            for (i = 0; i < x; i++)
            {
                control2[i] = new Seat_Control[y];
                for (j = 0; j < y; j++)
                {
                    control2[i][j] = new Seat_Control();
                    control2[i][j].Location = new Point(i * 30 + 15, j * 30 + 15);//using System.Drawing;
                    panel1.Controls.Add(control2[i][j]);
                }
            }
            //调用数据库中的数据，选过座位的位置设置为红色不可选
            for (int a = 0; a < x; a++)
            {
                control2[a][3].Seat_Panel.BackColor = Color.FromArgb(200, Color.Red);
                control2[a][3].Seat_Panel.BackColor = Color.FromArgb(200, Color.Red);
                control2[a][3].Stop_Panel.Visible = true;//座位变红后变为不可选
            }
        }
    }
}