using MySql.Data.MySqlClient;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SmobilerAppTEST7._17
{
    partial class Myblance : Smobiler.Core.Controls.MobileForm
    {
        string Uno;
        string number;
        int check=0;
        public Myblance(string a) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Uno = a;
            showlabel(Uno);
        }

        public void showlabel(string a)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=movie_ticket;uid=root;pwd=;";
            con.Open();
            string txt2 = "select Ublance from Userinf where Uphoneno=" + a;
            MySqlDataAdapter nname = new MySqlDataAdapter(txt2, con);
            DataSet name = new DataSet();//缓存
            nname.Fill(name);//Fill(DataSet)	在 DataSet 中添加或刷新行。
            label2.Text = name.Tables[0].Rows[0][0].ToString();
            con.Close();
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
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=127.0.0.1;Database=movie_ticket;uid=root;pwd=;";
                con.Open();
                string update = "Update Userinf set Ublance=Ublance+'" + number + "' where Uphoneno='" + Uno + "'";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(update, con);
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);
                con.Close();
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
    }
}