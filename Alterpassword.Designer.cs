using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class Alterpassword : Smobiler.Core.Controls.MobileForm
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
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.txtnewpassword = new Smobiler.Core.Controls.TextBox();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtPassword = new Smobiler.Core.Controls.TextBox();
            this.txtUserphone = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.txtsure = new Smobiler.Core.Controls.TextBox();
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(50, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1,
            this.label3,
            this.txtnewpassword,
            this.label4,
            this.label2,
            this.txtPassword,
            this.txtUserphone,
            this.label1,
            this.txtsure});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 306);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.button1.BorderRadius = 20;
            this.button1.FontSize = 15F;
            this.button1.Location = new System.Drawing.Point(81, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.Text = "确认修改";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // label3
            // 
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Location = new System.Drawing.Point(3, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.Text = "确认密码";
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 2F);
            this.txtnewpassword.BorderColor = System.Drawing.Color.DimGray;
            this.txtnewpassword.Location = new System.Drawing.Point(81, 103);
            this.txtnewpassword.MaxLength = 20;
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.SecurityMode = true;
            this.txtnewpassword.Size = new System.Drawing.Size(200, 30);
            this.txtnewpassword.WaterMarkText = "请输入新密码";
            // 
            // label4
            // 
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label4.Location = new System.Drawing.Point(3, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 30);
            this.label4.Text = "新密码";
            // 
            // label2
            // 
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.Text = "原始密码";
            // 
            // txtPassword
            // 
            this.txtPassword.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 2F);
            this.txtPassword.BorderColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(81, 53);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.SecurityMode = true;
            this.txtPassword.Size = new System.Drawing.Size(200, 30);
            this.txtPassword.WaterMarkText = "请输入原始密码";
            // 
            // txtUserphone
            // 
            this.txtUserphone.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 2F);
            this.txtUserphone.BorderColor = System.Drawing.Color.DimGray;
            this.txtUserphone.Location = new System.Drawing.Point(81, 6);
            this.txtUserphone.MaxLength = 11;
            this.txtUserphone.Name = "txtUserphone";
            this.txtUserphone.Size = new System.Drawing.Size(200, 30);
            this.txtUserphone.WaterMarkText = "请输入手机号";
            this.txtUserphone.TouchEnter += new System.EventHandler(this.txtUserphone_TouchEnter);
            // 
            // label1
            // 
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label1.Location = new System.Drawing.Point(18, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 30);
            this.label1.Text = "用户名";
            // 
            // txtsure
            // 
            this.txtsure.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 2F);
            this.txtsure.BorderColor = System.Drawing.Color.DimGray;
            this.txtsure.Location = new System.Drawing.Point(81, 154);
            this.txtsure.MaxLength = 20;
            this.txtsure.Name = "txtsure";
            this.txtsure.SecurityMode = true;
            this.txtsure.Size = new System.Drawing.Size(200, 30);
            this.txtsure.WaterMarkText = "确认密码";
            // 
            // Alterpassword
            // 
            this.BackgroundImage = "background";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Name = "Alterpassword";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.TextBox txtnewpassword;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox txtPassword;
        private Smobiler.Core.Controls.TextBox txtUserphone;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.TextBox txtsure;
    }
}