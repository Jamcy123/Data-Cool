using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace SmobilerAppTEST7._17
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ccTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        public ccTemplate() : base()
        {
            //This call is required by the SmobilerUserControl.
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

        private void ccTemplate_Load(object sender, EventArgs e)
        {
            string database = "movie_ticket";
            string select = "SELECT movie.* FROM movie_ticket.project,movie_ticket.movie where project.Cno like '001' and project.Mno = movie.Mno;";

            DataSet dataSet = Databaseconnect(database, select);

        }

        private void panel1_Press(object sender, EventArgs e)
        {
            //movie_information movie_Information = new movie_information();
            //this.Form.Show(movie_Information);
        }

        private void goupiao_button_Press(object sender, EventArgs e)
        {
            cinema_movie cinema_Movie = new cinema_movie();
            this.Form.Show(cinema_Movie);
        }
    }
}