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
            string database = "Movie_ticket";
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                throw new Exception("请选择一种身份");
            }
            if (checkBox1.Checked==true)
            {
                try
                {
                    string userID = txtUserName.Text.Trim();
                    string PassWord = txtPassword.Text.Trim();
                    if (userID.Length != 11)
                    {
                        txtUserName.Text = "";
                        throw new Exception("请输入11位的账号");
                    }
                    if (string.IsNullOrEmpty(userID))
                        throw new Exception("请输入用户名");
                    if (string.IsNullOrEmpty(PassWord))
                        throw new Exception("请输入密码");
                    
                    if (checkRemb.Checked == true)
                    {
                        //记住密码
                        string update = "Update Userinf set Uip='" + this.Client.SessionID + "' where Uphoneno='" + txtUserName.Text + "'";                     
                        Databaseconnect(database, update);


                    }

                    string select1 = "Select Upassword from Userinf where Uphoneno=" + txtUserName.Text;
                    DataSet save = Databaseconnect(database, select1);


                    if (save.Tables[0].Rows.Count <= 0)
                    {
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        throw new Exception("用户不存在，请重新输入！");
                    }


                    string pwd = save.Tables[0].Rows[0][0].ToString();

                    if (pwd == txtPassword.Text)
                    {
                        string a = txtUserName.Text;
                        moive_select moive_Select = new moive_select(a);
                        this.Show(moive_Select);
                    }
                    else
                    {
                        throw new Exception("密码不正确，请重新输入！");
                    }

                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            }

            if(checkBox2.Checked==true)
            {
                try
                {
                    string userID = txtUserName.Text.Trim();
                    string PassWord = txtPassword.Text.Trim();
                    if (userID=="001")
                    {
                        string Select= "Select Apassword from Cinema where Aid=" + txtUserName.Text;
                        DataSet Save = Databaseconnect(database, Select);
                        if (Save.Tables[0].Rows.Count <= 0)
                        {
                            txtUserName.Text = "";
                            txtPassword.Text = "";
                            Toast("用户不存在，请重新输入！");
                        }


                        string pw = Save.Tables[0].Rows[0][0].ToString();

                        if (pw == txtPassword.Text)
                        {

                            string a = txtUserName.Text;
                            Movieincrease movieincrease = new Movieincrease(a);
                            this.Show(movieincrease);
                        }
                        else
                        {
                            Toast("密码不正确，请重新输入！");
                        }
                    }
            
            
                    if (userID.Length != 11)
                    {
                        txtUserName.Text = "";
                        throw new Exception("请输入11位的账号");
                    }
                    if (string.IsNullOrEmpty(userID))
                        throw new Exception("请输入用户名");
                    if (string.IsNullOrEmpty(PassWord))
                        throw new Exception("请输入密码");
                    if (checkRemb.Checked == true)
                    {
                        //记住密码
                        string update = "Update Userinf set Uip='" + this.Client.SessionID + "' where Uphoneno='" + txtUserName.Text + "'";
                        Databaseconnect(database, update);

                    }

                    string select = "Select Apassword from Cinema where Aid=" + txtUserName.Text;
                    DataSet save = Databaseconnect(database, select);


                    if (save.Tables[0].Rows.Count <= 0)
                    {
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        throw new Exception("用户不存在，请重新输入！");
                    }


                    string pwd = save.Tables[0].Rows[0][0].ToString();

                    if (pwd == txtPassword.Text)
                    {
                        
                        string a = txtUserName.Text;
                        Administrator administrator = new Administrator(a);
                        this.Show(administrator);
                    }
                    else
                    {
                        throw new Exception("密码不正确，请重新输入！");
                    }

                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            }
        }

        private void btnForget_Press(object sender, EventArgs e)
        {
            try
            {
                RemoveClientData("PWD", (object s, ClientDataResultHandlerArgs args) =>
                {
                    if (string.IsNullOrEmpty(args.error))
                    {
                        Toast("密码已成功清除" );
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void button1_Press(object sender, EventArgs e)
        {
            string a = txtUserName.Text;
            moive_select moive_Select = new moive_select(a);
            this.Show(moive_Select);
        }

        private void btnregister_Press(object sender, EventArgs e)
        {
            register register= new register();
            this.Show(register);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                checkBox2.Checked = true;
            else
                checkBox2.Checked = false;
        }

        private void txtUserName_TouchLeave(object sender, EventArgs e)
        {
            string select = "Select Uip,Upassword from Userinf where Uphoneno=" + txtUserName.Text;
            string database = "Movie_ticket";
            DataSet pass = Databaseconnect(database, select);
            if(pass.Tables[0].Rows.Count>0)
            {
                if (pass.Tables[0].Rows[0][0].ToString() == this.Client.SessionID)
                {
                    txtPassword.Text = pass.Tables[0].Rows[0][1].ToString();
                }
            }            
        }

        private void button3_Press(object sender, EventArgs e)//我直接选座位
        {
            this.Form.Show(new SeatChoice_Form());
        }
    }
}