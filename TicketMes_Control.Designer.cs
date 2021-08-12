using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class TicketMes_Control : Smobiler.Core.Controls.MobileUserControl
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
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.Mname_lbl = new Smobiler.Core.Controls.Label();
            this.Week_lbl = new Smobiler.Core.Controls.Label();
            this.Dtime_lbl = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.tikMes_Pan1 = new Smobiler.Core.Controls.Panel();
            this.seat_Text1 = new Smobiler.Core.Controls.Label();
            this.money_Text1 = new Smobiler.Core.Controls.Label();
            this.delete_btn1 = new Smobiler.Core.Controls.ImageButton();
            this.tikMes_Pan2 = new Smobiler.Core.Controls.Panel();
            this.seat_Text2 = new Smobiler.Core.Controls.Label();
            this.money_Text2 = new Smobiler.Core.Controls.Label();
            this.delete_btn2 = new Smobiler.Core.Controls.ImageButton();
            this.tikMes_Pan3 = new Smobiler.Core.Controls.Panel();
            this.seat_Text3 = new Smobiler.Core.Controls.Label();
            this.money_Text3 = new Smobiler.Core.Controls.Label();
            this.delete_btn3 = new Smobiler.Core.Controls.ImageButton();
            this.tikMes_Pan4 = new Smobiler.Core.Controls.Panel();
            this.seat_Text4 = new Smobiler.Core.Controls.Label();
            this.money_Text4 = new Smobiler.Core.Controls.Label();
            this.delete_btn4 = new Smobiler.Core.Controls.ImageButton();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.panel3});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(72, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderRadius = 20;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Mname_lbl,
            this.Week_lbl,
            this.Dtime_lbl,
            this.line1,
            this.tikMes_Pan1,
            this.tikMes_Pan2,
            this.tikMes_Pan3,
            this.tikMes_Pan4});
            this.panel2.Location = new System.Drawing.Point(15, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 150);
            // 
            // Mname_lbl
            // 
            this.Mname_lbl.Bold = true;
            this.Mname_lbl.FontSize = 21F;
            this.Mname_lbl.Location = new System.Drawing.Point(19, 6);
            this.Mname_lbl.Name = "Mname_lbl";
            this.Mname_lbl.Size = new System.Drawing.Size(227, 31);
            this.Mname_lbl.Text = "是电影是电影";
            // 
            // Week_lbl
            // 
            this.Week_lbl.BorderColor = System.Drawing.Color.DimGray;
            this.Week_lbl.FontSize = 16F;
            this.Week_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.Week_lbl.Location = new System.Drawing.Point(19, 41);
            this.Week_lbl.Name = "Week_lbl";
            this.Week_lbl.Size = new System.Drawing.Size(37, 19);
            this.Week_lbl.Text = "周几";
            // 
            // Dtime_lbl
            // 
            this.Dtime_lbl.FontSize = 15F;
            this.Dtime_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.Dtime_lbl.Location = new System.Drawing.Point(51, 41);
            this.Dtime_lbl.Name = "Dtime_lbl";
            this.Dtime_lbl.Size = new System.Drawing.Size(190, 19);
            this.Dtime_lbl.Text = "某月某日 00:00-00:00";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Gainsboro;
            this.line1.BorderColor = System.Drawing.Color.Gainsboro;
            this.line1.Location = new System.Drawing.Point(10, 66);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(250, 1);
            // 
            // tikMes_Pan1
            // 
            this.tikMes_Pan1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tikMes_Pan1.BorderRadius = 12;
            this.tikMes_Pan1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.seat_Text1,
            this.money_Text1,
            this.delete_btn1});
            this.tikMes_Pan1.Location = new System.Drawing.Point(10, 82);
            this.tikMes_Pan1.Name = "tikMes_Pan1";
            this.tikMes_Pan1.Size = new System.Drawing.Size(55, 50);
            this.tikMes_Pan1.Visible = false;
            // 
            // seat_Text1
            // 
            this.seat_Text1.FontSize = 11F;
            this.seat_Text1.ForeColor = System.Drawing.Color.DimGray;
            this.seat_Text1.Location = new System.Drawing.Point(6, 6);
            this.seat_Text1.Name = "seat_Text1";
            this.seat_Text1.Size = new System.Drawing.Size(40, 16);
            this.seat_Text1.Text = "8排8座";
            // 
            // money_Text1
            // 
            this.money_Text1.FontSize = 11F;
            this.money_Text1.ForeColor = System.Drawing.Color.DimGray;
            this.money_Text1.Location = new System.Drawing.Point(6, 27);
            this.money_Text1.Name = "money_Text1";
            this.money_Text1.Size = new System.Drawing.Size(40, 16);
            this.money_Text1.Text = "¥50";
            // 
            // delete_btn1
            // 
            this.delete_btn1.IconColor = System.Drawing.Color.DimGray;
            this.delete_btn1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.delete_btn1.ImgTextRatio = new Smobiler.Core.Controls.Ratio(1, 0);
            this.delete_btn1.Location = new System.Drawing.Point(35, 14);
            this.delete_btn1.Name = "delete_btn1";
            this.delete_btn1.ResourceID = "ios-close";
            this.delete_btn1.Size = new System.Drawing.Size(22, 22);
            this.delete_btn1.TextMember = "1";
            this.delete_btn1.Press += new System.EventHandler(this.delete_btn_Press);
            // 
            // tikMes_Pan2
            // 
            this.tikMes_Pan2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tikMes_Pan2.BorderRadius = 12;
            this.tikMes_Pan2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.seat_Text2,
            this.money_Text2,
            this.delete_btn2});
            this.tikMes_Pan2.Location = new System.Drawing.Point(75, 82);
            this.tikMes_Pan2.Name = "tikMes_Pan2";
            this.tikMes_Pan2.Size = new System.Drawing.Size(55, 50);
            this.tikMes_Pan2.Visible = false;
            // 
            // seat_Text2
            // 
            this.seat_Text2.FontSize = 11F;
            this.seat_Text2.ForeColor = System.Drawing.Color.DimGray;
            this.seat_Text2.Location = new System.Drawing.Point(6, 6);
            this.seat_Text2.Name = "seat_Text2";
            this.seat_Text2.Size = new System.Drawing.Size(40, 16);
            this.seat_Text2.Text = "8排8座";
            // 
            // money_Text2
            // 
            this.money_Text2.FontSize = 11F;
            this.money_Text2.ForeColor = System.Drawing.Color.DimGray;
            this.money_Text2.Location = new System.Drawing.Point(6, 27);
            this.money_Text2.Name = "money_Text2";
            this.money_Text2.Size = new System.Drawing.Size(40, 16);
            this.money_Text2.Text = "¥50";
            // 
            // delete_btn2
            // 
            this.delete_btn2.IconColor = System.Drawing.Color.DimGray;
            this.delete_btn2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.delete_btn2.ImgTextRatio = new Smobiler.Core.Controls.Ratio(1, 0);
            this.delete_btn2.Location = new System.Drawing.Point(35, 14);
            this.delete_btn2.Name = "delete_btn2";
            this.delete_btn2.ResourceID = "ios-close";
            this.delete_btn2.Size = new System.Drawing.Size(22, 22);
            this.delete_btn2.TextMember = "2";
            this.delete_btn2.Press += new System.EventHandler(this.delete_btn_Press);
            // 
            // tikMes_Pan3
            // 
            this.tikMes_Pan3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tikMes_Pan3.BorderRadius = 12;
            this.tikMes_Pan3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.seat_Text3,
            this.money_Text3,
            this.delete_btn3});
            this.tikMes_Pan3.Location = new System.Drawing.Point(140, 82);
            this.tikMes_Pan3.Name = "tikMes_Pan3";
            this.tikMes_Pan3.Size = new System.Drawing.Size(55, 50);
            this.tikMes_Pan3.Visible = false;
            // 
            // seat_Text3
            // 
            this.seat_Text3.FontSize = 11F;
            this.seat_Text3.ForeColor = System.Drawing.Color.DimGray;
            this.seat_Text3.Location = new System.Drawing.Point(6, 6);
            this.seat_Text3.Name = "seat_Text3";
            this.seat_Text3.Size = new System.Drawing.Size(40, 16);
            this.seat_Text3.Text = "8排8座";
            // 
            // money_Text3
            // 
            this.money_Text3.FontSize = 11F;
            this.money_Text3.ForeColor = System.Drawing.Color.DimGray;
            this.money_Text3.Location = new System.Drawing.Point(6, 27);
            this.money_Text3.Name = "money_Text3";
            this.money_Text3.Size = new System.Drawing.Size(40, 16);
            this.money_Text3.Text = "¥50";
            // 
            // delete_btn3
            // 
            this.delete_btn3.IconColor = System.Drawing.Color.DimGray;
            this.delete_btn3.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.delete_btn3.ImgTextRatio = new Smobiler.Core.Controls.Ratio(1, 0);
            this.delete_btn3.Location = new System.Drawing.Point(35, 14);
            this.delete_btn3.Name = "delete_btn3";
            this.delete_btn3.ResourceID = "ios-close";
            this.delete_btn3.Size = new System.Drawing.Size(22, 22);
            this.delete_btn3.TextMember = "3";
            this.delete_btn3.Press += new System.EventHandler(this.delete_btn_Press);
            // 
            // tikMes_Pan4
            // 
            this.tikMes_Pan4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tikMes_Pan4.BorderRadius = 12;
            this.tikMes_Pan4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.seat_Text4,
            this.money_Text4,
            this.delete_btn4});
            this.tikMes_Pan4.Location = new System.Drawing.Point(205, 82);
            this.tikMes_Pan4.Name = "tikMes_Pan4";
            this.tikMes_Pan4.Size = new System.Drawing.Size(55, 50);
            this.tikMes_Pan4.Visible = false;
            // 
            // seat_Text4
            // 
            this.seat_Text4.FontSize = 11F;
            this.seat_Text4.ForeColor = System.Drawing.Color.DimGray;
            this.seat_Text4.Location = new System.Drawing.Point(6, 6);
            this.seat_Text4.Name = "seat_Text4";
            this.seat_Text4.Size = new System.Drawing.Size(40, 16);
            this.seat_Text4.Text = "8排8座";
            // 
            // money_Text4
            // 
            this.money_Text4.FontSize = 11F;
            this.money_Text4.ForeColor = System.Drawing.Color.DimGray;
            this.money_Text4.Location = new System.Drawing.Point(6, 27);
            this.money_Text4.Name = "money_Text4";
            this.money_Text4.Size = new System.Drawing.Size(40, 16);
            this.money_Text4.Text = "¥50";
            // 
            // delete_btn4
            // 
            this.delete_btn4.IconColor = System.Drawing.Color.DimGray;
            this.delete_btn4.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.delete_btn4.ImgTextRatio = new Smobiler.Core.Controls.Ratio(1, 0);
            this.delete_btn4.Location = new System.Drawing.Point(35, 14);
            this.delete_btn4.Name = "delete_btn4";
            this.delete_btn4.ResourceID = "ios-close";
            this.delete_btn4.Size = new System.Drawing.Size(22, 22);
            this.delete_btn4.TextMember = "4";
            this.delete_btn4.Press += new System.EventHandler(this.delete_btn_Press);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel4,
            this.label4,
            this.panel5,
            this.label5});
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 25);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.LightGray;
            this.panel4.BorderRadius = 3;
            this.panel4.Location = new System.Drawing.Point(100, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 15);
            // 
            // label4
            // 
            this.label4.FontSize = 10F;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(117, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.Text = "可选";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel5.BorderColor = System.Drawing.Color.LightGray;
            this.panel5.BorderRadius = 3;
            this.panel5.Location = new System.Drawing.Point(158, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 15);
            // 
            // label5
            // 
            this.label5.FontSize = 10F;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(175, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.Text = "已售";
            // 
            // TicketMes_Control
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 184);
            this.Name = "TicketMes_Control";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label Mname_lbl;
        private Smobiler.Core.Controls.Label Week_lbl;
        private Smobiler.Core.Controls.Label Dtime_lbl;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Panel panel5;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Panel tikMes_Pan1;
        private Smobiler.Core.Controls.Label seat_Text1;
        private Smobiler.Core.Controls.Label money_Text1;
        private Smobiler.Core.Controls.ImageButton delete_btn1;
        private Smobiler.Core.Controls.Panel tikMes_Pan2;
        private Smobiler.Core.Controls.Label seat_Text2;
        private Smobiler.Core.Controls.Label money_Text2;
        private Smobiler.Core.Controls.ImageButton delete_btn2;
        private Smobiler.Core.Controls.Panel tikMes_Pan3;
        private Smobiler.Core.Controls.Label seat_Text3;
        private Smobiler.Core.Controls.Label money_Text3;
        private Smobiler.Core.Controls.ImageButton delete_btn3;
        private Smobiler.Core.Controls.Panel tikMes_Pan4;
        private Smobiler.Core.Controls.Label seat_Text4;
        private Smobiler.Core.Controls.Label money_Text4;
        private Smobiler.Core.Controls.ImageButton delete_btn4;
    }
}