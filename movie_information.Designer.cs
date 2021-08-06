using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class movie_information : Smobiler.Core.Controls.MobileForm
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
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(21, 12);
            this.image1.Name = "image1";
            this.image1.ResourceID = "shengxia.png";
            this.image1.Size = new System.Drawing.Size(116, 143);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(160, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 35);
            this.button1.Text = "想看";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 35);
            this.button2.Text = "看过";
            // 
            // label2
            // 
            this.label2.DisplayMember = "Mgrade";
            this.label2.Location = new System.Drawing.Point(160, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "电影评分";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 35);
            this.button3.Text = "特惠购票";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // label3
            // 
            this.label3.DisplayMember = "Mdetail";
            this.label3.Location = new System.Drawing.Point(15, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 150);
            this.label3.Text = "即将高考的陈辰（张子枫 饰）因发现妈妈（郝蕾 饰）与王叔叔（祖峰 饰）的“外遇”而心情低落，却在这时与校园网红郑宇星（吴磊 饰）因为一个谎言意外相识。两人在未解的" +
    "青春里，携手面对成长的种种难题，勇敢地面对真实的自己，亦在这个夏天过去后，见证了彼此的成长和蜕变......";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 48);
            this.label4.Text = "演职员表";
            // 
            // movie_information
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1,
            this.button1,
            this.button2,
            this.label2,
            this.button3,
            this.label3,
            this.label4});
            this.Name = "movie_information";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Button button3;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
    }
}