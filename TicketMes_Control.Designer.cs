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
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.seatMes_Control1 = new SmobilerAppTEST7._17.SeatMes_Control();
            this.seatMes_Control2 = new SmobilerAppTEST7._17.SeatMes_Control();
            this.seatMes_Control3 = new SmobilerAppTEST7._17.SeatMes_Control();
            this.seatMes_Control4 = new SmobilerAppTEST7._17.SeatMes_Control();
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
            this.seatMes_Control1,
            this.seatMes_Control2,
            this.seatMes_Control3,
            this.seatMes_Control4});
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
            // seatMes_Control1
            // 
            this.seatMes_Control1.Location = new System.Drawing.Point(10, 82);
            this.seatMes_Control1.Money_Text = "¥50";
            this.seatMes_Control1.Name = "seatMes_Control1";
            this.seatMes_Control1.Seat_Text = "8排8座";
            this.seatMes_Control1.Size = new System.Drawing.Size(55, 50);
            this.seatMes_Control1.Visible = false;
            // 
            // seatMes_Control2
            // 
            this.seatMes_Control2.Location = new System.Drawing.Point(75, 82);
            this.seatMes_Control2.Money_Text = "¥50";
            this.seatMes_Control2.Name = "seatMes_Control2";
            this.seatMes_Control2.Seat_Text = "8排8座";
            this.seatMes_Control2.Size = new System.Drawing.Size(55, 50);
            this.seatMes_Control2.Visible = false;
            // 
            // seatMes_Control3
            // 
            this.seatMes_Control3.Location = new System.Drawing.Point(140, 82);
            this.seatMes_Control3.Money_Text = "¥50";
            this.seatMes_Control3.Name = "seatMes_Control3";
            this.seatMes_Control3.Seat_Text = "8排8座";
            this.seatMes_Control3.Size = new System.Drawing.Size(55, 50);
            this.seatMes_Control3.Visible = false;
            // 
            // seatMes_Control4
            // 
            this.seatMes_Control4.Location = new System.Drawing.Point(205, 82);
            this.seatMes_Control4.Money_Text = "¥50";
            this.seatMes_Control4.Name = "seatMes_Control4";
            this.seatMes_Control4.Seat_Text = "8排8座";
            this.seatMes_Control4.Size = new System.Drawing.Size(55, 50);
            this.seatMes_Control4.Visible = false;
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
        private SeatMes_Control seatMes_Control1;
        private SeatMes_Control seatMes_Control2;
        private SeatMes_Control seatMes_Control3;
        private SeatMes_Control seatMes_Control4;
    }
}