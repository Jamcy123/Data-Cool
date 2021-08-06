using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class Title_Control : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.Title_lbl = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title_lbl,
            this.panel2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 45);
            this.panel2.Touchable = true;
            this.panel2.Press += new System.EventHandler(this.panel2_Press);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.White;
            this.fontIcon1.Location = new System.Drawing.Point(10, 3);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "angle-left";
            this.fontIcon1.Size = new System.Drawing.Size(28, 28);
            // 
            // Title_lbl
            // 
            this.Title_lbl.BorderColor = System.Drawing.Color.Transparent;
            this.Title_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_lbl.FontSize = 18F;
            this.Title_lbl.ForeColor = System.Drawing.Color.White;
            this.Title_lbl.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Title_lbl.Location = new System.Drawing.Point(18, 7);
            this.Title_lbl.Name = "Title_lbl";
            this.Title_lbl.Size = new System.Drawing.Size(0, 0);
            this.Title_lbl.Text = "标题";
            // 
            // Title_Control
            // 
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(0, 36);
            this.Name = "Title_Control";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label Title_lbl;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
    }
}