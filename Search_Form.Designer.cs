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
            this.label3 = new Smobiler.Core.Controls.Label();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.movie_checkBox = new Smobiler.Core.Controls.CheckBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.title_Control1 = new SmobilerAppTEST7._17.Title_Control();
            this.searchBox_Control1 = new SmobilerAppTEST7._17.SearchBox_Control();
            this.cinema_checkBox = new Smobiler.Core.Controls.CheckBox();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.searchBox_Control1,
            this.panel2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(149, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(78, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.movie_checkBox,
            this.label1,
            this.cinema_checkBox,
            this.label2});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 38);
            // 
            // movie_checkBox
            // 
            this.movie_checkBox.Location = new System.Drawing.Point(30, 5);
            this.movie_checkBox.Name = "movie_checkBox";
            this.movie_checkBox.Size = new System.Drawing.Size(22, 22);
            this.movie_checkBox.TintColor = System.Drawing.Color.DeepSkyBlue;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(54, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.Text = "查询电影";
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
            this.searchBox_Control1.BackColor = System.Drawing.Color.White;
            this.searchBox_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBox_Control1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.searchBox_Control1.Location = new System.Drawing.Point(0, 98);
            this.searchBox_Control1.Name = "searchBox_Control1";
            this.searchBox_Control1.Size = new System.Drawing.Size(300, 40);
            this.searchBox_Control1.TextBox_Text = "";
            this.searchBox_Control1.SearchButtonPress += new System.EventHandler(this.searchBox_Control1_SearchButtonPress);
            // 
            // cinema_checkBox
            // 
            this.cinema_checkBox.Location = new System.Drawing.Point(167, 5);
            this.cinema_checkBox.Name = "cinema_checkBox";
            this.cinema_checkBox.Size = new System.Drawing.Size(22, 22);
            this.cinema_checkBox.TintColor = System.Drawing.Color.DeepSkyBlue;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(189, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.Text = "查询影院";
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
        private Smobiler.Core.Controls.Label label3;
        private SearchBox_Control searchBox_Control1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.CheckBox movie_checkBox;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.CheckBox cinema_checkBox;
        private Smobiler.Core.Controls.Label label2;
    }
}