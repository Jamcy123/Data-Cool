﻿using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class SaleControl : Smobiler.Core.Controls.MobileUserControl
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
            this.getCno = new Smobiler.Core.Controls.Label();
            this.getMno = new Smobiler.Core.Controls.Label();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.Mname_lbl = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.Mgrade_lbl = new Smobiler.Core.Controls.Label();
            this.All_lbl = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.sale_lbl = new Smobiler.Core.Controls.Label();
            // 
            // getCno
            // 
            this.getCno.Location = new System.Drawing.Point(38, 28);
            this.getCno.Name = "getCno";
            this.getCno.Size = new System.Drawing.Size(100, 35);
            this.getCno.Text = "label1";
            this.getCno.Visible = false;
            // 
            // getMno
            // 
            this.getMno.DisplayMember = "Mno";
            this.getMno.Location = new System.Drawing.Point(151, 28);
            this.getMno.Name = "getMno";
            this.getMno.Size = new System.Drawing.Size(100, 35);
            this.getMno.Text = "label1";
            this.getMno.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.Mname_lbl,
            this.label2,
            this.label3,
            this.Mgrade_lbl,
            this.All_lbl,
            this.label1,
            this.sale_lbl});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(111, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            this.panel1.Touchable = true;
            // 
            // image1
            // 
            this.image1.BorderRadius = 7;
            this.image1.DisplayMember = "Mpicadress";
            this.image1.Location = new System.Drawing.Point(19, 7);
            this.image1.Name = "image1";
            this.image1.ResourceID = global::SmobilerAppTEST7._17.Properties.Settings.Default.Mpicadress;
            this.image1.Size = new System.Drawing.Size(70, 82);
            // 
            // Mname_lbl
            // 
            this.Mname_lbl.Bold = true;
            this.Mname_lbl.DataMember = "Mno";
            this.Mname_lbl.DisplayMember = "Mname";
            this.Mname_lbl.FontSize = 17F;
            this.Mname_lbl.Location = new System.Drawing.Point(116, 0);
            this.Mname_lbl.Name = "Mname_lbl";
            this.Mname_lbl.Size = new System.Drawing.Size(148, 26);
            this.Mname_lbl.Text = "label1";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(116, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.Text = "电影评分";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(116, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.Text = "总票数";
            // 
            // Mgrade_lbl
            // 
            this.Mgrade_lbl.DisplayMember = "Mgrade";
            this.Mgrade_lbl.FontSize = 14F;
            this.Mgrade_lbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.Mgrade_lbl.Location = new System.Drawing.Point(188, 29);
            this.Mgrade_lbl.Name = "Mgrade_lbl";
            this.Mgrade_lbl.Size = new System.Drawing.Size(50, 17);
            this.Mgrade_lbl.Text = "label4";
            // 
            // All_lbl
            // 
            this.All_lbl.DisplayMember = "Total";
            this.All_lbl.Location = new System.Drawing.Point(188, 51);
            this.All_lbl.Name = "All_lbl";
            this.All_lbl.Size = new System.Drawing.Size(76, 17);
            this.All_lbl.Text = "label5";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(116, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.Text = "售出票数";
            // 
            // sale_lbl
            // 
            this.sale_lbl.DisplayMember = "Amount";
            this.sale_lbl.Location = new System.Drawing.Point(188, 72);
            this.sale_lbl.Name = "sale_lbl";
            this.sale_lbl.Size = new System.Drawing.Size(76, 17);
            this.sale_lbl.Text = "label5";
            // 
            // SaleControl
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.getCno,
            this.getMno,
            this.panel1});
            this.Size = new System.Drawing.Size(300, 100);
            this.Name = "SaleControl";

        }
        #endregion

        private Smobiler.Core.Controls.Label getCno;
        private Smobiler.Core.Controls.Label getMno;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label Mname_lbl;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label Mgrade_lbl;
        private Smobiler.Core.Controls.Label All_lbl;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label sale_lbl;
    }
}