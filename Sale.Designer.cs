using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class Sale : Smobiler.Core.Controls.MobileForm
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
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.searchBox_Control = new SmobilerAppTEST7._17.SearchBox_Control();
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
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1,
            this.searchBox_Control});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(134, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 139);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(300, 300);
            this.listView1.TemplateControlName = "SaleControl";
            // 
            // searchBox_Control
            // 
            this.searchBox_Control.BackColor = System.Drawing.Color.White;
            this.searchBox_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBox_Control.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.searchBox_Control.Location = new System.Drawing.Point(0, 29);
            this.searchBox_Control.Name = "searchBox_Control";
            this.searchBox_Control.Size = new System.Drawing.Size(300, 46);
            this.searchBox_Control.TextBox_Text = "";
            this.searchBox_Control.SearchButtonPress += new System.EventHandler(this.searchBox_Control1_SearchButtonPress);
            this.searchBox_Control.Load += new System.EventHandler(this.searchBox_Control1_Load);
            // 
            // Sale
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.toolBar1,
            this.panel1});
            this.Name = "Sale";

        }
        #endregion

        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.ListView listView1;
        private SearchBox_Control searchBox_Control;
    }
}