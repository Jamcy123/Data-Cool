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
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem3 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.PopListGroup popListGroup1 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListItem popListItem1 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem2 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem3 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListGroup popListGroup2 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListItem popListItem4 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem5 = new Smobiler.Core.Controls.PopListItem();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.searchBox_Control = new SmobilerAppTEST7._17.SearchBox_Control();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.order = new Smobiler.Core.Controls.Label();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.sequence = new Smobiler.Core.Controls.Label();
            this.popList1 = new Smobiler.Core.Controls.PopList();
            this.popList2 = new Smobiler.Core.Controls.PopList();
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            this.toolBar1.BorderColor = System.Drawing.Color.White;
            toolBarItem1.IconID = "film";
            toolBarItem1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem1.Name = "film";
            toolBarItem1.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem1.SelectIconID = "film";
            toolBarItem1.Text = "电影管理";
            toolBarItem2.IconID = "calculator";
            toolBarItem2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem2.Name = "sale";
            toolBarItem2.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem2.SelectIconID = "calculator";
            toolBarItem2.Text = "销售情况";
            toolBarItem3.IconID = "file-text-o";
            toolBarItem3.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem3.Name = "cinema";
            toolBarItem3.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem3.SelectIconID = "file-text-o";
            toolBarItem3.Text = "影院信息";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2,
            toolBarItem3});
            this.toolBar1.Location = new System.Drawing.Point(79, 480);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(100, 50);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1,
            this.searchBox_Control,
            this.panel2});
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
            this.listView1.RowBind += new Smobiler.Core.Controls.ListViewTemplateBindEventHandler(this.listView1_RowBind);
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
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel3,
            this.panel4});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 50);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.order});
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 50);
            this.panel3.Touchable = true;
            this.panel3.Press += new System.EventHandler(this.panel3_Press);
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 44);
            this.label1.Text = "排序：";
            // 
            // order
            // 
            this.order.Bold = true;
            this.order.FontSize = 14F;
            this.order.ForeColor = System.Drawing.Color.DimGray;
            this.order.Location = new System.Drawing.Point(57, 3);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(133, 42);
            this.order.Text = "电影评分";
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.sequence});
            this.panel4.Location = new System.Drawing.Point(195, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(105, 50);
            this.panel4.Touchable = true;
            this.panel4.Press += new System.EventHandler(this.panel4_Press);
            // 
            // sequence
            // 
            this.sequence.Bold = true;
            this.sequence.FontSize = 14F;
            this.sequence.ForeColor = System.Drawing.Color.DimGray;
            this.sequence.Location = new System.Drawing.Point(1, 3);
            this.sequence.Name = "sequence";
            this.sequence.Size = new System.Drawing.Size(119, 41);
            this.sequence.Text = "升序";
            // 
            // popList1
            // 
            popListItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem1.Text = "电影评分";
            popListItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem2.Text = "卖出数量";
            popListItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem3.Text = "卖出数量的占比";
            popListGroup1.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem1,
            popListItem2,
            popListItem3});
            popListGroup1.Value = null;
            this.popList1.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup1});
            this.popList1.Name = "popList1";
            this.popList1.Title = "请选择排序方式";
            this.popList1.Selected += new System.EventHandler(this.popList1_Selected);
            // 
            // popList2
            // 
            popListItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem4.Text = "升序";
            popListItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem5.Text = "降序";
            popListGroup2.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem4,
            popListItem5});
            popListGroup2.Value = null;
            this.popList2.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup2});
            this.popList2.Name = "popList2";
            this.popList2.Selected += new System.EventHandler(this.popList2_Selected);
            // 
            // Sale
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popList1,
            this.popList2});
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
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.Label order;
        private Smobiler.Core.Controls.PopList popList1;
        private Smobiler.Core.Controls.PopList popList2;
        private Smobiler.Core.Controls.Label sequence;
    }
}