using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class mcTemplate : Smobiler.Core.Controls.MobileUserControl
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
            this.Caddress_lbl = new Smobiler.Core.Controls.Label();
            this.Cname_lbl = new Smobiler.Core.Controls.Label();
            this.Pprice_lbl = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.date_lbl = new Smobiler.Core.Controls.Label();
            this.Ptime_lbl = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Caddress_lbl,
            this.Cname_lbl,
            this.Pprice_lbl,
            this.label1,
            this.label2,
            this.date_lbl,
            this.Ptime_lbl});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 70);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // Caddress_lbl
            // 
            this.Caddress_lbl.DisplayMember = "Caddress";
            this.Caddress_lbl.Location = new System.Drawing.Point(10, 27);
            this.Caddress_lbl.Name = "Caddress_lbl";
            this.Caddress_lbl.Size = new System.Drawing.Size(290, 15);
            this.Caddress_lbl.Text = "label3";
            // 
            // Cname_lbl
            // 
            this.Cname_lbl.Bold = true;
            this.Cname_lbl.DataMember = "Cno";
            this.Cname_lbl.DisplayMember = "Cname";
            this.Cname_lbl.FontSize = 16F;
            this.Cname_lbl.Location = new System.Drawing.Point(10, 0);
            this.Cname_lbl.Name = "Cname_lbl";
            this.Cname_lbl.Size = new System.Drawing.Size(156, 20);
            this.Cname_lbl.Text = "label1";
            // 
            // Pprice_lbl
            // 
            this.Pprice_lbl.Bold = true;
            this.Pprice_lbl.DataMember = "Mno";
            this.Pprice_lbl.DisplayMember = "Pprice";
            this.Pprice_lbl.ForeColor = System.Drawing.Color.Red;
            this.Pprice_lbl.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Pprice_lbl.Location = new System.Drawing.Point(222, 0);
            this.Pprice_lbl.Name = "Pprice_lbl";
            this.Pprice_lbl.Size = new System.Drawing.Size(40, 20);
            this.Pprice_lbl.Text = "label2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(262, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.Text = "元起";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.Text = "场次：";
            // 
            // date_lbl
            // 
            this.date_lbl.BackColor = System.Drawing.Color.Red;
            this.date_lbl.DisplayMember = "select_date";
            this.date_lbl.Location = new System.Drawing.Point(269, 48);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(44, 15);
            this.date_lbl.Visible = false;
            // 
            // Ptime_lbl
            // 
            this.Ptime_lbl.Location = new System.Drawing.Point(40, 48);
            this.Ptime_lbl.Name = "Ptime_lbl";
            this.Ptime_lbl.Size = new System.Drawing.Size(216, 15);
            this.Ptime_lbl.Text = "label3";
            // 
            // mcTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 70);
            this.Load += new System.EventHandler(this.mcTemplate_Load);
            this.Name = "mcTemplate";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label Caddress_lbl;
        private Smobiler.Core.Controls.Label Cname_lbl;
        private Smobiler.Core.Controls.Label Pprice_lbl;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label date_lbl;
        private Smobiler.Core.Controls.Label Ptime_lbl;
    }
}