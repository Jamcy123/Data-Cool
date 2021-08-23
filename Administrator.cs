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
    partial class Administrator : Smobiler.Core.Controls.MobileForm
    {
        string Aid;//当前登录管理员id
        string Cno;
        public Administrator(string a) : base()
        {
            Aid = a;
            //This call is required by the SmobilerForm.
            InitializeComponent();
            showlabel(a);
            showmovie();
            
        }

        public void showmovie()
        {
            string database = "Movie_ticket";
            string sql1 =
                "select * from Movie_ticket.Movie " +
                "where exists( select * from Pmessage where Movie.Mno=Pmessage.Mno and Pmessage.Cno='" + Cno + "');";
            string sql2 =
                "select * from Movie_ticket.Movie" +
                " where not exists( select * from Pmessage where Movie.Mno=Pmessage.Mno and Pmessage.Cno = '" + Cno + "');";
                
            DataSet dataSet1 = Databaseconnect(database, sql1);
            DataSet dataSet2 = Databaseconnect(database, sql2);
            listView1.DataSource = dataSet1;
            listView1.DataBind();
            listView2.DataSource = dataSet2;
            listView2.DataBind();
        }
        public void showlabel(string a)
        {
            string txt2 = "select Cname,Cno from Cinema where Aid=" + a;
            string database = "Movie_ticket";
            DataSet name = Databaseconnect(database, txt2);
            Cno = name.Tables[0].Rows[0][1].ToString();
            label1.Text = name.Tables[0].Rows[0][0].ToString();

        }
        private void title_Control1_ExitButtonpPress_1(object sender, EventArgs e)//单击左上箭头
        {
            this.Close();
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
        private void searchBox_Control1_SearchButtonPress(object sender, EventArgs e)
        {
            try
            {
                string database = "Movie_ticket";
                string sql = "";
                DataSet dataSet = new DataSet();
                string BoxText = searchBox_Control.TextBox_Text.Replace("'", "''");//使数据库能正确识别字符串
                switch (tabPageView1.PageIndex)
                {
                    case 0://正在热映
                        sql = 
                        "select * from Movie_ticket.Movie " +
                        "where exists( select * from Projection where Movie.Mno=Projection.Mno and Projection.Cno='" + Cno + "') and  Mname like '%" + BoxText + "%'"; 
                        dataSet = Databaseconnect(database, sql);
                        if (dataSet.Tables[0].Rows.Count <= 0)
                        {
                            
                            listView1.DataSource = dataSet;
                            listView1.DataBind();                     
                            throw new Exception("此处暂无符合要求的电影");
                        }
                        else
                        {
                            listView1.DataSource = dataSet;
                            listView1.DataBind();
                            
                        }
                        
                        break;

                    case 1://可上映
                        sql = 
                        "select * from Movie_ticket.Movie" +
                        " where not exists( select * from Projection where Movie.Mno=Projection.Mno and Projection.Cno = '" + Cno + "') and Mname like '%" + BoxText + "%'";  
                        dataSet = Databaseconnect(database, sql);

                        if (dataSet.Tables[0].Rows.Count <= 0)
                        {
                            listView2.DataSource = dataSet;
                            listView2.DataBind();
                            throw new Exception("此处暂无符合要求的电影");
                        }
                        else
                        {
                            listView2.DataSource = dataSet;
                            listView2.DataBind();                    
                        }
                       
                        break;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        private void listView1_Refresh(object sender, EventArgs e)
        {
            showmovie();
        }

        private void listView2_Refresh(object sender, EventArgs e)
        {
            showmovie();
        }

        private void ShowForm(string name)//界面选择
        {
           
            switch (name)
            {
                case "film":
                    toolBar1.SelectedIndex = 0;
                    break;
                case "sale":
                    Sale sale = new Sale(Cno);
                    sale.setToolbarIndex(1);
                    Show(sale, (obj, args) => { ShowForm(sale.ToolBarItemName); });
                    break;
                case "cinema":
                    Cinema cinema=new Cinema(Cno,Aid);
                    cinema.setToolbarIndex(2);
                    Show(cinema, (obj, args) => { ShowForm(cinema.ToolBarItemName); });
                    break;
            }
        }

        public string ToolBarItemName { get; set; }//底部工具栏选项
        public void setToolbarIndex(int i)
        {
            toolBar1.SelectedIndex = i;//底部栏默认选项
        }

        private void toolBar1_ToolbarItemClick_1(object sender, ToolbarClickEventArgs e)
        {
            ShowForm(e.Name);//e:单击的图标
        }

        private void searchBox_Control1_Load(object sender, EventArgs e)
        {

        }

        

        private void listView1_RowBind(object sender, ListViewTemplateBindEventArgs e)
        {
            ((Label)e.Row.Control.Controls.Find("getCno")).Text = Cno;
        }

        private void listView2_RowBind(object sender, ListViewTemplateBindEventArgs e)
        {
            ((Label)e.Row.Control.Controls.Find("getCno")).Text = Cno;     
        }

    }
}