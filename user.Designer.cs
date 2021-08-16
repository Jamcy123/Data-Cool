﻿using System;
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
            Smobiler.Core.Controls.ToolBarItem toolBarItem7 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem8 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem9 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.IconMenuViewGroup iconMenuViewGroup3 = new Smobiler.Core.Controls.IconMenuViewGroup();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem7 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem8 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem9 = new Smobiler.Core.Controls.IconMenuViewItem();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.iconMenuView1 = new Smobiler.Core.Controls.IconMenuView();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            toolBarItem7.IconID = "video-camera";
            toolBarItem7.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem7.Name = "cinema-icon";
            toolBarItem7.SelectIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            toolBarItem7.SelectIconID = "video-camera";
            toolBarItem7.Text = "影院";
            toolBarItem8.IconID = "youtube-play";
            toolBarItem8.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem8.Name = "moive-icon";
            toolBarItem8.SelectIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            toolBarItem8.SelectIconID = "youtube-play";
            toolBarItem8.Text = "电影";
            toolBarItem9.IconID = "user";
            toolBarItem9.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem9.Name = "user-icon";
            toolBarItem9.SelectIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            toolBarItem9.SelectIconID = "user";
            toolBarItem9.Text = "我的";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem7,
            toolBarItem8,
            toolBarItem9});
            this.toolBar1.Location = new System.Drawing.Point(59, 477);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.SelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.toolBar1.Size = new System.Drawing.Size(100, 50);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1,
            this.iconMenuView1,
            this.panel2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // image1
            // 
            this.image1.BorderRadius = 40;
            this.image1.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dashed;
            this.image1.Location = new System.Drawing.Point(15, 49);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(80, 80);
            this.image1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.BorderColor = System.Drawing.Color.White;
            this.label1.FontSize = 25F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 35);
            this.label1.Text = "label1";
            // 
            // iconMenuView1
            // 
            this.iconMenuView1.ColumnNum = 3;
            this.iconMenuView1.GroupBackColor = System.Drawing.Color.Transparent;
            iconMenuViewGroup3.FontSize = 16F;
            iconMenuViewGroup3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            iconMenuViewGroup3.IconBorderRadius = 0;
            iconMenuViewGroup3.ItemHeight = 0;
            iconMenuViewItem7.Icon = "file-text-o";
            iconMenuViewItem7.ID = "order";
            iconMenuViewItem7.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            iconMenuViewItem7.Text = "我的订单";
            iconMenuViewItem8.Icon = "credit-card-alt";
            iconMenuViewItem8.ID = "blance";
            iconMenuViewItem8.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            iconMenuViewItem8.Text = "我的余额";
            iconMenuViewItem9.Icon = "user";
            iconMenuViewItem9.ID = "message";
            iconMenuViewItem9.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            iconMenuViewItem9.Text = "我的资料";
            iconMenuViewGroup3.Items.AddRange(new Smobiler.Core.Controls.IconMenuViewItem[] {
            iconMenuViewItem7,
            iconMenuViewItem8,
            iconMenuViewItem9});
            iconMenuViewGroup3.ShowTitle = true;
            iconMenuViewGroup3.Text = "我的";
            this.iconMenuView1.Groups.AddRange(new Smobiler.Core.Controls.IconMenuViewGroup[] {
            iconMenuViewGroup3});
            this.iconMenuView1.Location = new System.Drawing.Point(0, 163);
            this.iconMenuView1.Name = "iconMenuView1";
            this.iconMenuView1.Size = new System.Drawing.Size(300, 104);
            this.iconMenuView1.ItemPress += new Smobiler.Core.Controls.IconMenuViewItemPressClickHandler(this.iconMenuView1_ItemPress);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button2,
            this.button1});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 149);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BindDisplayValueGone = true;
            this.button2.Border = new Smobiler.Core.Controls.Border(1F);
            this.button2.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.BorderRadius = 20;
            this.button2.FontSize = 16F;
            this.button2.ForeColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(56, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 42);
            this.button2.Text = "修改密码";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Border = new Smobiler.Core.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.BorderRadius = 20;
            this.button1.FontSize = 16F;
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(56, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 42);
            this.button1.Text = "退出登录";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // user
            // 
            this.BackgroundImage = "background";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.toolBar1,
            this.panel1});
            this.Name = "user";

        }
        #endregion

        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.IconMenuView iconMenuView1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.Button button1;
    }
}