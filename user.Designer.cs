using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class user : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.ToolBarItem toolBarItem4 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem5 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem6 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.IconMenuViewGroup iconMenuViewGroup2 = new Smobiler.Core.Controls.IconMenuViewGroup();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem4 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem5 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem6 = new Smobiler.Core.Controls.IconMenuViewItem();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.iconMenuView1 = new Smobiler.Core.Controls.IconMenuView();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.title_Control1 = new SmobilerAppTEST7._17.Title_Control();
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            toolBarItem4.IconID = "video-camera";
            toolBarItem4.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem4.Name = "cinema-icon";
            toolBarItem4.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem4.SelectIconID = "video-camera";
            toolBarItem4.Text = "影院";
            toolBarItem5.IconID = "youtube-play";
            toolBarItem5.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem5.Name = "moive-icon";
            toolBarItem5.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem5.SelectIconID = "youtube-play";
            toolBarItem5.Text = "电影";
            toolBarItem6.IconID = "user";
            toolBarItem6.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem6.Name = "user-icon";
            toolBarItem6.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem6.SelectIconID = "user";
            toolBarItem6.Text = "我的";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem4,
            toolBarItem5,
            toolBarItem6});
            this.toolBar1.Location = new System.Drawing.Point(59, 477);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.SelectForeColor = System.Drawing.Color.DeepSkyBlue;
            this.toolBar1.Size = new System.Drawing.Size(100, 50);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1,
            this.iconMenuView1,
            this.button1,
            this.button2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // image1
            // 
            this.image1.BorderRadius = 40;
            this.image1.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dashed;
            this.image1.Location = new System.Drawing.Point(15, 53);
            this.image1.Name = "image1";
            this.image1.ResourceID = "wanzi";
            this.image1.Size = new System.Drawing.Size(80, 80);
            // 
            // label1
            // 
            this.label1.FontSize = 16F;
            this.label1.Location = new System.Drawing.Point(99, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 35);
            this.label1.Text = "label1";
            // 
            // iconMenuView1
            // 
            this.iconMenuView1.ColumnNum = 3;
            this.iconMenuView1.GroupBackColor = System.Drawing.Color.Transparent;
            iconMenuViewGroup2.FontSize = 16F;
            iconMenuViewGroup2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            iconMenuViewGroup2.IconBorderRadius = 0;
            iconMenuViewGroup2.ItemHeight = 0;
            iconMenuViewItem4.Icon = "file-text-o";
            iconMenuViewItem4.ID = "order";
            iconMenuViewItem4.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            iconMenuViewItem4.Text = "我的订单";
            iconMenuViewItem5.Icon = "credit-card-alt";
            iconMenuViewItem5.ID = "blance";
            iconMenuViewItem5.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            iconMenuViewItem5.Text = "我的余额";
            iconMenuViewItem6.Icon = "user";
            iconMenuViewItem6.ID = "message";
            iconMenuViewItem6.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            iconMenuViewItem6.Text = "我的资料";
            iconMenuViewGroup2.Items.AddRange(new Smobiler.Core.Controls.IconMenuViewItem[] {
            iconMenuViewItem4,
            iconMenuViewItem5,
            iconMenuViewItem6});
            iconMenuViewGroup2.ShowTitle = true;
            iconMenuViewGroup2.Text = "我的";
            this.iconMenuView1.Groups.AddRange(new Smobiler.Core.Controls.IconMenuViewGroup[] {
            iconMenuViewGroup2});
            this.iconMenuView1.Location = new System.Drawing.Point(0, 163);
            this.iconMenuView1.Name = "iconMenuView1";
            this.iconMenuView1.Size = new System.Drawing.Size(300, 104);
            this.iconMenuView1.ItemPress += new Smobiler.Core.Controls.IconMenuViewItemPressClickHandler(this.iconMenuView1_ItemPress);
            // 
            // button1
            // 
            this.button1.FontSize = 16F;
            this.button1.Location = new System.Drawing.Point(92, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.Text = "退出登录";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.FontSize = 16F;
            this.button2.Location = new System.Drawing.Point(92, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.Text = "修改密码";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // title_Control1
            // 
            this.title_Control1.BackColor = System.Drawing.Color.Gray;
            this.title_Control1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Control1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.title_Control1.Location = new System.Drawing.Point(83, 22);
            this.title_Control1.Name = "title_Control1";
            this.title_Control1.Size = new System.Drawing.Size(100, 36);
            this.title_Control1.Text = "我的";
            this.title_Control1.ExitButtonpPress += new System.EventHandler(this.title_Control1_ExitButtonpPress);
            // 
            // user
            // 
            this.BackgroundImage = "bluee";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.toolBar1,
            this.panel1,
            this.title_Control1});
            this.Name = "user";

        }
        #endregion

        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.IconMenuView iconMenuView1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Button button2;
        private Title_Control title_Control1;
    }
}