using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class BuyBtn_Control : Smobiler.Core.Controls.MobileUserControl
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
            this.sure_panel = new Smobiler.Core.Controls.Panel();
            this.sure_lbl = new Smobiler.Core.Controls.Label();
            this.touch_panel = new Smobiler.Core.Controls.Panel();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.sure_panel,
            this.touch_panel});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // sure_panel
            // 
            this.sure_panel.BackColor = System.Drawing.Color.MistyRose;
            this.sure_panel.BorderRadius = 30;
            this.sure_panel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.sure_lbl});
            this.sure_panel.Location = new System.Drawing.Point(25, 5);
            this.sure_panel.Name = "sure_panel";
            this.sure_panel.Size = new System.Drawing.Size(250, 45);
            this.sure_panel.Touchable = true;
            this.sure_panel.Press += new System.EventHandler(this.sure_panel_Press);
            // 
            // sure_lbl
            // 
            this.sure_lbl.BorderColor = System.Drawing.Color.Transparent;
            this.sure_lbl.FontSize = 18F;
            this.sure_lbl.ForeColor = System.Drawing.Color.White;
            this.sure_lbl.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.sure_lbl.Name = "sure_lbl";
            this.sure_lbl.Size = new System.Drawing.Size(250, 45);
            this.sure_lbl.Text = "请先选座";
            // 
            // touch_panel
            // 
            this.touch_panel.Location = new System.Drawing.Point(25, 5);
            this.touch_panel.Name = "touch_panel";
            this.touch_panel.Size = new System.Drawing.Size(250, 45);
            // 
            // BuyBtn_Control
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 55);
            this.Name = "BuyBtn_Control";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel sure_panel;
        private Smobiler.Core.Controls.Label sure_lbl;
        private Smobiler.Core.Controls.Panel touch_panel;
    }
}