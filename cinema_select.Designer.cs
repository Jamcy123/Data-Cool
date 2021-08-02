using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class Cinema_select : Smobiler.Core.Controls.MobileForm
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
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            toolBarItem7.IconID = "video-camera";
            toolBarItem7.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem7.Name = "cinema-icon";
            toolBarItem7.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem7.SelectIconID = "video-camera";
            toolBarItem7.Text = "影院";
            toolBarItem8.IconID = "youtube-play";
            toolBarItem8.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem8.Name = "moive-icon";
            toolBarItem8.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem8.SelectIconID = "youtube-play";
            toolBarItem8.Text = "电影";
            toolBarItem9.IconID = "user";
            toolBarItem9.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem9.Name = "user-icon";
            toolBarItem9.SelectIconColor = System.Drawing.Color.DeepSkyBlue;
            toolBarItem9.SelectIconID = "user";
            toolBarItem9.Text = "我的";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem7,
            toolBarItem8,
            toolBarItem9});
            this.toolBar1.Location = new System.Drawing.Point(59, 477);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.SelectForeColor = System.Drawing.Color.DeepSkyBlue;
            this.toolBar1.Size = new System.Drawing.Size(100, 50);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "选影院的";
            // 
            // cinema_select
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.toolBar1,
            this.label1});
            this.Name = "cinema_select";

        }
        #endregion

        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.Label label1;
    }
}