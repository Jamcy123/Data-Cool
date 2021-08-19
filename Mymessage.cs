using MySql.Data.MySqlClient;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SmobilerAppTEST7._17
{
    partial class Mymessage : Smobiler.Core.Controls.MobileForm
    {
        string Uno;
        string pic;
        string nickname;
        public string Pic//头像属性
        {
            get { return pic; }
        }
        public string Nickname//昵称属性
        {
            get { return nickname; }
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
        public Mymessage(string a) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Uno = a;
            textBox1.Text = showlabel("Uphoneno", Uno);
            textBox2.Text = showlabel("Unickname", Uno);
            nickname = textBox2.Text;
            textBox3.Text = showlabel("Usex", Uno);
            textBox4.Text = showlabel("Ucity", Uno);
            datePicker1.BindDisplayValue = showlabel("Ubirth", Uno);
        }
        private void Mymessage_Load(object sender, EventArgs e)//界面载入函数
        {
            try
            {
                //载入头像信息
                string update = "Select Uphoto from Userinf where Uphoneno='" + Uno + "'";
                string database = "Movie_ticket";
                DataSet dataSet = Databaseconnect(database, update);
                if (dataSet.Tables[0].Rows.Count > 0)
                    image1.ResourceID = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
                pic = image1.ResourceID;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        public string showlabel(string b, string a)
        {
            string txt2 = "select " + b + " from Userinf where Uphoneno=" + a;
            string database = "Movie_ticket";
            DataSet name = Databaseconnect(database, txt2);
            return name.Tables[0].Rows[0][0].ToString();
        }

        private void button1_Press(object sender, EventArgs e)//保存按钮响应事件
        {
            try
            {
                string path_1 = ".\\Resources\\Image\\Cache\\" + Uno + ".png";//缓存路径
                string path_2 = ".\\Resources\\Image\\" + Uno + ".png";
                if (File.Exists(path_1))//用户选择了新的图片点击保存才上传
                {
                    if (File.Exists(path_2))//若存在自定义的图片，则先删除
                    {
                        File.Delete(path_2);
                    }
                    File.Move(path_1, path_2);//剪切到image中
                    //同步更改到数据库
                    string update = "Update Userinf set Uphoto='" + Uno + ".png' where Uphoneno=" + Uno;
                    string database = "Movie_ticket";
                    Databaseconnect(database, update);
                    pic = Uno + ".png";//传递更改回User界面
                }
                if (nickname != textBox2.Text)
                {
                    string update = "Update Userinf set Unickname='" + textBox2.Text + "' where Uphoneno=" + Uno;
                    string database = "Movie_ticket";
                    Databaseconnect(database, update);
                    nickname = textBox2.Text;
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

        private void datePicker1_ValueChanged(object sender, EventArgs e)//出生日期
        {
            string update = "Update Userinf set Ubirth='" + datePicker1.BindDisplayValue + "' where Uphoneno=" + Uno;
            string database = "Movie_ticket";
            Databaseconnect(database, update);
        }

        private void button2_Press(object sender, EventArgs e)//上传照片按钮响应事件
        {
            camera1.GetPhoto();
        }

        private void camera1_ImageCaptured(object sender, BinaryResultArgs e)//传照片
        {
            try
            {
                if (e.Data != null)//没选照片不显示
                {
                    string path = ".\\Resources\\Image\\Cache";
                    e.SaveFile(Uno + ".png", path); //第二个参数为路径
                    image1.ResourceID = ".\\Cache\\" + Uno + ".png";//展示预览图
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void Mymessage_Closed(object sender, EventArgs e)//窗口关闭事件
        {
            string path_1 = ".\\Resources\\Image\\Cache\\" + Uno + ".png";//缓存路径
            if (File.Exists(path_1))//若存在自定义的图片，则先删除
            {
                File.Delete(path_1);
            }
        }
    }
}