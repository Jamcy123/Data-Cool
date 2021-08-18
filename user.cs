using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerAppTEST7._17
{
 
    partial class user : Smobiler.Core.Controls.MobileForm
    {
        string Uno;

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
        public user(string a) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Uno = a;
            showlabel(a);
        }

        public void showlabel(string a)
        {
            string txt2 = "select Unickname from Userinf where Uphoneno=" + a;
            string database = "Movie_ticket";
            DataSet name=Databaseconnect(database, txt2);
            label1.Text = name.Tables[0].Rows[0][0].ToString();
        }

        public void setToolbarIndex(int i)
        {
            toolBar1.SelectedIndex = i;//底部栏默认选项
        }
        public string ToolBarItemName { get; set; }//底部工具栏选项
        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)//底部栏单击事件
        {
            ToolBarItemName = e.Name;
            switch (e.Name)
            {
                case "user-icon":
                    break;
                default:
                    this.Close();
                    break;
            }
        }
        private void button1_Press(object sender, EventArgs e)
        {
            this.Form.Client.ReStart();
        }

        private void button2_Press(object sender, EventArgs e)
        {
            Alterpassword alterpassword = new Alterpassword();
            this.Show(alterpassword);
        }

        private void iconMenuView1_ItemPress(object sender, IconMenuViewItemPressEventArgs e)
        {
            switch(e.Item.ID)
            {
                case "order":
                    Myorder myorder = new Myorder(Uno);
                    this.Show(myorder);
                    break;
                case "blance":
                    Myblance myblance = new Myblance(Uno);
                    this.Show(myblance);
                    break;
                case "message":
                    Mymessage mymessage = new Mymessage(Uno);
                    this.Show(mymessage, (obj, args) => { label1.Text = mymessage.Nickname;image1.ResourceID = mymessage.Pic; });//传递修改
                    break;
            }
        }

        private void title_Control1_ExitButtonpPress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void user_Load(object sender, EventArgs e)
        {
            try
            {
                //载入头像信息
                string update = "Select Uphoto from Userinf where Uphoneno='" + Uno + "'";
                string database = "Movie_ticket";
                DataSet dataSet = Databaseconnect(database, update);
                if (dataSet.Tables[0].Rows.Count > 0)
                    image1.ResourceID = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}