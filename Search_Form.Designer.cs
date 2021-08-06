using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class Search_Form : Smobiler.Core.Controls.MobileForm
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
            this.title_Control1 = new SmobilerAppTEST7._17.Title_Control();
            this.searchBox_Control1 = new SmobilerAppTEST7._17.SearchBox_Control();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.checkBox2 = new Smobiler.Core.Controls.CheckBox();
            this.checkBox1 = new Smobiler.Core.Controls.CheckBox();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.searchBox_Control1,
            this.panel2,
            this.listView1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(149, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // title_Control1
            // 
            this.title_Control1.BackColor = System.Drawing.Color.Gray;
            this.title_Control1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Control1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.title_Control1.Location = new System.Drawing.Point(53, 59);
            this.title_Control1.Name = "title_Control1";
            this.title_Control1.Size = new System.Drawing.Size(100, 36);
            this.title_Control1.Text = "搜索";
            this.title_Control1.ExitButtonpPress += new System.EventHandler(this.title_Control1_ExitButtonpPress_1);
            // 
            // searchBox_Control1
            // 
            this.searchBox_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBox_Control1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.searchBox_Control1.Location = new System.Drawing.Point(0, 103);
            this.searchBox_Control1.Name = "searchBox_Control1";
            this.searchBox_Control1.Size = new System.Drawing.Size(300, 40);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.checkBox2,
            this.checkBox1,
            this.label1,
            this.label2});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 42);
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(170, 8);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(22, 22);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(30, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 22);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(23, 208);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(300, 300);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(54, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(195, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.Text = "label1";
            // 
            // Search_Form
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title_Control1,
            this.panel1});
            this.Name = "Search_Form";

        }
        #endregion

        private Title_Control title_Control1;
        private Smobiler.Core.Controls.Panel panel1;
        private SearchBox_Control searchBox_Control1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.CheckBox checkBox2;
        private Smobiler.Core.Controls.CheckBox checkBox1;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
    }
}