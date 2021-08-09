using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class ccTemplate : Smobiler.Core.Controls.MobileUserControl
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
            this.Mpicadress_image = new Smobiler.Core.Controls.Image();
            this.Mname_lbl = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.Mgrade_lbl = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.Mtype_lbl = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.Mlanguage_lbl = new Smobiler.Core.Controls.Label();
            this.goupiao_button = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Mpicadress_image,
            this.Mname_lbl,
            this.label2,
            this.Mgrade_lbl,
            this.label3,
            this.Mtype_lbl,
            this.label1,
            this.Mlanguage_lbl,
            this.goupiao_button});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 80);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // Mpicadress_image
            // 
            this.Mpicadress_image.BorderRadius = 7;
            this.Mpicadress_image.DisplayMember = "Mpicadress";
            this.Mpicadress_image.Location = new System.Drawing.Point(14, 8);
            this.Mpicadress_image.Name = "Mpicadress_image";
            this.Mpicadress_image.ResourceID = global::SmobilerAppTEST7._17.Properties.Settings.Default.Mpicadress;
            this.Mpicadress_image.Size = new System.Drawing.Size(60, 60);
            // 
            // Mname_lbl
            // 
            this.Mname_lbl.Bold = true;
            this.Mname_lbl.DataMember = "Mno";
            this.Mname_lbl.DisplayMember = "Mname";
            this.Mname_lbl.FontSize = 15F;
            this.Mname_lbl.Location = new System.Drawing.Point(81, 8);
            this.Mname_lbl.Name = "Mname_lbl";
            this.Mname_lbl.Size = new System.Drawing.Size(148, 26);
            this.Mname_lbl.Text = "label1";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(81, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.Text = "电影评分";
            // 
            // Mgrade_lbl
            // 
            this.Mgrade_lbl.DisplayMember = "Mgrade";
            this.Mgrade_lbl.FontSize = 14F;
            this.Mgrade_lbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.Mgrade_lbl.Location = new System.Drawing.Point(153, 34);
            this.Mgrade_lbl.Name = "Mgrade_lbl";
            this.Mgrade_lbl.Size = new System.Drawing.Size(60, 15);
            this.Mgrade_lbl.Text = "label4";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(81, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.Text = "电影类型";
            // 
            // Mtype_lbl
            // 
            this.Mtype_lbl.DisplayMember = "Mtype";
            this.Mtype_lbl.Location = new System.Drawing.Point(153, 53);
            this.Mtype_lbl.Name = "Mtype_lbl";
            this.Mtype_lbl.Size = new System.Drawing.Size(60, 15);
            this.Mtype_lbl.Text = "label5";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(132, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.Text = "电影语言";
            // 
            // Mlanguage_lbl
            // 
            this.Mlanguage_lbl.DisplayMember = "Mlanguage";
            this.Mlanguage_lbl.Location = new System.Drawing.Point(204, 101);
            this.Mlanguage_lbl.Name = "Mlanguage_lbl";
            this.Mlanguage_lbl.Size = new System.Drawing.Size(76, 17);
            this.Mlanguage_lbl.Text = "label5";
            // 
            // goupiao_button
            // 
            this.goupiao_button.BackColor = System.Drawing.Color.Red;
            this.goupiao_button.Bold = true;
            this.goupiao_button.FontSize = 15F;
            this.goupiao_button.ForeColor = System.Drawing.Color.Black;
            this.goupiao_button.Location = new System.Drawing.Point(243, 19);
            this.goupiao_button.Name = "goupiao_button";
            this.goupiao_button.Size = new System.Drawing.Size(50, 30);
            this.goupiao_button.Text = "购票";
            this.goupiao_button.Press += new System.EventHandler(this.goupiao_button_Press);
            // 
            // ccTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 80);
            this.Load += new System.EventHandler(this.ccTemplate_Load);
            this.Name = "ccTemplate";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image Mpicadress_image;
        private Smobiler.Core.Controls.Label Mname_lbl;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label Mgrade_lbl;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label Mtype_lbl;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label Mlanguage_lbl;
        private Smobiler.Core.Controls.Button goupiao_button;
    }
}