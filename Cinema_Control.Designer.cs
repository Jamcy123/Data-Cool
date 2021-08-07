using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class Cinema_Control : Smobiler.Core.Controls.MobileUserControl
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
            this.Cname_lbl = new Smobiler.Core.Controls.Label();
            this.Caddress_lbl = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Cname_lbl,
            this.Caddress_lbl});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(111, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // Cname_lbl
            // 
            this.Cname_lbl.Bold = true;
            this.Cname_lbl.DataMember = "Cno";
            this.Cname_lbl.DisplayMember = "Cname";
            this.Cname_lbl.FontSize = 15F;
            this.Cname_lbl.Location = new System.Drawing.Point(14, 7);
            this.Cname_lbl.Name = "Cname_lbl";
            this.Cname_lbl.Selectable = true;
            this.Cname_lbl.Size = new System.Drawing.Size(193, 26);
            this.Cname_lbl.Text = "Cname_lbl";
            // 
            // Caddress_lbl
            // 
            this.Caddress_lbl.DisplayMember = "Caddress";
            this.Caddress_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.Caddress_lbl.Location = new System.Drawing.Point(14, 39);
            this.Caddress_lbl.Name = "Caddress_lbl";
            this.Caddress_lbl.Selectable = true;
            this.Caddress_lbl.Size = new System.Drawing.Size(238, 23);
            this.Caddress_lbl.Text = "Caddress_lbl";
            // 
            // Cinema_Control
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 70);
            this.Name = "Cinema_Control";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label Cname_lbl;
        private Smobiler.Core.Controls.Label Caddress_lbl;
    }
}