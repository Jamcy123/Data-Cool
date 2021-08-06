using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class SearchBox_Control : Smobiler.Core.Controls.MobileUserControl
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
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderRadius = 40;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.textBox1,
            this.panel2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 40);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 28);
            this.textBox1.WaterMarkText = "输入查询内容";
            this.textBox1.SubmitEditing += new System.EventHandler(this.textBox1_SubmitEditing);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1});
            this.panel2.Location = new System.Drawing.Point(254, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 28);
            this.panel2.Touchable = true;
            this.panel2.Press += new System.EventHandler(this.panel2_Press);
            // 
            // fontIcon1
            // 
            this.fontIcon1.BorderColor = System.Drawing.Color.Transparent;
            this.fontIcon1.ForeColor = System.Drawing.Color.DimGray;
            this.fontIcon1.Location = new System.Drawing.Point(3, 3);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(23, 23);
            // 
            // SearchBox_Control
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(300, 40);
            this.Name = "SearchBox_Control";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
    }
}