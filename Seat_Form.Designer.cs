using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class Seat_Form : Smobiler.Core.Controls.MobileForm
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
            this.title_Control1 = new SmobilerAppTEST7._17.Title_Control();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.buyBtn_Control1 = new SmobilerAppTEST7._17.BuyBtn_Control();
            this.ticketMes_Control1 = new SmobilerAppTEST7._17.TicketMes_Control();
            // 
            // title_Control1
            // 
            this.title_Control1.BackColor = System.Drawing.Color.Gray;
            this.title_Control1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Control1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.title_Control1.Location = new System.Drawing.Point(40, 76);
            this.title_Control1.Name = "title_Control1";
            this.title_Control1.Size = new System.Drawing.Size(100, 36);
            this.title_Control1.Text = "标题";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.buyBtn_Control1,
            this.ticketMes_Control1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(130, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // buyBtn_Control1
            // 
            this.buyBtn_Control1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buyBtn_Control1.Location = new System.Drawing.Point(120, 329);
            this.buyBtn_Control1.Name = "buyBtn_Control1";
            this.buyBtn_Control1.Size = new System.Drawing.Size(300, 55);
            this.buyBtn_Control1.Sure_lbl_Text = "买票啦阿sir";
            // 
            // ticketMes_Control1
            // 
            this.ticketMes_Control1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ticketMes_Control1.Location = new System.Drawing.Point(118, 278);
            this.ticketMes_Control1.Name = "ticketMes_Control1";
            this.ticketMes_Control1.Size = new System.Drawing.Size(300, 184);
            // 
            // Seat_Form
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title_Control1,
            this.panel1});
            this.Load += new System.EventHandler(this.Seat_Form_Load);
            this.Name = "Seat_Form";

        }
        #endregion

        private Title_Control title_Control1;
        private Smobiler.Core.Controls.Panel panel1;
        private BuyBtn_Control buyBtn_Control1;
        private TicketMes_Control ticketMes_Control1;
    }
}