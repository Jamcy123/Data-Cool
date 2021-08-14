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
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.btnLogon = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.checkBox1 = new Smobiler.Core.Controls.CheckBox();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.checkBox2 = new Smobiler.Core.Controls.CheckBox();
            this.txtPassword = new Smobiler.Core.Controls.TextBox();
            this.txtUserName = new Smobiler.Core.Controls.TextBox();
            this.fontIcon2 = new Smobiler.Core.Controls.FontIcon();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.checkRemb = new Smobiler.Core.Controls.CheckBox();
            this.btnForget = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.button3 = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.panel2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(120, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // image1
            // 
            this.image1.BorderRadius = 50;
            this.image1.Location = new System.Drawing.Point(104, 61);
            this.image1.Name = "image1";
            this.image1.ResourceID = "yingtao.png";
            this.image1.Size = new System.Drawing.Size(100, 100);
            this.image1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnLogon,
            this.label3,
            this.checkBox1,
            this.label4,
            this.checkBox2,
            this.txtPassword,
            this.txtUserName,
            this.fontIcon2,
            this.fontIcon1,
            this.label1,
            this.checkRemb,
            this.btnForget,
            this.button2,
            this.label2,
            this.button3});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(9, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 363);
            // 
            // btnLogon
            // 
            this.btnLogon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.btnLogon.BorderRadius = 20;
            this.btnLogon.FontSize = 15F;
            this.btnLogon.Location = new System.Drawing.Point(69, 249);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(170, 35);
            this.btnLogon.Text = "登录";
            this.btnLogon.Press += new System.EventHandler(this.btnLogon_Press);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(61, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.Text = "用户";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.Location = new System.Drawing.Point(95, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 25);
            this.checkBox1.TintColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(176, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.Text = "管理员";
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(221, 203);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(22, 25);
            this.checkBox2.TintColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 2F);
            this.txtPassword.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Location = new System.Drawing.Point(65, 78);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.SecurityMode = true;
            this.txtPassword.Size = new System.Drawing.Size(200, 30);
            this.txtPassword.WaterMarkText = "密码";
            this.txtPassword.TouchEnter += new System.EventHandler(this.txtPassword_TouchEnter);
            this.txtPassword.TouchLeave += new System.EventHandler(this.txtPassword_TouchLeave);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 2F);
            this.txtUserName.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtUserName.Location = new System.Drawing.Point(65, 20);
            this.txtUserName.MaxLength = 11;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 30);
            this.txtUserName.WaterMarkText = "账号";
            this.txtUserName.TouchEnter += new System.EventHandler(this.txtUserName_TouchEnter);
            this.txtUserName.TouchLeave += new System.EventHandler(this.txtUserName_TouchLeave);
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.fontIcon2.Location = new System.Drawing.Point(24, 81);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "lock";
            this.fontIcon2.Size = new System.Drawing.Size(25, 25);
            // 
            // fontIcon1
            // 
            this.fontIcon1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.fontIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.fontIcon1.Location = new System.Drawing.Point(24, 24);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "user";
            this.fontIcon1.Size = new System.Drawing.Size(25, 26);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(45, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.Text = "记住密码";
            // 
            // checkRemb
            // 
            this.checkRemb.Location = new System.Drawing.Point(18, 129);
            this.checkRemb.Name = "checkRemb";
            this.checkRemb.Size = new System.Drawing.Size(27, 18);
            this.checkRemb.TintColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            // 
            // btnForget
            // 
            this.btnForget.BackColor = System.Drawing.Color.Transparent;
            this.btnForget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.btnForget.Location = new System.Drawing.Point(124, 127);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(80, 24);
            this.btnForget.Text = "清除密码";
            this.btnForget.Press += new System.EventHandler(this.btnForget_Press);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.button2.Location = new System.Drawing.Point(211, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 24);
            this.button2.Text = "注册";
            this.button2.Press += new System.EventHandler(this.btnregister_Press);
            // 
            // label2
            // 
            this.label2.Bold = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(18, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.Text = "请选择您的身份：";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.Text = "我直接选座位";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // SmobilerForm1
            // 
            this.BackgroundImage = "background";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Name = "SmobilerForm1";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Button btnLogon;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.CheckBox checkBox1;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.CheckBox checkBox2;
        private Smobiler.Core.Controls.TextBox txtPassword;
        private Smobiler.Core.Controls.TextBox txtUserName;
        private Smobiler.Core.Controls.FontIcon fontIcon2;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.CheckBox checkRemb;
        private Smobiler.Core.Controls.Button btnForget;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Button button3;
    }
}