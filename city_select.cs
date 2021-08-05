using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using MySql.Data.MySqlClient;

namespace SmobilerAppTEST7._17
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class city_select : Smobiler.Core.Controls.MobileUserControl
    {
        string Uno;//当前登录用户手机号
        private string address = "";//存储地址
        public city_select(string a) : base()
        {
            Uno = a;
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }        
        public string Address//设置地址属性
        {
            get { return address; }
        }
        private void city_select_Load(object sender, EventArgs e)//界面载入事件
        {
            gps1.GetGps();//获取当前位置信息
            //连接数据库，查出所有省份
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=address;uid=root;pwd=;";//连接address数据库
            con.Open();
            string select = "SELECT Distinct province FROM address.region;";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(select, con);
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            con.Close();
            //将表中数据导入选择框中
            int length = dataSet.Tables[0].Rows.Count;
            string[] s = new string[length];
            for (int i = 0; i < length; i++)
            {
                s[i] = dataSet.Tables[0].Rows[i].ItemArray[0].ToString();
            }
            picker1.Items = s;
        }
        private void picker1_SelectedIndexChanged(object sender, EventArgs e)//省份选择框的选项变化事件
        {
            //连接数据库，查出对应省份的城市
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=address;uid=root;pwd=;";//连接address数据库
            con.Open();
            string select = "SELECT city FROM address.region where province='" + picker1.SelectedItem + "'";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(select, con);
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            con.Close();
            //将表中数据导入选择框中
            int length = dataSet.Tables[0].Rows.Count;
            string[] s = new string[length];
            for (int i = 0; i < length; i++)
            {
                s[i] = dataSet.Tables[0].Rows[i].ItemArray[0].ToString();
            }
            picker2.Items = s;
            picker2.SelectedIndex = 0;//市级选择框默认选择第一个
        }

        private void button1_Press(object sender, EventArgs e)//采用定位的地址
        {
            address = lblAddress.Text;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=address;uid=root;pwd=;";//连接address数据库
            con.Open();
            string update = "update Movie_ticket.Userinf set Ucity='" + address + "'where Uphoneno='" + Uno + "'";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(update, con);
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            con.Close();
            this.Close();
        }

        private void button2_Press(object sender, EventArgs e)//采用手动选择的地址
        {            
            address = picker2.SelectedItem;
            //将用户的地址传回数据库中
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=Movie_ticket;uid=root;pwd=;";//连接Movie_ticket数据库
            con.Open();
            string update = "update Movie_ticket.Userinf set Ucity='"+address+"'where Uphoneno='"+Uno+"'";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(update, con);
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            this.Close();
        }

        private void button3_Press(object sender, EventArgs e)//重新定位
        {
            gps1.GetGps();//获取当前位置信息
            //将用户的地址传回数据库中
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=Movie_ticket;uid=root;pwd=;";//连接Movie_ticket数据库
            con.Open();
            string update = "update Movie_ticket.Userinf set Ucity='" + address + "'where Uphoneno='" + Uno + "'";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(update, con);
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
        }

        private string address_city(string location)//输入详细地址，返回城市
        {
            string city = "";
            if (location.Contains("省"))
                city = location.Substring(location.IndexOf("省") + 1, location.IndexOf("市") - location.IndexOf("省"));
            else
            {
                if (location.Contains("自治区"))
                    city = location.Substring(location.IndexOf("区") + 1, location.IndexOf("市") - location.IndexOf("区"));
                else
                    city = location.Substring(0, location.IndexOf("市") + 1);
            }
            return city;
        }
        private void gps1_GotLocation(object sender, GPSResultArgs e)//定位结果反馈
        {
            //是否获取到了位置信息
            if ((e.isError).Equals(false))
            {
                if (e.Longitude != 0 & e.Latitude != 0)
                {
                    //e.Location：详细地址
                    lblAddress.Text = address_city(e.Location);
                }
                else
                {
                    lblAddress.Text = "定位失败";
                }
            }
            else
            {
                lblAddress.Text = "定位失败";
            }
        }
    }
}