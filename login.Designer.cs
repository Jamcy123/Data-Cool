using Smobiler.Core;

namespace SmobilerAppTEST7._17
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.fontIcon2 = new Smobiler.Core.Controls.FontIcon();
            this.txtUserName = new Smobiler.Core.Controls.TextBox();
            this.txtPassword = new Smobiler.Core.Controls.TextBox();
            this.btnLogon = new Smobiler.Core.Controls.Button();
            this.checkRemb = new Smobiler.Core.Controls.CheckBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnForget = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.checkBox1 = new Smobiler.Core.Controls.CheckBox();
            this.checkBox2 = new Smobiler.Core.Controls.CheckBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.fontIcon1,
            this.fontIcon2,
            this.txtUserName,
            this.txtPassword,
            this.btnLogon,
            this.checkRemb,
            this.label1,
            this.btnForget,
            this.button2,
            this.label2,
            this.label3,
            this.label4,
            this.checkBox1,
            this.checkBox2,
            this.button1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(120, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // image1
            // 
            this.image1.BorderRadius = 360;
            this.image1.Location = new System.Drawing.Point(98, 57);
            this.image1.Name = "image1";
            this.image1.ResourceID = "sansan1.png";
            this.image1.Size = new System.Drawing.Size(122, 80);
            // 
            // fontIcon1
            // 
            this.fontIcon1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.fontIcon1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.fontIcon1.Location = new System.Drawing.Point(24, 217);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "user";
            this.fontIcon1.Size = new System.Drawing.Size(25, 26);
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.fontIcon2.Location = new System.Drawing.Point(24, 278);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "lock";
            this.fontIcon2.Size = new System.Drawing.Size(25, 25);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dotted;
            this.txtUserName.Location = new System.Drawing.Point(65, 217);
            this.txtUserName.MaxLength = 11;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 30);
            this.txtUserName.WaterMarkText = "账号";
            this.txtUserName.TouchLeave += new System.EventHandler(this.txtUserName_TouchLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(65, 275);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.SecurityMode = true;
            this.txtPassword.Size = new System.Drawing.Size(200, 30);
            this.txtPassword.WaterMarkText = "密码";
            // 
            // btnLogon
            // 
            this.btnLogon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogon.FontSize = 15F;
            this.btnLogon.Location = new System.Drawing.Point(69, 452);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(170, 35);
            this.btnLogon.Text = "登录";
            this.btnLogon.Press += new System.EventHandler(this.btnLogon_Press);
            // 
            // checkRemb
            // 
            this.checkRemb.Location = new System.Drawing.Point(11, 325);
            this.checkRemb.Name = "checkRemb";
            this.checkRemb.Size = new System.Drawing.Size(27, 19);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(38, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.Text = "记住密码";
            // 
            // btnForget
            // 
            this.btnForget.BackColor = System.Drawing.Color.White;
            this.btnForget.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnForget.Location = new System.Drawing.Point(117, 325);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(80, 25);
            this.btnForget.Text = "清除密码";
            this.btnForget.Press += new System.EventHandler(this.btnForget_Press);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Location = new System.Drawing.Point(204, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.Text = "注册";
            this.button2.Press += new System.EventHandler(this.btnregister_Press);
            // 
            // label2
            // 
            this.label2.Bold = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(11, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.Text = "请选择您的身份：";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(49, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 35);
            this.label3.Text = "用户";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(156, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 35);
            this.label4.Text = "管理员";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(113, 408);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 22);
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(239, 408);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(20, 20);
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "button1";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // SmobilerForm1
            // 
            this.BackgroundImage = "bluee.png";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Name = "SmobilerForm1";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.FontIcon fontIcon2;
        private Smobiler.Core.Controls.TextBox txtUserName;
        private Smobiler.Core.Controls.TextBox txtPassword;
        private Smobiler.Core.Controls.Button btnLogon;
        private Smobiler.Core.Controls.CheckBox checkRemb;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button btnForget;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.CheckBox checkBox1;
        private Smobiler.Core.Controls.CheckBox checkBox2;
        private Smobiler.Core.Controls.Button button1;
    }
}