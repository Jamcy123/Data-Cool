using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class DControl : Smobiler.Core.Controls.MobileUserControl
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
            this.image1 = new Smobiler.Core.Controls.Image();
            this.Mname_lbl = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.Mgrade_lbl = new Smobiler.Core.Controls.Label();
            this.Mtype_lbl = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.Mlanguage_lbl = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
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
            this.Mtype_lbl,
            this.label1,
            this.Mlanguage_lbl,
            this.button1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(111, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // image1
            // 
            this.image1.BorderRadius = 7;
            this.image1.DisplayMember = "Mpicadress";
            this.image1.Location = new System.Drawing.Point(8, 9);
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
            this.Mname_lbl.Location = new System.Drawing.Point(94, 5);
            this.Mname_lbl.Name = "Mname_lbl";
            this.Mname_lbl.Size = new System.Drawing.Size(148, 26);
            this.Mname_lbl.Text = "label1";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(94, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.Text = "电影评分";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(94, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.Text = "电影类型";
            // 
            // Mgrade_lbl
            // 
            this.Mgrade_lbl.DisplayMember = "Mgrade";
            this.Mgrade_lbl.FontSize = 14F;
            this.Mgrade_lbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.Mgrade_lbl.Location = new System.Drawing.Point(166, 34);
            this.Mgrade_lbl.Name = "Mgrade_lbl";
            this.Mgrade_lbl.Size = new System.Drawing.Size(50, 17);
            this.Mgrade_lbl.Text = "label4";
            // 
            // Mtype_lbl
            // 
            this.Mtype_lbl.DisplayMember = "Mtype";
            this.Mtype_lbl.Location = new System.Drawing.Point(166, 51);
            this.Mtype_lbl.Name = "Mtype_lbl";
            this.Mtype_lbl.Size = new System.Drawing.Size(76, 26);
            this.Mtype_lbl.Text = "label5";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(94, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.Text = "电影语言";
            // 
            // Mlanguage_lbl
            // 
            this.Mlanguage_lbl.DisplayMember = "Mlanguage";
            this.Mlanguage_lbl.Location = new System.Drawing.Point(166, 77);
            this.Mlanguage_lbl.Name = "Mlanguage_lbl";
            this.Mlanguage_lbl.Size = new System.Drawing.Size(76, 17);
            this.Mlanguage_lbl.Text = "label5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.BorderRadius = 15;
            this.button1.FontSize = 15F;
            this.button1.Location = new System.Drawing.Point(242, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 22);
            this.button1.Text = "下架";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // DControl
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 100);
            this.Name = "DControl";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label Mname_lbl;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label Mgrade_lbl;
        private Smobiler.Core.Controls.Label Mtype_lbl;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label Mlanguage_lbl;
        private Smobiler.Core.Controls.Button button1;
    }
}