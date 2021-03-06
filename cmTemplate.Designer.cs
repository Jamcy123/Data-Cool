using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class cmTemplate : Smobiler.Core.Controls.MobileUserControl
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
            this.Ptime_lbl = new Smobiler.Core.Controls.Label();
            this.shichang_lbl = new Smobiler.Core.Controls.Label();
            this.Mduration_lbl = new Smobiler.Core.Controls.Label();
            this.Mtype_lbl = new Smobiler.Core.Controls.Label();
            this.Phall_lbl = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.Pprice_lbl = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Ptime_lbl,
            this.shichang_lbl,
            this.Mduration_lbl,
            this.Mtype_lbl,
            this.Phall_lbl,
            this.label2,
            this.Pprice_lbl,
            this.button1,
            this.label1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // Ptime_lbl
            // 
            this.Ptime_lbl.Bold = true;
            this.Ptime_lbl.DataMember = "Cno";
            this.Ptime_lbl.DisplayMember = "TIME";
            this.Ptime_lbl.FontSize = 18F;
            this.Ptime_lbl.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Ptime_lbl.Name = "Ptime_lbl";
            this.Ptime_lbl.Size = new System.Drawing.Size(84, 28);
            // 
            // shichang_lbl
            // 
            this.shichang_lbl.DataMember = "Ptime";
            this.shichang_lbl.Location = new System.Drawing.Point(10, 28);
            this.shichang_lbl.Name = "shichang_lbl";
            this.shichang_lbl.Size = new System.Drawing.Size(29, 20);
            this.shichang_lbl.Text = "时长:";
            // 
            // Mduration_lbl
            // 
            this.Mduration_lbl.DataMember = "Mname";
            this.Mduration_lbl.DisplayMember = "Mduration";
            this.Mduration_lbl.Location = new System.Drawing.Point(39, 28);
            this.Mduration_lbl.Name = "Mduration_lbl";
            this.Mduration_lbl.Size = new System.Drawing.Size(50, 20);
            this.Mduration_lbl.Text = "label2";
            // 
            // Mtype_lbl
            // 
            this.Mtype_lbl.DataMember = "Mno";
            this.Mtype_lbl.DisplayMember = "Mtype";
            this.Mtype_lbl.FontSize = 14F;
            this.Mtype_lbl.Location = new System.Drawing.Point(101, 0);
            this.Mtype_lbl.Name = "Mtype_lbl";
            this.Mtype_lbl.Size = new System.Drawing.Size(97, 30);
            this.Mtype_lbl.Text = "label2";
            // 
            // Phall_lbl
            // 
            this.Phall_lbl.DataMember = "Cname";
            this.Phall_lbl.DisplayMember = "Phall";
            this.Phall_lbl.FontSize = 14F;
            this.Phall_lbl.Location = new System.Drawing.Point(101, 28);
            this.Phall_lbl.Name = "Phall_lbl";
            this.Phall_lbl.Size = new System.Drawing.Size(8, 20);
            this.Phall_lbl.Text = "label2";
            // 
            // label2
            // 
            this.label2.Bold = true;
            this.label2.FontSize = 18F;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(198, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.Text = "¥";
            // 
            // Pprice_lbl
            // 
            this.Pprice_lbl.Bold = true;
            this.Pprice_lbl.DisplayMember = "Pprice";
            this.Pprice_lbl.FontSize = 16F;
            this.Pprice_lbl.ForeColor = System.Drawing.Color.Red;
            this.Pprice_lbl.Location = new System.Drawing.Point(213, 14);
            this.Pprice_lbl.Name = "Pprice_lbl";
            this.Pprice_lbl.Size = new System.Drawing.Size(30, 23);
            this.Pprice_lbl.Text = "label3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.button1.Bold = true;
            this.button1.BorderColor = System.Drawing.Color.White;
            this.button1.BorderRadius = 20;
            this.button1.FontSize = 15F;
            this.button1.Location = new System.Drawing.Point(250, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.Text = "购票";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(109, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.Text = "号厅";
            // 
            // cmTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 50);
            this.Load += new System.EventHandler(this.cmTemplate_Load);
            this.Name = "cmTemplate";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label Ptime_lbl;
        private Smobiler.Core.Controls.Label shichang_lbl;
        private Smobiler.Core.Controls.Label Mduration_lbl;
        private Smobiler.Core.Controls.Label Mtype_lbl;
        private Smobiler.Core.Controls.Label Phall_lbl;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label Pprice_lbl;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Label label1;
    }
}