using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Data;

namespace SmobilerAppTEST7._17
{
    partial class Seat_Form : Smobiler.Core.Controls.MobileForm
    {
        int num=0;//当前座位总数
        double money=1.2;//价格
        int[] mes = new int[8];//选择的座位数组
        Seat_Control[][] Controlss;
        string Uno="13549473975";//当前用户电话
        string Mno="001";//电影编号
        string Cno="001";//影院编号
        int Phall=1;//影厅号
        string Ptime = "2021-08-12 09:00:00";//放映时间
        private DataSet Databaseconnect(string dabatase, string sql)//数据库连接调用函数
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=" + dabatase + ";uid=root;pwd=;";//连接数据库
            con.Open();
            MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, con);//执行sql语句
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            con.Close();
            return dataSet;
        }
        public Seat_Form(string uno,string Mname,string mno,string Cname,string cno,int phall,string Week,string ptime,string price) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Uno = uno;
            Mno = mno;
            Cno = cno;
            Ptime = ptime;
            Phall = phall;
            Seat_Update(9, 9, 1);//生成座位表
            money = double.Parse(price);
            ticketMes_Control1.MesInput(Mname, Week, ptime);
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
                buyBtn_Control1.sure_panel_change(num, money);//更改确认按钮信息
                ticketMes_Control1.Choice_ed(num, mes, money);//选择座位后进行小票改动 num:选择位置的总个数 mes:选择的位置信息 mon:价格信息
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
            //throw new NotImplementedException();
        }

        private void Seat_Update(int x, int y,int which)//1：生成x列y行座位表 2：取消勾选座位
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
                        red_seat();
                    } break;                   
                case 2:
                    {//取消勾选座位
                        this.Controlss[y - 1][x - 1].Fon_Bool = false;
                        this.Controlss[y - 1][x - 1].Seat_Panel.BorderColor = Color.LightGray;
                        this.Controlss[y - 1][x - 1].Seat_Panel.BackColor = Color.White;
                    } break;
            }            
        }
        private void red_seat()//已被选座位变红不可选
        {
            string database = "Movie_ticket";
            string sql = "select Pposition from ticket where Cno='" + Cno + "' and Mno='" + Mno + "' and Phall='" + Phall + "' and Ptime='" + Ptime + "'";
            DataSet dataSet = Databaseconnect(database, sql);
            string wei = "";
            int pai;//几排
            int zuo;//几座
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                wei = dataSet.Tables[0].Rows[i].ItemArray[0].ToString();
                pai = int.Parse(wei.Substring(0, wei.IndexOf("排")));
                zuo = int.Parse(wei.Substring(wei.IndexOf("排") + 1, wei.IndexOf("座") - wei.IndexOf("排") - 1));
                this.Controlss[pai - 1][zuo - 1].Seat_Panel.BackColor = Color.FromArgb(200, Color.Red);
                this.Controlss[pai - 1][zuo - 1].Seat_Panel.BackColor = Color.FromArgb(200, Color.Red);
                this.Controlss[pai - 1][zuo - 1].Stop_Panel.Visible = true;//座位变红后变为不可选
            }
        }
        private void clear_seat()
        {
            int x, y;
            for (int i = 0; i < num; i++)
            {
                y = mes[2 * i];//y排x座
                x = mes[2 * i + 1];//Controls[y][x]
                Seat_Update(x, y, 2);//取消勾选座位
            }
            num = 0;
            buyBtn_Control1.sure_panel_change(num, money);//更改确认按钮信息
            ticketMes_Control1.Choice_ed(num, mes, money);//选择座位后进行小票改动 num:选择位置的总个数 mes:选择的位置信息 mon:价格信息
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
                        ticketMes_Control1.Choice_ed(num, mes, money);//选择座位后进行小票改动
                        buyBtn_Control1.sure_panel_change(num, money);//更改确认按钮信息
                    }
                }
                else
                {
                    num --;
                    MesChange(X + 1, Y + 1);//更新mes数组
                    ticketMes_Control1.Choice_ed(num, mes, money);//选择座位后进行小票改动
                    buyBtn_Control1.sure_panel_change(num, money);//更改确认按钮信息
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

        private void buyBtn_Control1_Sure_btn_press(object sender, EventArgs e)//购票按钮 先判断余额是否足够，判断有没有选，最后同步数据库
        {
            try
            {
                //先判断余额是否足够
                string database = "Movie_ticket";
                string sql = "select Ublance from userinf where Uphoneno='"+Uno+"'";
                DataSet dataSet=Databaseconnect(database, sql);
                double ublance=double.Parse(dataSet.Tables[0].Rows[0].ItemArray[0].ToString());
                if (money * num > ublance)
                { throw new Exception("余额不足"); }
                else
                {
                    //判断已选的位置是否被先选了 选了就刷新座位 没选就扣钱刷新座位
                    //string sql = "select Pposition from ticket where Cno='" + Cno + "' and Mno='"+Mno+ "' and Phall='"+Phall+"' and Ptime='"+Ptime+"'";
                    sql = "select * from ticket where Cno='" + Cno + "' and Mno='" + Mno + "' and Phall='" + Phall + "' and Ptime='" + Ptime + "' ";//*********
                    for (int i=0;i<num;i++)
                    {
                        if (i == 0)
                        {
                            sql = sql + "and (Pposition='" + mes[2 * i] + "排" + mes[2 * i + 1] + "座'";
                        }
                        else 
                        {
                            sql = sql + "or Pposition='" + mes[2 * i] + "排" + mes[2 * i + 1] + "座'";
                        }
                    }
                    sql = sql + " )";
                    dataSet = Databaseconnect(database, sql);
                    if (dataSet.Tables[0].Rows.Count>0)
                    {
                        //刷新位置
                        clear_seat();//清空已选座位
                        red_seat();//更新被选信息
                        throw new Exception("位置已被抢先，请重新选座");
                    }
                    else
                    {
                        //购买成功 扣钱 刷新位置 同步数据库 ;
                        sql = "update userinf set ublance = ublance -"+ money * num +" where uphoneno='"+Uno+"'";
                        Databaseconnect(database, sql);
                        for (int i = 0; i < num; i++)
                        {
                            sql = "insert into ticket(Cno,Mno,Phall,Ptime,Pposition,Uphoneno,Pprice) values ('" + Cno + "','" + Mno + "','" + Phall + "','" + Ptime + "','" + mes[2 * i] + "排" + mes[2 * i + 1] + "座','" + Uno + "','" + money + "')";
                            Databaseconnect(database, sql);
                        }
                        //更新销售数量
                        sql = "update Projection set Pamount = Pamount +" + num + " where Cno='"+Cno+"' and Mno= '"+Mno+"' and Phall = '"+ Phall+"' and Ptime = '"+Ptime+"'";
                        Databaseconnect(database, sql);
                        MessageBox.Show("请移步至 '我的订单' 查看详情", "购票成功", MessageBoxButtons.OK, (obj, args) =>
                        {
                            this.Close();
                        });
                    }
                }
            }
            catch (Exception ex)
            {               
                Toast(ex.Message);
            }
        }

        private void title_Control1_ExitButtonpPress(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}