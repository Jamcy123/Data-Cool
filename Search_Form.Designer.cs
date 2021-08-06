using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class Search_Form : Smobiler.Core.Controls.MobileForm
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
            this.title_Control1 = new SmobilerAppTEST7._17.Title_Control();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            // 
            // title_Control1
            // 
            this.title_Control1.BackColor = System.Drawing.Color.Gray;
            this.title_Control1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Control1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.title_Control1.Location = new System.Drawing.Point(53, 59);
            this.title_Control1.Name = "title_Control1";
            this.title_Control1.Size = new System.Drawing.Size(100, 36);
            this.title_Control1.Text = "标题";
            this.title_Control1.ExitButtonpPress += new System.EventHandler(this.title_Control1_ExitButtonpPress_1);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(149, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // Search_Form
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title_Control1,
            this.panel1});
            this.Name = "Search_Form";

        }
        #endregion

        private Title_Control title_Control1;
        private Smobiler.Core.Controls.Panel panel1;
    }
}