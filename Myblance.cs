using MySql.Data.MySqlClient;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SmobilerAppTEST7._17
{
    partial class Myblance : Smobiler.Core.Controls.MobileForm
    {
        string Uno;
        string number;
        int check=0;

        private DataSet Databaseconnect(string dabatase, string sql)//数据库连接调用函数
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=" + dabatase + ";uid=root;pwd=;";//连接数据库
            con.Open();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, con);//执行sql语句
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            con.Close();
            return dataSet;
        }
        public Myblance(string a) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Uno = a;
            showlabel(Uno);
        }

        public void showlabel(string a)
        {

            string txt2 = "select Ublance from Userinf where Uphoneno=" + a;
            string database = "Movie_ticket";
            DataSet name = Databaseconnect(database, txt2);
            label2.Text = name.Tables[0].Rows[0][0].ToString();

        }

        private void button1_Press(object sender, EventArgs e)
        {
            string money = textBox1.Text;
            if (!string.IsNullOrEmpty(money) && check== 1)
                Toast("请只选择一种充值方式");
            else
            {
                if (!string.IsNullOrEmpty(money) && check == 0)
                    number = textBox1.Text;
                string update = "Update Userinf set Ublance=Ublance+'" + number + "' where Uphoneno='" + Uno + "'";
                string database = "Movie_ticket";
                Databaseconnect(database, update);
                number = "0";
                showlabel(Uno);
            }
            
        }

        private void radioGroup1_ButtonPress(object sender, RadioButtonPressEventArgs e)
        {
            if (e.Button.Checked)
            {
                check = 1;
                switch (e.Button.ID)
                {
                    case "thirty":
                        {
                            number = "30";

                        }
                        break;
                    case "fifty":
                        {
                            number = "50";

                        }
                        break;
                    case "one":
                        {
                            number = "100";

                        }
                        break;
                    case "two":
                        {
                            number = "200";

                        }
                        break;
                    case "three":
                        {
                            number = "300";

                        }
                        break;
                    case "five":
                        {
                            number = "500";

                        }
                        break;

                }
            }
            else
                check = 0;
               
          
        }
        private void title_Control1_ExitButtonpPress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TouchLeave(object sender, EventArgs e)
        {
            try
            {
                textBox1.BorderColor = Color.WhiteSmoke;
                //确保账号输入的是数字
                textBox1.BorderColor = Color.WhiteSmoke;
                double.TryParse(textBox1.Text, out double a);
                if (a == 0 && textBox1.Text != "")
                {
                    textBox1.Text = "";
                    throw new Exception("请输入正确的数额");
                }
                else
                {
                    if (a < 0)
                        throw new Exception("请输入正数");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void textBox1_TouchEnter(object sender, EventArgs e)
        {
            textBox1.BorderColor = Color.Red;
        }
    }
}