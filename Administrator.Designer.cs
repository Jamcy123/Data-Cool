using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class Administrator : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.ToolBarItem toolBarItem13 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem14 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem15 = new Smobiler.Core.Controls.ToolBarItem();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.searchBox_Control1 = new SmobilerAppTEST7._17.SearchBox_Control();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl2 = new Smobiler.Core.Controls.TabPageControl();
            this.listView2 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl1 = new Smobiler.Core.Controls.TabPageControl();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.label1,
            this.searchBox_Control1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(149, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageView1});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 100);
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FontSize = 15F;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 43);
            this.label1.Text = "label1";
            // 
            // searchBox_Control1
            // 
            this.searchBox_Control1.BackColor = System.Drawing.Color.White;
            this.searchBox_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBox_Control1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.searchBox_Control1.Location = new System.Drawing.Point(0, 29);
            this.searchBox_Control1.Name = "searchBox_Control1";
            this.searchBox_Control1.Size = new System.Drawing.Size(300, 46);
            this.searchBox_Control1.TextBox_Text = "";
            this.searchBox_Control1.SearchButtonPress += new System.EventHandler(this.searchBox_Control1_SearchButtonPress);
            this.searchBox_Control1.Load += new System.EventHandler(this.searchBox_Control1_Load);
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            this.toolBar1.BorderColor = System.Drawing.Color.White;
            toolBarItem13.IconID = "film";
            toolBarItem13.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem13.Name = "film";
            toolBarItem13.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem13.SelectIconID = "film";
            toolBarItem13.Text = "电影管理";
            toolBarItem14.IconID = "calculator";
            toolBarItem14.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem14.Name = "sale";
            toolBarItem14.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem14.SelectIconID = "calculator";
            toolBarItem14.Text = "销售情况";
            toolBarItem15.IconID = "file-text-o";
            toolBarItem15.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem15.Name = "cinema";
            toolBarItem15.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem15.SelectIconID = "file-text-o";
            toolBarItem15.Text = "影院信息";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem13,
            toolBarItem14,
            toolBarItem15});
            this.toolBar1.Location = new System.Drawing.Point(79, 480);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(100, 50);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick_1);
            // 
            // tabPageView1
            // 
            this.tabPageView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageControl1,
            this.tabPageControl2});
            this.tabPageView1.Location = new System.Drawing.Point(0, 90);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(300, 484);
            this.tabPageView1.Titles = new string[] {
        "正在热映",
        "可上映"};
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129))))), System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(140)))), ((int)(((byte)(255))))), 14F);
            // 
            // tabPageControl2
            // 
            this.tabPageControl2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView2});
            this.tabPageControl2.Name = "tabPageControl2";
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(59, 219);
            this.listView2.Name = "listView2";
            this.listView2.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView2.RaiseRefresh = true;
            this.listView2.Size = new System.Drawing.Size(300, 300);
            this.listView2.TemplateControlName = "AddControl";
            this.listView2.Refresh += new System.EventHandler(this.listView2_Refresh);
            // 
            // tabPageControl1
            // 
            this.tabPageControl1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1});
            this.tabPageControl1.Name = "tabPageControl1";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 73);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.RaiseRefresh = true;
            this.listView1.Size = new System.Drawing.Size(300, 389);
            this.listView1.TemplateControlName = "DelControl";
            this.listView1.Refresh += new System.EventHandler(this.listView1_Refresh);
            // 
            // Administrator
            // 
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.toolBar1});
            this.Name = "Administrator";

        }
        #endregion
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label label1;
        private SearchBox_Control searchBox_Control1;
        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl1;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl2;
        private Smobiler.Core.Controls.ListView listView2;
    }
}