﻿using MySql.Data.MySqlClient;
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
            textBox5.Text = showlabel("Ubirth", Uno);
            five = textBox5.Text;

        }

        public string showlabel(string b, string a)
        {
            string txt2 = "select " + b + " from Userinf where Uphoneno=" + a;
            string database = "Movie_ticket";
            DataSet name = Databaseconnect(database, txt2);
            return name.Tables[0].Rows[0][0].ToString();

        }

        private void button1_Press(object sender, EventArgs e)
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
            if (five != textBox5.Text)
            {
                string update = "Update Userinf set Ubirth='" + textBox5.Text + "' where Uphoneno=" + Uno;
                string database = "Movie_ticket";
                Databaseconnect(database, update);
            }
        }

    }
}