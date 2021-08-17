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
    partial class Alterpassword : Smobiler.Core.Controls.MobileForm
    {
        string Uno;//用户号码
        public Alterpassword() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Uno = "13549473975";
            //Uno = this.Client.Session[0].ToString();****************************************************************
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
            try
            {
                if (txtUserphone.Text != Uno)//判断账号是否一致
                {
                    txtUserphone.Text = "";
                    txtPassword.Text = "";
                    txtnewpassword.Text = "";
                    txtsure.Text = "";
                    throw new Exception("输入的账号与本账号不一致");
                }
                else
                {
                    string select = "Select Upassword from Userinf where Uphoneno=" + txtUserphone.Text;
                    string database = "Movie_ticket";
                    DataSet save = Databaseconnect(database, select);

                    string pwd = save.Tables[0].Rows[0][0].ToString();

                    if (pwd == txtPassword.Text)//判断是否为本账号密码
                    {
                        if (txtnewpassword.Text.Length >= 6)//判断新密码是否大于等于6位
                        {
                            if (txtsure.Text == txtnewpassword.Text)//判断确认密码与密码是否相同
                            {
                                if (txtPassword.Text != txtnewpassword.Text)//判断新密码与旧密码是否相同
                                {
                                    string update = "Update Userinf set Upassword='" + txtnewpassword.Text + "' where Uphoneno='" + txtUserphone.Text + "'";
                                    Databaseconnect(database, update);
                                    string sure = "Select Upassword from Userinf where Uphoneno=" + txtUserphone.Text;
                                    DataSet ta = Databaseconnect(database, sure);
                                    if (ta.Tables[0].Rows.Count <= 0)//查询判断是否成功插入
                                        throw new Exception("修改失败！");
                                    else
                                    {
                                        Toast("修改成功！");
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    txtnewpassword.Text = "";
                                    txtsure.Text = "";
                                    throw new Exception("新密码与旧密码重复，请重新输入");
                                }
                            }
                            else
                            {
                                throw new Exception("密码与确认密码不同");
                            }                           
                        }
                        else
                        {
                            throw new Exception("请至少输入6位密码");
                        }
                    }
                    else
                    {
                        throw new Exception("密码不正确，请重新输入！");
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void txtUserphone_TouchEnter(object sender, EventArgs e)
        {
            txtUserphone.BorderColor = Color.Red;
            label1.Bold = true;
        }

        private void txtUserphone_TouchLeave(object sender, EventArgs e)
        {
            try
            {
                label1.Bold = false;
                txtUserphone.BorderColor = Color.WhiteSmoke;
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
            txtPassword.BorderColor = Color.Red;
            label2.Bold = true;
        }

        private void txtPassword_TouchLeave(object sender, EventArgs e)
        {
            txtPassword.BorderColor = Color.WhiteSmoke;
            label2.Bold = false;
        }

        private void txtnewpassword_TouchEnter(object sender, EventArgs e)
        {
            txtnewpassword.BorderColor = Color.Red;
            label4.Bold = true;
        }

        private void txtnewpassword_TouchLeave(object sender, EventArgs e)
        {
            txtnewpassword.BorderColor = Color.WhiteSmoke;
            label4.Bold = false;
        }

        private void txtsure_TouchEnter(object sender, EventArgs e)
        {
            txtsure.BorderColor = Color.Red;
            label3.Bold = true;
        }

        private void txtsure_TouchLeave(object sender, EventArgs e)
        {
            txtsure.BorderColor = Color.WhiteSmoke;
            label3.Bold = false;
        }
    }
}