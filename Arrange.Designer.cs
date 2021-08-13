using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class Arrange : Smobiler.Core.Controls.MobileForm
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
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.Mgrade_lbl = new Smobiler.Core.Controls.Label();
            this.Mtype_lbl = new Smobiler.Core.Controls.Label();
            this.Mlanguage_lbl = new Smobiler.Core.Controls.Label();
            this.Mpicadress_image = new Smobiler.Core.Controls.Image();
            this.Mname_lbl = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.Mduration_lbl = new Smobiler.Core.Controls.Label();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl1 = new Smobiler.Core.Controls.TabPageControl();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl2 = new Smobiler.Core.Controls.TabPageControl();
            this.listView2 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl3 = new Smobiler.Core.Controls.TabPageControl();
            this.listView3 = new Smobiler.Core.Controls.ListView();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            // 
            // title_Control1
            // 
            this.title_Control1.BackColor = System.Drawing.Color.Gray;
            this.title_Control1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Control1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.title_Control1.Name = "title_Control1";
            this.title_Control1.Size = new System.Drawing.Size(300, 36);
            this.title_Control1.Text = "安排场次";
            this.title_Control1.ExitButtonpPress += new System.EventHandler(this.title_Control1_ExitButtonpPress);
            this.title_Control1.Load += new System.EventHandler(this.title_Control1_Load_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label4,
            this.label1,
            this.Mgrade_lbl,
            this.Mtype_lbl,
            this.Mlanguage_lbl,
            this.Mpicadress_image,
            this.Mname_lbl,
            this.label2,
            this.label3,
            this.Mduration_lbl});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 152);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(137, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.Text = "电影时长";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(137, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.Text = "电影语言";
            // 
            // Mgrade_lbl
            // 
            this.Mgrade_lbl.DisplayMember = "Mgrade";
            this.Mgrade_lbl.FontSize = 14F;
            this.Mgrade_lbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.Mgrade_lbl.Location = new System.Drawing.Point(209, 54);
            this.Mgrade_lbl.Name = "Mgrade_lbl";
            this.Mgrade_lbl.Size = new System.Drawing.Size(50, 17);
            this.Mgrade_lbl.Text = "label4";
            // 
            // Mtype_lbl
            // 
            this.Mtype_lbl.DisplayMember = "Mtype";
            this.Mtype_lbl.Location = new System.Drawing.Point(209, 79);
            this.Mtype_lbl.Name = "Mtype_lbl";
            this.Mtype_lbl.Size = new System.Drawing.Size(76, 17);
            this.Mtype_lbl.Text = "label5";
            // 
            // Mlanguage_lbl
            // 
            this.Mlanguage_lbl.DisplayMember = "Mlanguage";
            this.Mlanguage_lbl.Location = new System.Drawing.Point(209, 104);
            this.Mlanguage_lbl.Name = "Mlanguage_lbl";
            this.Mlanguage_lbl.Size = new System.Drawing.Size(76, 17);
            this.Mlanguage_lbl.Text = "label5";
            // 
            // Mpicadress_image
            // 
            this.Mpicadress_image.BorderRadius = 7;
            this.Mpicadress_image.DisplayMember = "Mpicadress";
            this.Mpicadress_image.Location = new System.Drawing.Point(13, 12);
            this.Mpicadress_image.Name = "Mpicadress_image";
            this.Mpicadress_image.ResourceID = global::SmobilerAppTEST7._17.Properties.Settings.Default.Mpicadress;
            this.Mpicadress_image.Size = new System.Drawing.Size(100, 134);
            // 
            // Mname_lbl
            // 
            this.Mname_lbl.Bold = true;
            this.Mname_lbl.DataMember = "Mno";
            this.Mname_lbl.DisplayMember = "Mname";
            this.Mname_lbl.FontSize = 17F;
            this.Mname_lbl.Location = new System.Drawing.Point(137, 12);
            this.Mname_lbl.Name = "Mname_lbl";
            this.Mname_lbl.Size = new System.Drawing.Size(148, 26);
            this.Mname_lbl.Text = "label1";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(137, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.Text = "电影评分";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(137, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.Text = "电影类型";
            // 
            // Mduration_lbl
            // 
            this.Mduration_lbl.DisplayMember = "Mgrade";
            this.Mduration_lbl.FontSize = 14F;
            this.Mduration_lbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.Mduration_lbl.Location = new System.Drawing.Point(209, 129);
            this.Mduration_lbl.Name = "Mduration_lbl";
            this.Mduration_lbl.Size = new System.Drawing.Size(50, 17);
            this.Mduration_lbl.Text = "label4";
            // 
            // tabPageView1
            // 
            this.tabPageView1.BackColor = System.Drawing.Color.White;
            this.tabPageView1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.tabPageView1.BorderColor = System.Drawing.Color.LightGray;
            this.tabPageView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageControl1,
            this.tabPageControl2,
            this.tabPageControl3});
            this.tabPageView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabPageView1.Location = new System.Drawing.Point(0, 244);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.Size = new System.Drawing.Size(300, 312);
            // 
            // tabPageControl1
            // 
            this.tabPageControl1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1,
            this.button1});
            this.tabPageControl1.Name = "tabPageControl1";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 31);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(300, 203);
            this.listView1.TemplateControlName = "Session";
            // 
            // tabPageControl2
            // 
            this.tabPageControl2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView2,
            this.button2});
            this.tabPageControl2.Name = "tabPageControl2";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(0, 31);
            this.listView2.Name = "listView2";
            this.listView2.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView2.Size = new System.Drawing.Size(300, 203);
            this.listView2.TemplateControlName = "Session";
            // 
            // tabPageControl3
            // 
            this.tabPageControl3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView3,
            this.button3});
            this.tabPageControl3.Name = "tabPageControl3";
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(0, 31);
            this.listView3.Name = "listView3";
            this.listView3.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView3.Size = new System.Drawing.Size(300, 203);
            this.listView3.TemplateControlName = "Session";
            // 
            // button1
            // 
            this.button1.FontSize = 16F;
            this.button1.Location = new System.Drawing.Point(97, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.Text = "添加场次";
            // 
            // button2
            // 
            this.button2.FontSize = 16F;
            this.button2.Location = new System.Drawing.Point(104, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.Text = "添加场次";
            // 
            // button3
            // 
            this.button3.FontSize = 16F;
            this.button3.Location = new System.Drawing.Point(104, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.Text = "添加场次";
            // 
            // Arrange
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title_Control1,
            this.panel1,
            this.tabPageView1});
            this.Name = "Arrange";

        }
        #endregion

        private Title_Control title_Control1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label Mgrade_lbl;
        private Smobiler.Core.Controls.Label Mtype_lbl;
        private Smobiler.Core.Controls.Label Mlanguage_lbl;
        private Smobiler.Core.Controls.Image Mpicadress_image;
        private Smobiler.Core.Controls.Label Mname_lbl;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label Mduration_lbl;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl1;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl2;
        private Smobiler.Core.Controls.ListView listView2;
        private Smobiler.Core.Controls.TabPageControl tabPageControl3;
        private Smobiler.Core.Controls.ListView listView3;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.Button button3;
    }
}