using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class Myorder : Smobiler.Core.Controls.MobileForm
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
            this.title1 = new Smobiler.Core.Controls.Title();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.SkyBlue;
            this.title1.Location = new System.Drawing.Point(117, 10);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 30);
            this.title1.Text = "我的订单";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 30);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.ShowSplitLine = true;
            this.listView1.Size = new System.Drawing.Size(300, 470);
            this.listView1.SplitLineColor = System.Drawing.Color.Silver;
            this.listView1.TemplateControlName = "orderTemplate";
            // 
            // Myorder
            // 
            this.BackgroundImage = "bluee";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.listView1});
            this.Load += new System.EventHandler(this.Myorder_Load);
            this.Name = "Myorder";

        }
        #endregion
        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.ListView listView1;
    }
}