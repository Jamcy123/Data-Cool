using System;
using Smobiler.Core;
namespace SmobilerAppTEST7._17
{
    partial class SeatMes_Control : Smobiler.Core.Controls.MobileUserControl
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
            this.money_Text = new Smobiler.Core.Controls.Label();
            this.delete_btn = new Smobiler.Core.Controls.ImageButton();
            this.seat_Text = new Smobiler.Core.Controls.Label();
            this.SeatMes_Panel = new Smobiler.Core.Controls.Panel();
            // 
            // money_Text
            // 
            this.money_Text.FontSize = 11F;
            this.money_Text.ForeColor = System.Drawing.Color.DimGray;
            this.money_Text.Location = new System.Drawing.Point(6, 27);
            this.money_Text.Name = "money_Text";
            this.money_Text.Size = new System.Drawing.Size(40, 16);
            this.money_Text.Text = "¥50";
            // 
            // delete_btn
            // 
            this.delete_btn.IconColor = System.Drawing.Color.DimGray;
            this.delete_btn.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.delete_btn.ImgTextRatio = new Smobiler.Core.Controls.Ratio(1, 0);
            this.delete_btn.Location = new System.Drawing.Point(35, 14);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.ResourceID = "ios-close";
            this.delete_btn.Size = new System.Drawing.Size(22, 22);
            this.delete_btn.Press += new System.EventHandler(this.delete_btn_Press);
            // 
            // seat_Text
            // 
            this.seat_Text.FontSize = 11F;
            this.seat_Text.ForeColor = System.Drawing.Color.DimGray;
            this.seat_Text.Location = new System.Drawing.Point(6, 6);
            this.seat_Text.Name = "seat_Text";
            this.seat_Text.Size = new System.Drawing.Size(40, 16);
            this.seat_Text.Text = "8排8座";
            // 
            // SeatMes_Panel
            // 
            this.SeatMes_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SeatMes_Panel.BorderRadius = 12;
            this.SeatMes_Panel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.seat_Text,
            this.money_Text,
            this.delete_btn});
            this.SeatMes_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeatMes_Panel.Location = new System.Drawing.Point(14, 14);
            this.SeatMes_Panel.Name = "SeatMes_Panel";
            this.SeatMes_Panel.Size = new System.Drawing.Size(300, 100);
            // 
            // SeatMes_Control
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.SeatMes_Panel});
            this.Size = new System.Drawing.Size(55, 50);
            this.Name = "SeatMes_Control";

        }
        #endregion

        private Smobiler.Core.Controls.Label money_Text;
        private Smobiler.Core.Controls.ImageButton delete_btn;
        private Smobiler.Core.Controls.Label seat_Text;
        private Smobiler.Core.Controls.Panel SeatMes_Panel;
    }
}