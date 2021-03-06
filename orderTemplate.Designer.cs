using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class orderTemplate : Smobiler.Core.Controls.MobileUserControl
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.label9});
            this.panel1.Location = new System.Drawing.Point(0, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // image1
            // 
            this.image1.DisplayMember = "Mpicadress";
            this.image1.Location = new System.Drawing.Point(10, 5);
            this.image1.Name = "image1";
            this.image1.ResourceID = "1";
            this.image1.Size = new System.Drawing.Size(40, 43);
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.DataMember = "Mno";
            this.label1.DisplayMember = "Mname";
            this.label1.FontSize = 16F;
            this.label1.Location = new System.Drawing.Point(73, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Bold = true;
            this.label2.DataMember = "Mduration";
            this.label2.DisplayMember = "Ptime";
            this.label2.FontSize = 11F;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(73, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 10);
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.DisplayMember = "Phall";
            this.label3.FontSize = 11F;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(73, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 10);
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 35);
            this.label4.Text = "label4";
            // 
            // label9
            // 
            this.label9.DisplayMember = "Pposition";
            this.label9.FontSize = 11F;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(150, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 10);
            this.label9.Text = "label9";
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label6});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 20);
            this.panel2.Touchable = true;
            this.panel2.Press += new System.EventHandler(this.panel2_Press);
            // 
            // label6
            // 
            this.label6.DataMember = "Cno";
            this.label6.DisplayMember = "Cname";
            this.label6.FontSize = 12F;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.Text = "label6";
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.label8});
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 20);
            // 
            // label5
            // 
            this.label5.FontSize = 10F;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(11, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.Text = "票价：";
            // 
            // label8
            // 
            this.label8.DisplayMember = "Pprice";
            this.label8.FontSize = 10F;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(37, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 22);
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.FontSize = 12F;
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(251, 0);
            this.label7.Name = "label7";
            this.label7.Selectable = true;
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.Text = "label7";
            // 
            // orderTemplate
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.label7});
            this.Size = new System.Drawing.Size(300, 90);
            this.Load += new System.EventHandler(this.orderTemplate_Load);
            this.Name = "orderTemplate";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.Label label7;
    }
}