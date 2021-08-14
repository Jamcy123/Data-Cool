using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class register : Smobiler.Core.Controls.MobileForm
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
            this.txtUserphone = new Smobiler.Core.Controls.TextBox();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtPassword = new Smobiler.Core.Controls.TextBox();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.txtsure = new Smobiler.Core.Controls.TextBox();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.checkBox1 = new Smobiler.Core.Controls.CheckBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.checkBox2 = new Smobiler.Core.Controls.CheckBox();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtUserphone,
            this.label2,
            this.txtPassword,
            this.label4,
            this.txtsure,
            this.label5,
            this.checkBox1,
            this.button1,
            this.checkBox2,
            this.label6,
            this.label3,
            this.label1});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 357);
            // 
            // txtUserphone
            // 
            this.txtUserphone.BackColor = System.Drawing.Color.Transparent;
            this.txtUserphone.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 2F);
            this.txtUserphone.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserphone.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtUserphone.Location = new System.Drawing.Point(88, 16);
            this.txtUserphone.MaxLength = 11;
            this.txtUserphone.Name = "txtUserphone";
            this.txtUserphone.Size = new System.Drawing.Size(200, 30);
            this.txtUserphone.WaterMarkText = "请输入手机号";
            this.txtUserphone.TouchEnter += new System.EventHandler(this.txtUserphone_TouchEnter);
            this.txtUserphone.TouchLeave += new System.EventHandler(this.txtUserphone_TouchLeave);
            // 
            // label2
            // 
            this.label2.FontSize = 15F;
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 30);
            this.label2.Text = "密码";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 2F);
            this.txtPassword.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Location = new System.Drawing.Point(88, 61);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.SecurityMode = true;
            this.txtPassword.Size = new System.Drawing.Size(200, 30);
            this.txtPassword.WaterMarkText = "请输入密码";
            this.txtPassword.TouchEnter += new System.EventHandler(this.txtPassword_TouchEnter);
            this.txtPassword.TouchLeave += new System.EventHandler(this.txtPassword_TouchLeave);
            // 
            // label4
            // 
            this.label4.FontSize = 15F;
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label4.Location = new System.Drawing.Point(19, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 28);
            this.label4.Text = "性别";
            // 
            // txtsure
            // 
            this.txtsure.BackColor = System.Drawing.Color.Transparent;
            this.txtsure.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 2F);
            this.txtsure.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtsure.Location = new System.Drawing.Point(88, 108);
            this.txtsure.MaxLength = 20;
            this.txtsure.Name = "txtsure";
            this.txtsure.SecurityMode = true;
            this.txtsure.Size = new System.Drawing.Size(200, 30);
            this.txtsure.WaterMarkText = "确认密码";
            this.txtsure.TouchEnter += new System.EventHandler(this.txtsure_TouchEnter);
            this.txtsure.TouchLeave += new System.EventHandler(this.txtsure_TouchLeave);
            // 
            // label5
            // 
            this.label5.FontSize = 15F;
            this.label5.Location = new System.Drawing.Point(98, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.Text = "男";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.Location = new System.Drawing.Point(126, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(20, 20);
            this.checkBox1.TintColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.button1.BorderRadius = 20;
            this.button1.FontSize = 15F;
            this.button1.Location = new System.Drawing.Point(68, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 35);
            this.button1.Text = "注册";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(208, 157);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(20, 20);
            this.checkBox2.TintColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.FontSize = 15F;
            this.label6.Location = new System.Drawing.Point(180, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.Text = "女";
            // 
            // label3
            // 
            this.label3.FontSize = 15F;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Location = new System.Drawing.Point(10, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 30);
            this.label3.Text = "确认密码";
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.Text = "用户名";
            // 
            // register
            // 
            this.BackgroundImage = "background.png";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Name = "register";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.TextBox txtUserphone;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox txtPassword;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.TextBox txtsure;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.CheckBox checkBox1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.CheckBox checkBox2;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label1;
    }
}