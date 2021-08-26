using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class Movieincrease : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl1 = new Smobiler.Core.Controls.TabPageControl();
            this.searchBox_Control = new SmobilerAppTEST7._17.SearchBox_Control();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl2 = new Smobiler.Core.Controls.TabPageControl();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.Mdetail = new Smobiler.Core.Controls.TextBox();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.Mno = new Smobiler.Core.Controls.TextBox();
            this.Mname = new Smobiler.Core.Controls.TextBox();
            this.Mlanguage = new Smobiler.Core.Controls.TextBox();
            this.Mtype = new Smobiler.Core.Controls.TextBox();
            this.Mduration = new Smobiler.Core.Controls.TextBox();
            this.Mgrade = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.camera1 = new Smobiler.Core.Controls.Camera();
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageView1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(149, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // tabPageView1
            // 
            this.tabPageView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageControl1,
            this.tabPageControl2});
            this.tabPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(300, 574);
            this.tabPageView1.Titles = new string[] {
        "所有电影",
        "上架电影"};
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129))))), System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(140)))), ((int)(((byte)(255))))), 14F);
            // 
            // tabPageControl1
            // 
            this.tabPageControl1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.searchBox_Control,
            this.button2,
            this.listView1});
            this.tabPageControl1.Name = "tabPageControl1";
            // 
            // searchBox_Control
            // 
            this.searchBox_Control.BackColor = System.Drawing.Color.White;
            this.searchBox_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBox_Control.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.searchBox_Control.Location = new System.Drawing.Point(0, 13);
            this.searchBox_Control.Name = "searchBox_Control";
            this.searchBox_Control.Size = new System.Drawing.Size(300, 37);
            this.searchBox_Control.TextBox_Text = "";
            this.searchBox_Control.SearchButtonPress += new System.EventHandler(this.searchBox_Control1_SearchButtonPress);
            this.searchBox_Control.Load += new System.EventHandler(this.searchBox_Control1_Load);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FontSize = 16F;
            this.button2.Location = new System.Drawing.Point(107, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Text = "退出登录";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 73);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.RaiseRefresh = true;
            this.listView1.Size = new System.Drawing.Size(300, 490);
            this.listView1.TemplateControlName = "DControl";
            this.listView1.Refresh += new System.EventHandler(this.listView1_Refresh);
            // 
            // tabPageControl2
            // 
            this.tabPageControl2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel4,
            this.panel3});
            this.tabPageControl2.Name = "tabPageControl2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button3,
            this.label8,
            this.Mdetail});
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 349);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Bold = true;
            this.button3.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.FontSize = 18F;
            this.button3.Location = new System.Drawing.Point(85, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 35);
            this.button3.Text = "上架电影";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // label8
            // 
            this.label8.Bold = true;
            this.label8.BorderColor = System.Drawing.Color.DimGray;
            this.label8.FontSize = 16F;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(13, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 39);
            this.label8.Text = "电影简介：";
            // 
            // Mdetail
            // 
            this.Mdetail.Border = new Smobiler.Core.Controls.Border(1F);
            this.Mdetail.BorderColor = System.Drawing.Color.DimGray;
            this.Mdetail.Location = new System.Drawing.Point(27, 121);
            this.Mdetail.Multiline = true;
            this.Mdetail.Name = "Mdetail";
            this.Mdetail.Size = new System.Drawing.Size(251, 168);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.Mno,
            this.Mname,
            this.Mlanguage,
            this.Mtype,
            this.Mduration,
            this.Mgrade,
            this.button1});
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 243);
            // 
            // image1
            // 
            this.image1.BorderRadius = 7;
            this.image1.DisplayMember = "Mpicadress";
            this.image1.Location = new System.Drawing.Point(13, 7);
            this.image1.Name = "image1";
            this.image1.ResourceID = global::SmobilerAppTEST7._17.Properties.Settings.Default.Mpicadress;
            this.image1.Size = new System.Drawing.Size(100, 134);
            // 
            // Mno
            // 
            this.Mno.Border = new Smobiler.Core.Controls.Border(1F);
            this.Mno.BorderColor = System.Drawing.Color.DimGray;
            this.Mno.Location = new System.Drawing.Point(130, 7);
            this.Mno.Name = "Mno";
            this.Mno.Size = new System.Drawing.Size(140, 30);
            this.Mno.WaterMarkText = "电影编号";
            // 
            // Mname
            // 
            this.Mname.Border = new Smobiler.Core.Controls.Border(1F);
            this.Mname.BorderColor = System.Drawing.Color.DimGray;
            this.Mname.Location = new System.Drawing.Point(130, 45);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(140, 30);
            this.Mname.WaterMarkText = "电影名称";
            // 
            // Mlanguage
            // 
            this.Mlanguage.Border = new Smobiler.Core.Controls.Border(1F);
            this.Mlanguage.BorderColor = System.Drawing.Color.DimGray;
            this.Mlanguage.Location = new System.Drawing.Point(130, 83);
            this.Mlanguage.Name = "Mlanguage";
            this.Mlanguage.Size = new System.Drawing.Size(140, 30);
            this.Mlanguage.WaterMarkText = "电影语言";
            // 
            // Mtype
            // 
            this.Mtype.Border = new Smobiler.Core.Controls.Border(1F);
            this.Mtype.BorderColor = System.Drawing.Color.DimGray;
            this.Mtype.Location = new System.Drawing.Point(130, 121);
            this.Mtype.Name = "Mtype";
            this.Mtype.Size = new System.Drawing.Size(140, 30);
            this.Mtype.WaterMarkText = "电影类型";
            // 
            // Mduration
            // 
            this.Mduration.Border = new Smobiler.Core.Controls.Border(1F);
            this.Mduration.BorderColor = System.Drawing.Color.DimGray;
            this.Mduration.Location = new System.Drawing.Point(130, 159);
            this.Mduration.Name = "Mduration";
            this.Mduration.Size = new System.Drawing.Size(140, 30);
            this.Mduration.WaterMarkText = "电影时长";
            // 
            // Mgrade
            // 
            this.Mgrade.Border = new Smobiler.Core.Controls.Border(1F);
            this.Mgrade.BorderColor = System.Drawing.Color.DimGray;
            this.Mgrade.Location = new System.Drawing.Point(130, 197);
            this.Mgrade.Name = "Mgrade";
            this.Mgrade.Size = new System.Drawing.Size(140, 30);
            this.Mgrade.WaterMarkText = "电影评分";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FontSize = 16F;
            this.button1.Location = new System.Drawing.Point(13, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "上传照片";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // camera1
            // 
            this.camera1.Name = "camera1";
            this.camera1.QualityMode = Smobiler.Core.Controls.ImageQualityMode.Custom;
            this.camera1.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.camera1_ImageCaptured);
            // 
            // Movieincrease
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.camera1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Name = "Movieincrease";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl1;
        private SearchBox_Control searchBox_Control;
        private Smobiler.Core.Controls.TabPageControl tabPageControl2;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.Button button3;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.TextBox Mno;
        private Smobiler.Core.Controls.TextBox Mname;
        private Smobiler.Core.Controls.TextBox Mlanguage;
        private Smobiler.Core.Controls.TextBox Mtype;
        private Smobiler.Core.Controls.TextBox Mduration;
        private Smobiler.Core.Controls.TextBox Mgrade;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Camera camera1;
        private Smobiler.Core.Controls.TextBox Mdetail;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.ListView listView1;
    }
}