using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class moive_select : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.ToolBarItem toolBarItem10 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem11 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem12 = new Smobiler.Core.Controls.ToolBarItem();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.city_label = new Smobiler.Core.Controls.Label();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.city_btn = new Smobiler.Core.Controls.Button();
            this.search_control1 = new SmobilerAppTEST7._17.Search_control();
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            toolBarItem10.IconID = "video-camera";
            toolBarItem10.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem10.Name = "cinema-icon";
            toolBarItem10.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem10.SelectIconID = "video-camera";
            toolBarItem10.Text = "影院";
            toolBarItem11.IconID = "youtube-play";
            toolBarItem11.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem11.Name = "moive-icon";
            toolBarItem11.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem11.SelectIconID = "youtube-play";
            toolBarItem11.Text = "电影";
            toolBarItem12.IconID = "user";
            toolBarItem12.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem12.Name = "user-icon";
            toolBarItem12.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem12.SelectIconID = "user";
            toolBarItem12.Text = "我的";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem10,
            toolBarItem11,
            toolBarItem12});
            this.toolBar1.Location = new System.Drawing.Point(59, 477);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.SelectForeColor = System.Drawing.Color.DeepSkyBlue;
            this.toolBar1.Size = new System.Drawing.Size(100, 50);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(76, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 8);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(300, 330);
            this.listView1.TemplateControlName = "Moive_Control";
            // 
            // fontIcon1
            // 
            this.fontIcon1.Location = new System.Drawing.Point(3, 3);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "map-marker";
            this.fontIcon1.Size = new System.Drawing.Size(25, 25);
            // 
            // city_label
            // 
            this.city_label.FontSize = 14F;
            this.city_label.Location = new System.Drawing.Point(33, 0);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(77, 30);
            this.city_label.Text = "定位城市";
            // 
            // title1
            // 
            this.title1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.title1.BorderColor = System.Drawing.Color.LightGray;
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Location = new System.Drawing.Point(47, 32);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 30);
            // 
            // city_btn
            // 
            this.city_btn.BackColor = System.Drawing.Color.Transparent;
            this.city_btn.Name = "city_btn";
            this.city_btn.Size = new System.Drawing.Size(89, 30);
            this.city_btn.Press += new System.EventHandler(this.city_btn_Press);
            // 
            // search_control1
            // 
            this.search_control1.BorderRadius = 15;
            this.search_control1.Location = new System.Drawing.Point(124, 6);
            this.search_control1.Name = "search_control1";
            this.search_control1.Size = new System.Drawing.Size(130, 20);
            // 
            // moive_select
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.toolBar1,
            this.title1,
            this.panel1,
            this.fontIcon1,
            this.city_label,
            this.city_btn,
            this.search_control1});
            this.Load += new System.EventHandler(this.moive_select_Load);
            this.Name = "moive_select";

        }
        #endregion

        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Label city_label;
        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Button city_btn;
        private Search_control search_control1;
    }
}