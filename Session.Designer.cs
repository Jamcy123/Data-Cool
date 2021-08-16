using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class Session : Smobiler.Core.Controls.MobileUserControl
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
            this.time = new Smobiler.Core.Controls.Label();
            this.getlanguage = new Smobiler.Core.Controls.Label();
            this.hall = new Smobiler.Core.Controls.Label();
            this.price = new Smobiler.Core.Controls.Label();
            this.finish = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.time,
            this.getlanguage,
            this.hall,
            this.price,
            this.finish,
            this.button1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(136, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // time
            // 
            this.time.DisplayMember = "Ptime";
            this.time.FontSize = 16F;
            this.time.Location = new System.Drawing.Point(0, 19);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(65, 35);
            this.time.Text = "label1";
            // 
            // getlanguage
            // 
            this.getlanguage.Location = new System.Drawing.Point(75, 19);
            this.getlanguage.Name = "getlanguage";
            this.getlanguage.Size = new System.Drawing.Size(77, 35);
            this.getlanguage.Text = "label2";
            // 
            // hall
            // 
            this.hall.DisplayMember = "Phall";
            this.hall.FontSize = 10F;
            this.hall.ForeColor = System.Drawing.Color.DimGray;
            this.hall.Location = new System.Drawing.Point(75, 54);
            this.hall.Name = "hall";
            this.hall.Size = new System.Drawing.Size(77, 23);
            this.hall.Text = "label3";
            // 
            // price
            // 
            this.price.DisplayMember = "Pprice";
            this.price.FontSize = 16F;
            this.price.ForeColor = System.Drawing.Color.Red;
            this.price.Location = new System.Drawing.Point(164, 30);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(69, 41);
            this.price.Text = "￥31.9";
            // 
            // finish
            // 
            this.finish.FontSize = 10F;
            this.finish.ForeColor = System.Drawing.Color.DimGray;
            this.finish.Location = new System.Drawing.Point(0, 54);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(65, 23);
            this.finish.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 34);
            this.button1.Text = "删除";
            // 
            // Session
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 100);
            this.Name = "Session";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label time;
        private Smobiler.Core.Controls.Label getlanguage;
        private Smobiler.Core.Controls.Label hall;
        private Smobiler.Core.Controls.Label price;
        private Smobiler.Core.Controls.Label finish;
        private Smobiler.Core.Controls.Button button1;
    }
}