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
            this.txtPassword = new Smobiler.Core.Controls.TextBox();
            this.txtUserphone = new Smobiler.Core.Controls.TextBox();
            this.txtsure = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.checkBox1 = new Smobiler.Core.Controls.CheckBox();
            this.checkBox2 = new Smobiler.Core.Controls.CheckBox();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtPassword,
            this.txtUserphone,
            this.txtsure,
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.checkBox1,
            this.checkBox2,
            this.label5,
            this.label6,
            this.button1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // txtPassword
            // 
            this.txtPassword.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtPassword.BorderColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(84, 281);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.SecurityMode = true;
            this.txtPassword.Size = new System.Drawing.Size(200, 30);
            this.txtPassword.WaterMarkText = "请输入密码";
            // 
            // txtUserphone
            // 
            this.txtUserphone.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtUserphone.BorderColor = System.Drawing.Color.DimGray;
            this.txtUserphone.Location = new System.Drawing.Point(84, 234);
            this.txtUserphone.MaxLength = 11;
            this.txtUserphone.Name = "txtUserphone";
            this.txtUserphone.Size = new System.Drawing.Size(200, 30);
            this.txtUserphone.WaterMarkText = "请输入手机号";
            // 
            // txtsure
            // 
            this.txtsure.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtsure.BorderColor = System.Drawing.Color.DimGray;
            this.txtsure.Location = new System.Drawing.Point(84, 325);
            this.txtsure.MaxLength = 20;
            this.txtsure.Name = "txtsure";
            this.txtsure.SecurityMode = true;
            this.txtsure.Size = new System.Drawing.Size(200, 30);
            this.txtsure.WaterMarkText = "确认密码";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 30);
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 30);
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.Text = "确认密码";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(29, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 28);
            this.label4.Text = "性别";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(135, 380);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(20, 20);
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(239, 380);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(19, 20);
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(106, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 28);
            this.label5.Text = "男";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(207, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 28);
            this.label6.Text = "女";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "注册";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // register
            // 
            this.BackgroundImage = "bluee";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Name = "register";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.TextBox txtPassword;
        private Smobiler.Core.Controls.TextBox txtUserphone;
        private Smobiler.Core.Controls.TextBox txtsure;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.CheckBox checkBox1;
        private Smobiler.Core.Controls.CheckBox checkBox2;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Button button1;
    }
}