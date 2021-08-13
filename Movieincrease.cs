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
    
    partial class Movieincrease : Smobiler.Core.Controls.MobileForm
    {
        string name;
        public Movieincrease() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            showmovie();
        }

        private DataSet Databaseconnect(string dabatase, string sql)//数据库连接调用函数
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=" + dabatase + ";uid=root;pwd=;";//连接数据库
            con.Open();
            MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, con);//执行sql语句
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            con.Close();
            return dataSet;
        }

        public void showmovie()
        {
            string database = "Movie_ticket";
            string sql1 ="select * from Movie_ticket.Movie ";
            DataSet dataSet1 = Databaseconnect(database, sql1);          
            listView1.DataSource = dataSet1;
            listView1.DataBind();

        }
        private void listView1_Refresh(object sender, EventArgs e)
        {
            showmovie();
        }


        private void searchBox_Control1_SearchButtonPress(object sender, EventArgs e)
        {
            try
            {
                string database = "Movie_ticket";
                string sql = "";
                DataSet dataSet = new DataSet();
                string BoxText = searchBox_Control.TextBox_Text.Replace("'", "''");//使数据库能正确识别字符串
                sql =
                         "select * from Movie_ticket.Movie " +
                         "where Mname like '%" + BoxText + "%'";
                dataSet = Databaseconnect(database, sql);
                if (dataSet.Tables[0].Rows.Count <= 0)
                {

                    listView1.DataSource = dataSet;
                    listView1.DataBind();
                    sql = "alter table Movie_ticket.Movie drop column Cno";
                    Databaseconnect(database, sql);
                    throw new Exception("此处暂无符合要求的电影");
                }
                else
                {
                    listView1.DataSource = dataSet;
                    listView1.DataBind();

                }


            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        
    }

        private void searchBox_Control1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Press(object sender, EventArgs e)
        {
            string database = "Movie_ticket";
            string insert = "insert into Movie values ('" + Mno.Text + "','" + Mname.Text + "','" + Mlanguage.Text + "','" + Mtype.Text + "','" + name + "','" + Mduration.Text + "','" + Mdetail.Text + "','" + Mgrade.Text + "')";
            Databaseconnect(database, insert);
            string select = "select* from Movie where Mno='" + Mno.Text + "'";
            DataSet dataSet = Databaseconnect(database, select);
            if(dataSet.Tables[0].Rows.Count <= 0)
            {
                Toast("添加电影失败！请重新添加");

            }
            else
            {
                Toast("添加电影成功！");
                Mno.Text = "";
                Mname.Text = "";
                Mlanguage.Text = "";
                Mtype.Text = "";
                image1.ResourceID = "";
                Mduration.Text = "";
                Mdetail.Text = "";
                Mgrade.Text = "";
            }
        }

        private void button1_Press(object sender, EventArgs e)
        {
            camera1.GetPhoto();
        }

        private void camera1_ImageCaptured(object sender, BinaryResultArgs e)
        {
            name = DateTime.UtcNow.ToString().Replace("/", "").Replace(":","");
            e.SaveFile(name, MobileResourceManager.DefaultImagePath); //第二个参数为路径，图片保存在项目下\bin\Debug\Resources\Image下
            image1.ResourceID = name;

        }
    }
}