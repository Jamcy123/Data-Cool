using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class addSession : Smobiler.Core.Controls.MobileUserControl
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
            Smobiler.Core.Controls.PopListGroup popListGroup1 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListItem popListItem1 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem2 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem3 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem4 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem5 = new Smobiler.Core.Controls.PopListItem();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.hall = new Smobiler.Core.Controls.Label();
            this.time = new Smobiler.Core.Controls.Label();
            this.price = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.getprice = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.datePicker1 = new Smobiler.Core.Controls.DatePicker();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.gethall = new Smobiler.Core.Controls.Label();
            this.popList1 = new Smobiler.Core.Controls.PopList();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.hall,
            this.time,
            this.price,
            this.button1,
            this.getprice,
            this.label1,
            this.datePicker1,
            this.panel2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(79, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // hall
            // 
            this.hall.FontSize = 16F;
            this.hall.Location = new System.Drawing.Point(13, 33);
            this.hall.Name = "hall";
            this.hall.Size = new System.Drawing.Size(111, 46);
            this.hall.Text = "放映影厅：";
            // 
            // time
            // 
            this.time.FontSize = 16F;
            this.time.Location = new System.Drawing.Point(13, 103);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(111, 46);
            this.time.Text = "放映时间：";
            // 
            // price
            // 
            this.price.FontSize = 16F;
            this.price.Location = new System.Drawing.Point(13, 171);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(111, 46);
            this.price.Text = "购票价格：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FontSize = 16F;
            this.button1.Location = new System.Drawing.Point(91, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.Text = "确认添加";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // getprice
            // 
            this.getprice.Border = new Smobiler.Core.Controls.Border(1F);
            this.getprice.BorderColor = System.Drawing.Color.Gray;
            this.getprice.FontSize = 16F;
            this.getprice.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.getprice.KeyboardType = Smobiler.Core.Controls.KeyboardType.PhonePad;
            this.getprice.Location = new System.Drawing.Point(146, 174);
            this.getprice.Name = "getprice";
            this.getprice.Size = new System.Drawing.Size(111, 43);
            this.getprice.WaterMarkText = "请输入价格";
            // 
            // label1
            // 
            this.label1.FontSize = 16F;
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(257, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 43);
            this.label1.Text = "￥";
            // 
            // datePicker1
            // 
            this.datePicker1.Border = new Smobiler.Core.Controls.Border(1F);
            this.datePicker1.BorderColor = System.Drawing.Color.DimGray;
            this.datePicker1.FontSize = 16F;
            this.datePicker1.ForeColor = System.Drawing.Color.Gray;
            this.datePicker1.Location = new System.Drawing.Point(146, 103);
            this.datePicker1.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(137, 46);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gethall});
            this.panel2.Location = new System.Drawing.Point(146, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 46);
            this.panel2.Touchable = true;
            this.panel2.Press += new System.EventHandler(this.panel2_Press);
            // 
            // gethall
            // 
            this.gethall.Border = new Smobiler.Core.Controls.Border(1F);
            this.gethall.BorderColor = System.Drawing.Color.DimGray;
            this.gethall.FontSize = 16F;
            this.gethall.ForeColor = System.Drawing.Color.Gray;
            this.gethall.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.gethall.Location = new System.Drawing.Point(1, 1);
            this.gethall.Name = "gethall";
            this.gethall.Size = new System.Drawing.Size(141, 44);
            this.gethall.Text = "请选择影厅";
            // 
            // popList1
            // 
            popListItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem1.Text = "1号放映厅";
            popListItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem2.Text = "2号放映厅";
            popListItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem3.Text = "3号放映厅";
            popListItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem4.Text = "4号放映厅";
            popListItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem5.Text = "5号放映厅";
            popListGroup1.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem1,
            popListItem2,
            popListItem3,
            popListItem4,
            popListItem5});
            popListGroup1.Value = null;
            this.popList1.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup1});
            this.popList1.Name = "popList1";
            this.popList1.Title = "请选择影厅";
            this.popList1.Selected += new System.EventHandler(this.popList1_Selected);
            // 
            // addSession
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 300);
            this.Name = "addSession";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label hall;
        private Smobiler.Core.Controls.Label time;
        private Smobiler.Core.Controls.Label price;
        private Smobiler.Core.Controls.PopList popList1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.TextBox getprice;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.DatePicker datePicker1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label gethall;
    }
}