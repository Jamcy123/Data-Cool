using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class movie_confirm : Smobiler.Core.Controls.MobileForm
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
            this.Mpicadress_image = new Smobiler.Core.Controls.Image();
            this.Mname_lbl = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.Mgrade_lbl = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.Mtype_lbl = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.Mlanguage_lbl = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.Mduration_lbl = new Smobiler.Core.Controls.Label();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl1 = new Smobiler.Core.Controls.TabPageControl();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.tabPageControl2 = new Smobiler.Core.Controls.TabPageControl();
            this.listView2 = new Smobiler.Core.Controls.ListView();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.tabPageControl3 = new Smobiler.Core.Controls.TabPageControl();
            this.listView3 = new Smobiler.Core.Controls.ListView();
            this.label7 = new Smobiler.Core.Controls.Label();
            // 
            // title_Control1
            // 
            this.title_Control1.BackColor = System.Drawing.Color.Gray;
            this.title_Control1.BACKColor_re = System.Drawing.Color.Gray;
            this.title_Control1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Control1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.title_Control1.Name = "title_Control1";
            this.title_Control1.Size = new System.Drawing.Size(300, 36);
            this.title_Control1.Text = "特惠购票";
            this.title_Control1.ExitButtonpPress += new System.EventHandler(this.title_Control1_ExitButtonpPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Mpicadress_image,
            this.Mname_lbl,
            this.label2,
            this.Mgrade_lbl,
            this.label3,
            this.Mtype_lbl,
            this.label1,
            this.Mlanguage_lbl,
            this.label4,
            this.Mduration_lbl});
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 131);
            // 
            // Mpicadress_image
            // 
            this.Mpicadress_image.BorderRadius = 7;
            this.Mpicadress_image.DisplayMember = "Mpicadress";
            this.Mpicadress_image.Location = new System.Drawing.Point(8, 9);
            this.Mpicadress_image.Name = "Mpicadress_image";
            this.Mpicadress_image.ResourceID = global::SmobilerAppTEST7._17.Properties.Settings.Default.Mpicadress;
            this.Mpicadress_image.Size = new System.Drawing.Size(100, 120);
            // 
            // Mname_lbl
            // 
            this.Mname_lbl.Bold = true;
            this.Mname_lbl.DataMember = "Mno";
            this.Mname_lbl.DisplayMember = "Mname";
            this.Mname_lbl.FontSize = 20F;
            this.Mname_lbl.Location = new System.Drawing.Point(132, 9);
            this.Mname_lbl.Name = "Mname_lbl";
            this.Mname_lbl.Size = new System.Drawing.Size(148, 26);
            this.Mname_lbl.Text = "label1";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(132, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.Text = "电影评分";
            // 
            // Mgrade_lbl
            // 
            this.Mgrade_lbl.DisplayMember = "Mgrade";
            this.Mgrade_lbl.FontSize = 14F;
            this.Mgrade_lbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.Mgrade_lbl.Location = new System.Drawing.Point(204, 51);
            this.Mgrade_lbl.Name = "Mgrade_lbl";
            this.Mgrade_lbl.Size = new System.Drawing.Size(50, 17);
            this.Mgrade_lbl.Text = "label4";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(132, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.Text = "电影类型";
            // 
            // Mtype_lbl
            // 
            this.Mtype_lbl.DisplayMember = "Mtype";
            this.Mtype_lbl.Location = new System.Drawing.Point(204, 68);
            this.Mtype_lbl.Name = "Mtype_lbl";
            this.Mtype_lbl.Size = new System.Drawing.Size(76, 17);
            this.Mtype_lbl.Text = "label5";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(132, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.Text = "电影语言";
            // 
            // Mlanguage_lbl
            // 
            this.Mlanguage_lbl.DisplayMember = "Mlanguage";
            this.Mlanguage_lbl.Location = new System.Drawing.Point(204, 85);
            this.Mlanguage_lbl.Name = "Mlanguage_lbl";
            this.Mlanguage_lbl.Size = new System.Drawing.Size(76, 17);
            this.Mlanguage_lbl.Text = "label5";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(132, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.Text = "电影时长";
            // 
            // Mduration_lbl
            // 
            this.Mduration_lbl.DisplayMember = "Mgrade";
            this.Mduration_lbl.FontSize = 14F;
            this.Mduration_lbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.Mduration_lbl.Location = new System.Drawing.Point(204, 102);
            this.Mduration_lbl.Name = "Mduration_lbl";
            this.Mduration_lbl.Size = new System.Drawing.Size(50, 17);
            this.Mduration_lbl.Text = "label4";
            // 
            // tabPageView1
            // 
            this.tabPageView1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.tabPageView1.BorderColor = System.Drawing.Color.LightGray;
            this.tabPageView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageControl1,
            this.tabPageControl2,
            this.tabPageControl3});
            this.tabPageView1.Location = new System.Drawing.Point(0, 176);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(300, 333);
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129))))), System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(140)))), ((int)(((byte)(255))))), 13F, System.Drawing.Color.Silver, 2);
            // 
            // tabPageControl1
            // 
            this.tabPageControl1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1,
            this.label5});
            this.tabPageControl1.Name = "tabPageControl1";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 10);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(300, 323);
            this.listView1.TemplateControlName = "mcTemplate";
            this.listView1.RowBind += new Smobiler.Core.Controls.ListViewTemplateBindEventHandler(this.listView1_RowBind);
            // 
            // label5
            // 
            this.label5.Bold = true;
            this.label5.FontSize = 16F;
            this.label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label5.Location = new System.Drawing.Point(37, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 64);
            this.label5.Text = "暂无排片，敬请期待！";
            this.label5.Visible = false;
            // 
            // tabPageControl2
            // 
            this.tabPageControl2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView2,
            this.label6});
            this.tabPageControl2.Name = "tabPageControl2";
            // 
            // listView2
            // 
            this.listView2.BorderColor = System.Drawing.Color.Transparent;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(0, 10);
            this.listView2.Name = "listView2";
            this.listView2.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView2.Size = new System.Drawing.Size(300, 274);
            this.listView2.TemplateControlName = "mcTemplate";
            this.listView2.RowBind += new Smobiler.Core.Controls.ListViewTemplateBindEventHandler(this.listView1_RowBind);
            // 
            // label6
            // 
            this.label6.Bold = true;
            this.label6.FontSize = 16F;
            this.label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label6.Location = new System.Drawing.Point(37, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 64);
            this.label6.Text = "暂无排片，敬请期待！";
            this.label6.Visible = false;
            // 
            // tabPageControl3
            // 
            this.tabPageControl3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView3,
            this.label7});
            this.tabPageControl3.Name = "tabPageControl3";
            // 
            // listView3
            // 
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.Location = new System.Drawing.Point(0, 10);
            this.listView3.Name = "listView3";
            this.listView3.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView3.Size = new System.Drawing.Size(300, 274);
            this.listView3.TemplateControlName = "mcTemplate";
            this.listView3.RowBind += new Smobiler.Core.Controls.ListViewTemplateBindEventHandler(this.listView1_RowBind);
            // 
            // label7
            // 
            this.label7.Bold = true;
            this.label7.FontSize = 16F;
            this.label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label7.Location = new System.Drawing.Point(37, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 64);
            this.label7.Text = "暂无排片，敬请期待！";
            this.label7.Visible = false;
            // 
            // movie_confirm
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title_Control1,
            this.panel1,
            this.tabPageView1});
            this.Load += new System.EventHandler(this.movie_confirm_Load);
            this.Name = "movie_confirm";

        }
        #endregion
        private Title_Control title_Control1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image Mpicadress_image;
        private Smobiler.Core.Controls.Label Mname_lbl;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label Mgrade_lbl;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label Mtype_lbl;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label Mlanguage_lbl;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label Mduration_lbl;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl1;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl2;
        private Smobiler.Core.Controls.ListView listView2;
        private Smobiler.Core.Controls.TabPageControl tabPageControl3;
        private Smobiler.Core.Controls.ListView listView3;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label label7;
    }
}