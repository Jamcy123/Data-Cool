using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class cinema_confirm : Smobiler.Core.Controls.MobileForm
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.Cname_lbl = new Smobiler.Core.Controls.Label();
            this.Caddress_lbl = new Smobiler.Core.Controls.Label();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl1 = new Smobiler.Core.Controls.TabPageControl();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Cname_lbl,
            this.Caddress_lbl});
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 76);
            // 
            // Cname_lbl
            // 
            this.Cname_lbl.Bold = true;
            this.Cname_lbl.FontSize = 18F;
            this.Cname_lbl.Location = new System.Drawing.Point(0, 1);
            this.Cname_lbl.Name = "Cname_lbl";
            this.Cname_lbl.Size = new System.Drawing.Size(100, 35);
            this.Cname_lbl.Text = "label1";
            // 
            // Caddress_lbl
            // 
            this.Caddress_lbl.Location = new System.Drawing.Point(0, 36);
            this.Caddress_lbl.Name = "Caddress_lbl";
            this.Caddress_lbl.Size = new System.Drawing.Size(100, 35);
            this.Caddress_lbl.Text = "label1";
            // 
            // tabPageView1
            // 
            this.tabPageView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageControl1});
            this.tabPageView1.Location = new System.Drawing.Point(0, 159);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.Size = new System.Drawing.Size(300, 300);
            // 
            // tabPageControl1
            // 
            this.tabPageControl1.Name = "tabPageControl1";
            // 
            // cinema_confirm
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.tabPageView1});
            this.Load += new System.EventHandler(this.cinema_confirm_Load);
            this.Name = "cinema_confirm";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label Cname_lbl;
        private Smobiler.Core.Controls.Label Caddress_lbl;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl1;
    }
}