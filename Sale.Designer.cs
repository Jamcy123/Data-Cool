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
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
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
            // Sale
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.toolBar1});
            this.Name = "Sale";

        }
        #endregion

        private Smobiler.Core.Controls.ToolBar toolBar1;
    }
}