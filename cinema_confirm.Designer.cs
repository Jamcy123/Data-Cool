using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class cinema_confirm : Smobiler.Core.Controls.MobileForm
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
            this.title_Control1 = new SmobilerAppTEST7._17.Title_Control();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.Cname_lbl = new Smobiler.Core.Controls.Label();
            this.Caddress_lbl = new Smobiler.Core.Controls.Label();
            this.Cno_lbl = new Smobiler.Core.Controls.Label();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl1 = new Smobiler.Core.Controls.TabPageControl();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl2 = new Smobiler.Core.Controls.TabPageControl();
            this.listView2 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl3 = new Smobiler.Core.Controls.TabPageControl();
            this.listView3 = new Smobiler.Core.Controls.ListView();
            // 
            // title_Control1
            // 
            this.title_Control1.BackColor = System.Drawing.Color.Gray;
            this.title_Control1.BACKColor_re = System.Drawing.Color.Gray;
            this.title_Control1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Control1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.title_Control1.Name = "title_Control1";
            this.title_Control1.Size = new System.Drawing.Size(356, 36);
            this.title_Control1.Text = "特惠购票";
            this.title_Control1.ExitButtonpPress += new System.EventHandler(this.title_Control1_ExitButtonpPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel1.BorderColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Cname_lbl,
            this.Caddress_lbl});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 76);
            // 
            // Cname_lbl
            // 
            this.Cname_lbl.Bold = true;
            this.Cname_lbl.FontSize = 20F;
            this.Cname_lbl.Location = new System.Drawing.Point(10, 1);
            this.Cname_lbl.Name = "Cname_lbl";
            this.Cname_lbl.Size = new System.Drawing.Size(189, 35);
            this.Cname_lbl.Text = "label1";
            // 
            // Caddress_lbl
            // 
            this.Caddress_lbl.Location = new System.Drawing.Point(10, 36);
            this.Caddress_lbl.Name = "Caddress_lbl";
            this.Caddress_lbl.Size = new System.Drawing.Size(280, 35);
            this.Caddress_lbl.Text = "label1";
            // 
            // Cno_lbl
            // 
            this.Cno_lbl.DisplayMember = "Cno";
            this.Cno_lbl.Location = new System.Drawing.Point(200, 37);
            this.Cno_lbl.Name = "Cno_lbl";
            this.Cno_lbl.Size = new System.Drawing.Size(100, 35);
            this.Cno_lbl.Text = "label1";
            this.Cno_lbl.Visible = false;
            // 
            // tabPageView1
            // 
            this.tabPageView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageControl1,
            this.tabPageControl2,
            this.tabPageControl3});
            this.tabPageView1.Location = new System.Drawing.Point(0, 125);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(300, 375);
            this.tabPageView1.Titles = new string[] {
        "1",
        "2",
        "3"};
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129))))), System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(140)))), ((int)(((byte)(255))))), 13F, System.Drawing.Color.LightGray, 2);
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
            this.listView1.Location = new System.Drawing.Point(0, 20);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(300, 355);
            this.listView1.TemplateControlName = "ccTemplate";
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
            this.listView2.Location = new System.Drawing.Point(0, 20);
            this.listView2.Name = "listView2";
            this.listView2.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView2.Size = new System.Drawing.Size(300, 300);
            this.listView2.TemplateControlName = "ccTemplate";
            // 
            // tabPageControl3
            // 
            this.tabPageControl3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView3});
            this.tabPageControl3.Name = "tabPageControl3";
            // 
            // listView3
            // 
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.Location = new System.Drawing.Point(0, 20);
            this.listView3.Name = "listView3";
            this.listView3.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView3.Size = new System.Drawing.Size(300, 300);
            this.listView3.TemplateControlName = "ccTemplate";
            // 
            // cinema_confirm
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title_Control1,
            this.Cno_lbl,
            this.panel1,
            this.tabPageView1});
            this.Load += new System.EventHandler(this.cinema_confirm_Load);
            this.Name = "cinema_confirm";

        }
        #endregion
        private Title_Control title_Control1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label Cname_lbl;
        private Smobiler.Core.Controls.Label Caddress_lbl;
        private Smobiler.Core.Controls.Label Cno_lbl;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl1;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl2;
        private Smobiler.Core.Controls.ListView listView2;
        private Smobiler.Core.Controls.TabPageControl tabPageControl3;
        private Smobiler.Core.Controls.ListView listView3;
    }
}