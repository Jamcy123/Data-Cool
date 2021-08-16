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
    partial class register : Smobiler.Core.Controls.MobileForm
    {

        public register() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

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

        private void button1_Press(object sender, EventArgs e)
        {
            string userID = txtUserphone.Text.Trim();
            if (userID.Length != 11)
            {
                txtUserphone.Text = "";
                Toast("请输入11位的账号");
            }
            else
            {
                string sex=null, password;
                password = txtPassword.Text.Trim();
                string judge = "Select Upassword from Userinf where Uphoneno=" + txtUserphone.Text;
                string database = "Movie_ticket";
                DataSet da = Databaseconnect(database, judge);

                if (da.Tables[0].Rows.Count > 0)
                {
                    Toast("该电话号码已注册");
                    this.Close();
                }
                else
                {
                    if (password.Length < 6)
                    {
                        txtPassword.Text = "";
                        txtsure.Text = "";
                        Toast("请至少输入6位密码");
                    }
                    else
                    {
                        if (txtPassword.Text != txtsure.Text)
                        {
                            txtsure.Text = "";
                            Toast("密码错误，请重新输入");
                        }
                        else
                        {
                            if (checkBox1.Checked == true)
                                sex = "男";
                            else if (checkBox2.Checked == true)
                                sex = "女";
                            string insert = "Insert into Userinf (Uphoneno,Upassword,Ublance,Usex) values(\"" + txtUserphone.Text + "\",\"" + txtPassword.Text + "\",\"" + "0" + "\",\"" + sex + "\")";
                            Databaseconnect(database, insert);
                            string select = "Select Upassword from Userinf where Uphoneno=" + txtUserphone.Text;
                            DataSet save = Databaseconnect(database, select);
                            if (save.Tables[0].Rows.Count <= 0)
                                Toast("注册失败！");
                            else
                            {
                                Toast("注册成功！");
                                this.Close();
                            }
                        }            
                    }
                }            
            }           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
                checkBox2.Checked = true;
            else
                checkBox2.Checked = false;
        }

        private void txtUserphone_TouchEnter(object sender, EventArgs e)
        {
            label1.Bold = true;
            txtUserphone.BorderColor = Color.Red;
        }

        private void txtUserphone_TouchLeave(object sender, EventArgs e)
        {
            try
            {
                txtUserphone.BorderColor = Color.WhiteSmoke;
                label1.Bold = false;
                //确保账号输入的是数字
                long.TryParse(txtUserphone.Text, out long a);
                if (a == 0 && txtUserphone.Text != "")
                {
                    txtUserphone.Text = "";
                    throw new Exception("请输入正确的账号格式");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);             
            }
        }

        private void txtPassword_TouchEnter(object sender, EventArgs e)
        {
            label2.Bold = true;
            txtPassword.BorderColor = Color.Red;
        }

        private void txtPassword_TouchLeave(object sender, EventArgs e)
        {
            label2.Bold = false;
            txtPassword.BorderColor = Color.WhiteSmoke;
        }

        private void txtsure_TouchEnter(object sender, EventArgs e)
        {
            label3.Bold = true;
            txtsure.BorderColor = Color.Red;
        }

        private void txtsure_TouchLeave(object sender, EventArgs e)
        {
            label3.Bold = false;
            txtsure.BorderColor = Color.WhiteSmoke;
        }
    }
}