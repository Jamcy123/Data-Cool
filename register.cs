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
                throw new Exception("请输入11位的账号");
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
                            if (checkBox1.Checked == true && checkBox2.Checked == true)
                                Toast("请只选择一个性别！");
                            else if(checkBox1.Checked == false && checkBox2.Checked == false)
                                Toast("请选择性别！");
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
            
        }
    }
}