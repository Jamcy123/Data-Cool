using MySql.Data.MySqlClient;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmobilerAppTEST7._17
{
    partial class Mymessage : Smobiler.Core.Controls.MobileForm
    {
        string Uno;
        string two;
        string four;
        string five;
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
            two = textBox2.Text;
            textBox3.Text = showlabel("Usex", Uno);
            textBox4.Text = showlabel("Ucity", Uno);
            four = textBox4.Text;
            datePicker1.BindDisplayValue = showlabel("Ubirth", Uno);
            //five = (string)datePicker1.BindDisplayValue;
        }

        public string showlabel(string b, string a)
        {
            string txt2 = "select " + b + " from Userinf where Uphoneno=" + a;
            string database = "Movie_ticket";
            DataSet name = Databaseconnect(database, txt2);
            return name.Tables[0].Rows[0][0].ToString();
        }

        private void button1_Press(object sender, EventArgs e)//保存按钮响应事件***建立缓存？？剪切文件？？删除文件？？
        {
            if (two != textBox2.Text)
            {
                string update = "Update Userinf set Unickname='" + textBox2.Text + "' where Uphoneno=" + Uno ;
                string database = "Movie_ticket";
                Databaseconnect(database, update);
            }
            if (four != textBox4.Text)
            {
                string update = "Update Userinf set Ucity='" + textBox4.Text + "' where Uphoneno=" + Uno;
                string database = "Movie_ticket";
                Databaseconnect(database, update);
            }
        }

        private void title_Control1_ExitButtonpPress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datePicker1_ValueChanged(object sender, EventArgs e)
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
            if (e != null)
            {

                e.SaveFile(Uno, MobileResourceManager.DefaultImagePath); //第二个参数为路径，图片保存在项目下\bin\Debug\Resources\Image下
                image1.ResourceID = Uno;
                string update = "Update Userinf set Uphoto='" + Uno + "' where Uphoneno=" + Uno;
                string database = "Movie_ticket";
                Databaseconnect(database, update);
            }
        }
    }
}