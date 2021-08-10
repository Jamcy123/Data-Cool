using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class Seat_Control : Smobiler.Core.Controls.MobileUserControl
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
            this.seat_panel = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.stop_panel = new Smobiler.Core.Controls.Panel();
            // 
            // seat_panel
            // 
            this.seat_panel.BackColor = System.Drawing.Color.White;
            this.seat_panel.Border = new Smobiler.Core.Controls.Border(1F);
            this.seat_panel.BorderColor = System.Drawing.Color.LightGray;
            this.seat_panel.BorderRadius = 3;
            this.seat_panel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1});
            this.seat_panel.Location = new System.Drawing.Point(4, 4);
            this.seat_panel.Name = "seat_panel";
            this.seat_panel.Size = new System.Drawing.Size(22, 22);
            this.seat_panel.Touchable = true;
            this.seat_panel.Press += new System.EventHandler(this.panel1_Press);
            // 
            // fontIcon1
            // 
            this.fontIcon1.BackColor = System.Drawing.Color.LimeGreen;
            this.fontIcon1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fontIcon1.Location = new System.Drawing.Point(3, 3);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "check";
            this.fontIcon1.Size = new System.Drawing.Size(15, 15);
            this.fontIcon1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.seat_panel,
            this.stop_panel});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 30);
            // 
            // stop_panel
            // 
            this.stop_panel.Location = new System.Drawing.Point(4, 4);
            this.stop_panel.Name = "stop_panel";
            this.stop_panel.Size = new System.Drawing.Size(22, 22);
            this.stop_panel.Visible = false;
            // 
            // Seat_Control
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.Size = new System.Drawing.Size(30, 30);
            this.Name = "Seat_Control";

        }
        #endregion

        private Smobiler.Core.Controls.Panel seat_panel;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Panel stop_panel;
    }
}