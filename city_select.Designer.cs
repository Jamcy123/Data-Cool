using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class city_select : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.picker1 = new Smobiler.Core.Controls.Picker();
            this.picker2 = new Smobiler.Core.Controls.Picker();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.lblAddress = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.gps1 = new Smobiler.Core.Controls.GPS();
            // 
            // picker1
            // 
            this.picker1.BackColor = System.Drawing.Color.White;
            this.picker1.FontSize = 14F;
            this.picker1.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6"};
            this.picker1.Location = new System.Drawing.Point(7, 127);
            this.picker1.Name = "picker1";
            this.picker1.Size = new System.Drawing.Size(144, 121);
            this.picker1.SelectedIndexChanged += new System.EventHandler(this.picker1_SelectedIndexChanged);
            // 
            // picker2
            // 
            this.picker2.BackColor = System.Drawing.Color.White;
            this.picker2.FontSize = 14F;
            this.picker2.Items = new string[] {
        "北京市",
        "天津市",
        "上海市",
        "重庆市"};
            this.picker2.Location = new System.Drawing.Point(151, 127);
            this.picker2.Name = "picker2";
            this.picker2.Size = new System.Drawing.Size(144, 121);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Border = new Smobiler.Core.Controls.Border(1F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(179, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 26);
            this.button1.Text = "采用此地址";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // lblAddress
            // 
            this.lblAddress.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblAddress.BorderColor = System.Drawing.Color.Silver;
            this.lblAddress.BorderRadius = 7;
            this.lblAddress.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblAddress.Location = new System.Drawing.Point(32, 40);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(97, 26);
            this.lblAddress.Text = "定位城市";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Bold = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(0, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 25);
            this.label2.Text = "手动选择";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Border = new Smobiler.Core.Controls.Border(1F);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(107, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 26);
            this.button2.Text = "采用此地址";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Location = new System.Drawing.Point(48, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 20);
            this.button3.Text = "重新定位";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Bold = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.Text = "定位城市";
            // 
            // gps1
            // 
            this.gps1.GPSSource = Smobiler.Core.Controls.GPSSource.Amap;
            this.gps1.Name = "gps1";
            this.gps1.RequestLocation = true;
            this.gps1.GotLocation += new Smobiler.Core.Controls.GpsCallBackHandler(this.gps1_GotLocation);
            // 
            // city_select
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.gps1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.picker1,
            this.picker2,
            this.button1,
            this.lblAddress,
            this.label2,
            this.button2,
            this.button3,
            this.label1});
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.city_select_Load);
            this.Name = "city_select";

        }
        #endregion

        private Smobiler.Core.Controls.Picker picker1;
        private Smobiler.Core.Controls.Picker picker2;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Label lblAddress;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.Button button3;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.GPS gps1;
    }
}