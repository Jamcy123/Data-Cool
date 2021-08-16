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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.title_Control1 = new SmobilerAppTEST7._17.Title_Control();
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.FontSize = 16F;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(36, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 53);
            this.label1.Text = "暂无订单，快去购票！";
            // 
            // listView1
            // 
            this.listView1.BindMode = Smobiler.Core.Controls.DataBindMode.BindUpdate;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 30);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.ShowSplitLine = true;
            this.listView1.Size = new System.Drawing.Size(300, 470);
            this.listView1.SplitLineColor = System.Drawing.Color.Silver;
            this.listView1.TemplateControlName = "orderTemplate";
            this.listView1.RowBind += new Smobiler.Core.Controls.ListViewTemplateBindEventHandler(this.listView1_RowBind);
            // 
            // title_Control1
            // 
            this.title_Control1.BackColor = System.Drawing.Color.Gray;
            this.title_Control1.BACKColor_re = System.Drawing.Color.Gray;
            this.title_Control1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Control1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.title_Control1.Location = new System.Drawing.Point(102, 10);
            this.title_Control1.Name = "title_Control1";
            this.title_Control1.Size = new System.Drawing.Size(100, 36);
            this.title_Control1.Text = "我的订单";
            this.title_Control1.ExitButtonpPress += new System.EventHandler(this.title_Control1_ExitButtonpPress);
            // 
            // Myorder
            // 
            this.BackgroundImage = "background";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title_Control1,
            this.label1,
            this.listView1});
            this.Load += new System.EventHandler(this.Myorder_Load);
            this.Name = "Myorder";

        }
        #endregion
        private Title_Control title_Control1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.ListView listView1;
    }
}