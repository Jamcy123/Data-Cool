using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class SmobilerForm2 : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.IconMenuViewGroup iconMenuViewGroup1 = new Smobiler.Core.Controls.IconMenuViewGroup();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem1 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem2 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem3 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem4 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem5 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem6 = new Smobiler.Core.Controls.IconMenuViewItem();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.iconMenuView1 = new Smobiler.Core.Controls.IconMenuView();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.button4 = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.iconMenuView1,
            this.button1,
            this.button2,
            this.button3,
            this.button4});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(92, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            this.panel1.Wrap = Smobiler.Core.Controls.LayoutWrap.Wrap;
            // 
            // iconMenuView1
            // 
            iconMenuViewGroup1.FontSize = 0F;
            iconMenuViewGroup1.IconBorderRadius = 50;
            iconMenuViewGroup1.ItemHeight = 50;
            iconMenuViewItem1.Icon = "battery-empty";
            iconMenuViewItem1.ID = "one";
            iconMenuViewItem1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            iconMenuViewItem1.MessageText = "1";
            iconMenuViewItem1.Text = "2";
            iconMenuViewItem1.Value = "3";
            iconMenuViewItem2.Icon = "battery-quarter";
            iconMenuViewItem2.ID = "two";
            iconMenuViewItem2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            iconMenuViewItem2.Text = "2";
            iconMenuViewItem3.Icon = "battery-half";
            iconMenuViewItem3.IconPath = "document";
            iconMenuViewItem3.ID = "three";
            iconMenuViewItem3.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            iconMenuViewItem3.Text = "3";
            iconMenuViewItem4.Icon = "battery-three-quarters";
            iconMenuViewItem4.IconPath = "upload";
            iconMenuViewItem4.ID = "four";
            iconMenuViewItem4.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            iconMenuViewItem4.Text = "4";
            iconMenuViewItem5.Icon = "battery-full";
            iconMenuViewItem5.IconPath = "media";
            iconMenuViewItem5.ID = "five";
            iconMenuViewItem5.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            iconMenuViewItem5.Text = "5";
            iconMenuViewItem6.Icon = "logon";
            iconMenuViewItem6.ID = "logon";
            iconMenuViewItem6.MessageText = "logon";
            iconMenuViewItem6.Text = "logon1";
            iconMenuViewGroup1.Items.AddRange(new Smobiler.Core.Controls.IconMenuViewItem[] {
            iconMenuViewItem1,
            iconMenuViewItem2,
            iconMenuViewItem3,
            iconMenuViewItem4,
            iconMenuViewItem5,
            iconMenuViewItem6});
            this.iconMenuView1.Groups.AddRange(new Smobiler.Core.Controls.IconMenuViewGroup[] {
            iconMenuViewGroup1});
            this.iconMenuView1.Location = new System.Drawing.Point(5, 147);
            this.iconMenuView1.Name = "iconMenuView1";
            this.iconMenuView1.Size = new System.Drawing.Size(300, 300);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "button1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Text = "button2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.Text = "button3";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(100, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.Text = "button4";
            // 
            // SmobilerForm2
            // 
            this.BackgroundImage = "white.png";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Name = "SmobilerForm2";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.IconMenuView iconMenuView1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.Button button3;
        private Smobiler.Core.Controls.Button button4;
    }
}