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
        public user(string a) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            Uno = a;
            showlabel(a);
        }

        public void showlabel(string a)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=movie_ticket;uid=root;pwd=;";
            con.Open();
            string txt2 = "select Unickname from Userinf where Uphoneno=" + a;
            MySqlDataAdapter nname = new MySqlDataAdapter(txt2, con);
            DataSet name = new DataSet();//缓存
            nname.Fill(name);//Fill(DataSet)	在 DataSet 中添加或刷新行。
            label1.Text = name.Tables[0].Rows[0][0].ToString();
            con.Close();
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

        //private DataTable GetMenu(string ID)
        //{
        //    try
        //    {
        //        MySqlConnection con = new MySqlConnection();
        //        con.ConnectionString = "server=127.0.0.1;Database=movie_ticket;uid=root;pwd=;";
        //        con.Open();
        //        string select = "Select Upassword from Userinf where Uphoneno=" + ID;
        //        MySqlDataAdapter find = new MySqlDataAdapter(select, con);
        //        DataSet save = new DataSet();//缓存
        //        find.Fill(save);//Fill(DataSet)	在 DataSet 中添加或刷新行。
        //        con.Close();
        //        return save.Tables[0];
        //    }
        //    catch(Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
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
                    this.Show(mymessage);
                    break;

            }
        }


    }
}