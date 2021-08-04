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
            this.txtUserphone = new Smobiler.Core.Controls.TextBox();
            this.txtPassword = new Smobiler.Core.Controls.TextBox();
            this.txtsure = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.txtnewpassword = new Smobiler.Core.Controls.TextBox();
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtUserphone,
            this.txtPassword,
            this.txtsure,
            this.label1,
            this.label2,
            this.label3,
            this.button1,
            this.label4,
            this.txtnewpassword});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(50, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // txtUserphone
            // 
            this.txtUserphone.Location = new System.Drawing.Point(83, 199);
            this.txtUserphone.MaxLength = 11;
            this.txtUserphone.Name = "txtUserphone";
            this.txtUserphone.Size = new System.Drawing.Size(200, 30);
            this.txtUserphone.WaterMarkText = "请输入手机号";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 246);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.SecurityMode = true;
            this.txtPassword.Size = new System.Drawing.Size(200, 30);
            this.txtPassword.WaterMarkText = "请输入原始密码";
            // 
            // txtsure
            // 
            this.txtsure.Location = new System.Drawing.Point(83, 347);
            this.txtsure.MaxLength = 20;
            this.txtsure.Name = "txtsure";
            this.txtsure.SecurityMode = true;
            this.txtsure.Size = new System.Drawing.Size(200, 30);
            this.txtsure.WaterMarkText = "确认密码";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 30);
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.Text = "原始密码";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.Text = "确认密码";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "确认修改";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 30);
            this.label4.Text = "新密码";
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(83, 296);
            this.txtnewpassword.MaxLength = 20;
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.SecurityMode = true;
            this.txtnewpassword.Size = new System.Drawing.Size(200, 30);
            this.txtnewpassword.WaterMarkText = "请输入新密码";
            // 
            // Alterpassword
            // 
            this.BackgroundImage = "bluee";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Name = "Alterpassword";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.TextBox txtUserphone;
        private Smobiler.Core.Controls.TextBox txtPassword;
        private Smobiler.Core.Controls.TextBox txtsure;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.TextBox txtnewpassword;
    }
}