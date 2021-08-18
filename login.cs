using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Drawing;
using System.Data;
using MySql.Data.MySqlClient;

namespace SmobilerAppTEST7._17
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerForm1() : base()
        {
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
        private void btnLogon_Press(object sender, EventArgs e)
        {
            try
            {
                string database = "Movie_ticket";
                if (checkBox1.Checked)//用户登录
                {
                    string userID = txtUserName.Text.Trim();
                    string PassWord = txtPassword.Text.Trim();
                    if (userID.Length != 11)
                    {
                        txtUserName.Text = "";
                        throw new Exception("请输入11位的账号");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(userID))
                            throw new Exception("请输入用户名");
                        else
                        {
                            if (string.IsNullOrEmpty(PassWord))
                                throw new Exception("请输入密码");
                            else
                            {
                                //账号密码格式正确后
                                //判断用户是否存在，密码是否正确
                                string sql = "Select Upassword from Userinf where Uphoneno='" + txtUserName.Text + "'";
                                DataSet save = Databaseconnect(database, sql);

                                if (save.Tables[0].Rows.Count <= 0)
                                {
                                    txtUserName.Text = "";
                                    txtPassword.Text = "";
                                    throw new Exception("用户不存在，请重新输入！");
                                }
                                else
                                {
                                    //用户存在
                                    if (save.Tables[0].Rows[0][0].ToString() == txtPassword.Text)//密码正确
                                    {
                                        this.Client.Session.Clear();//登陆前清空之前的全局变量
                                        this.Client.Session.Add("Uphone", txtUserName.Text);//设置用户号码的全局变量
                                        //更新记住密码情况
                                        sql = "Update Userinf set Urempass=" + checkRemb.Checked.ToString() + " where Uphoneno='" + txtUserName.Text + "'";
                                        Databaseconnect(database, sql);

                                        //上次登录的设备号是否与此次相同,不同则更新数据，且保证用户唯一在线
                                        sql = "Select Uip from Userinf where Uphoneno='" + txtUserName.Text + "'";
                                        DataSet dataSet = Databaseconnect(database, sql);
                                        //123456表示注册后，首次登录
                                        if (this.Client.SessionID != dataSet.Tables[0].Rows[0][0].ToString()&& dataSet.Tables[0].Rows[0][0].ToString()!="123456")
                                        {
                                            //ClientVariables.GetCurrentClient(上一个设备的DeviceID).ReStart();//实现用户唯一在线
                                            ClientVariables.GetCurrentClient(dataSet.Tables[0].Rows[0][0].ToString()).ReStart();//唯一在线
                                            sql = "Update Userinf set Uip='" + this.Client.SessionID + "' where Uphoneno='" + txtUserName.Text + "'";
                                            Databaseconnect(database, sql);//更新设备号数据
                                            //Client.GetActiveForm().MessageBox.Show("该账号已在别处登录");
                                        }
                                        else
                                        {
                                            if (dataSet.Tables[0].Rows[0][0].ToString() == "123456")
                                            {
                                                sql = "Update Cinema set Cip='" + this.Client.SessionID + "' where Aid='" + txtUserName.Text + "'";
                                                Databaseconnect(database, sql);//更新设备号数据
                                            }
                                        }
                                        this.Show(new moive_select(txtUserName.Text));
                                    }
                                    else
                                    {
                                        throw new Exception("密码不正确，请重新输入！");
                                    }
                                }
                            }
                        }
                    }
                    if (checkRemb.Checked == true)
                    {
                        //记住密码
                        string update = "Update Userinf set Uip='" + this.Client.SessionID + "' where Uphoneno='" + txtUserName.Text + "'";
                        Databaseconnect(database, update);
                    }
                }
                else
                {
                    //管理员登录
                    if (checkBox2.Checked == true)
                    {
                        string userID = txtUserName.Text.Trim();
                        string PassWord = txtPassword.Text.Trim();
                        //数据库管理员
                        if (userID == "001")
                        {
                            if (txtPassword.Text == "123456")
                            {
                                string a = txtUserName.Text;
                                Movieincrease movieincrease = new Movieincrease();
                                this.Show(movieincrease);
                            }
                            else
                            {
                                throw new Exception("密码不正确，请重新输入！");
                            }
                        }
                        else
                        {
                            //影院管理员
                            if (userID.Length != 11)
                            {
                                txtUserName.Text = "";
                                throw new Exception("请输入11位的账号");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(userID))
                                    throw new Exception("请输入用户名");
                                else
                                {
                                    if (string.IsNullOrEmpty(PassWord))
                                        throw new Exception("请输入密码");
                                    else
                                    {
                                        //账号密码格式正确后
                                        //判断用户是否存在，密码是否正确
                                        string sql = "Select Apassword from Cinema where Aid='" + txtUserName.Text + "'";
                                        DataSet save = Databaseconnect(database, sql);

                                        if (save.Tables[0].Rows.Count <= 0)
                                        {
                                            txtUserName.Text = "";
                                            txtPassword.Text = "";
                                            throw new Exception("用户不存在，请重新输入！");
                                        }
                                        else
                                        {
                                            //用户存在
                                            if (save.Tables[0].Rows[0][0].ToString() == txtPassword.Text)//密码正确
                                            {
                                                this.Client.Session.Clear();//登陆前清空之前的全局变量
                                                this.Client.Session.Add("Cno", txtUserName.Text);//设置影院编号的全局变量
                                                //更新记住密码情况
                                                sql = "Update Cinema set Crempass=" + checkRemb.Checked.ToString() + " where Aid='" + txtUserName.Text + "'";
                                                Databaseconnect(database, sql);

                                                //上次登录的设备号是否与此次相同,不同则更新数据，且保证用户唯一在线
                                                sql = "Select Cip from Cinema where Aid='" + txtUserName.Text + "'";
                                                DataSet dataSet = Databaseconnect(database, sql);
                                                //123456表示注册后，首次登录
                                                if (this.Client.SessionID != dataSet.Tables[0].Rows[0][0].ToString() && dataSet.Tables[0].Rows[0][0].ToString() != "123456")
                                                {
                                                    //ClientVariables.GetCurrentClient(上一个设备的DeviceID).ReStart();实现用户唯一在线
                                                    ClientVariables.GetCurrentClient(dataSet.Tables[0].Rows[0][0].ToString()).ReStart();//唯一在线
                                                    sql = "Update Cinema set Cip='" + this.Client.SessionID + "' where Aid='" + txtUserName.Text + "'";
                                                    Databaseconnect(database, sql);//更新设备号数据
                                                }
                                                else
                                                {
                                                    if (dataSet.Tables[0].Rows[0][0].ToString() == "123456")
                                                    {
                                                        sql = "Update Cinema set Cip='" + this.Client.SessionID + "' where Aid='" + txtUserName.Text + "'";
                                                        Databaseconnect(database, sql);//更新设备号数据
                                                    }
                                                }
                                                this.Show(new Administrator(txtUserName.Text));
                                            }
                                            else
                                            {
                                                throw new Exception("密码不正确，请重新输入！");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnForget_Press(object sender, EventArgs e)//清除密码
        {
            txtPassword.Text = "";
        }

        private void btnregister_Press(object sender, EventArgs e)
        {
            register register = new register();
            this.Show(register);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                checkBox2.Checked = false;
            else
                checkBox2.Checked = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                checkBox1.Checked = false;
            else
                checkBox1.Checked = true;
        }

        private void txtUserName_TouchLeave(object sender, EventArgs e)//用户名textbox触碰离开事件
        {
            try
            {
                //确保账号输入的是数字
                txtUserName.BorderColor = Color.WhiteSmoke;
                long.TryParse(txtUserName.Text, out long a);
                if (a == 0 && txtUserName.Text != "")
                {
                    txtUserName.Text = "";
                    throw new Exception("请输入正确的账号格式");
                }
                //查询数据库,是否在本设备选择了记住密码
                string select = "Select Uip,Upassword,Urempass from Userinf where Uphoneno='" + txtUserName.Text + "'";
                string database = "Movie_ticket";
                DataSet pass = Databaseconnect(database, select);
                if (pass.Tables[0].Rows.Count > 0)//账户存在
                {
                    if (pass.Tables[0].Rows[0][0].ToString() == this.Client.SessionID)//与上次登录的设备号相同
                    {
                        if ((bool)pass.Tables[0].Rows[0][2])//是否选择了记住密码
                        {
                            txtPassword.Text = pass.Tables[0].Rows[0][1].ToString();//自动输入密码
                            checkRemb.Checked = true;//自动勾选记住密码
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void txtUserName_TouchEnter(object sender, EventArgs e)//用户名textbox触碰事件
        {
            txtUserName.BorderColor = Color.Red;
        }

        private void txtPassword_TouchEnter(object sender, EventArgs e)//密码textbox触碰事件
        {
            txtPassword.BorderColor = Color.Red;
        }

        private void txtPassword_TouchLeave(object sender, EventArgs e)//密码textbox触碰离开事件
        {
            txtPassword.BorderColor = Color.WhiteSmoke;
        }

        private void button3_Press(object sender, EventArgs e)//我直接选座位
        {
            Toast("不给选");
            //this.Form.Show(new Seat_Form("13549473975", "是部电影", "001", "又是个影院", "001", 1, "周四", "2021-08-12 09:00:00", "1.2"));
        }

        private void button1_Press_1(object sender, EventArgs e)//任意门
        {
            //this.Form.Show(new Myblance("13549473975"));
            //this.Form.Show(new Mymessage("13549473975"));
            //this.Form.Show(new Myorder("13549473975"));
            //this.Form.Show(new Alterpassword());
            this.Form.Show(new Myblance("13549473975"));
        }
    }
}