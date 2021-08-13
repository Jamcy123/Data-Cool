using Smobiler.Core;
using System;

namespace SmobilerAppTEST7._17
{
    partial class Myblance : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.RadioButton radioButton1 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton2 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton3 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton4 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton5 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton6 = new Smobiler.Core.Controls.RadioButton();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.radioGroup1 = new Smobiler.Core.Controls.RadioGroup();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.title_Control1 = new SmobilerAppTEST7._17.Title_Control();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.radioGroup1,
            this.label3,
            this.label4,
            this.textBox1,
            this.button1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(127, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 52);
            this.label1.Text = "我的余额：";
            // 
            // label2
            // 
            this.label2.FontSize = 15F;
            this.label2.Location = new System.Drawing.Point(113, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 52);
            this.label2.Text = "label2";
            // 
            // radioGroup1
            // 
            radioButton1.ID = "thirty";
            radioButton1.Text = "30元";
            radioButton1.Value = null;
            radioButton2.ID = "fifty";
            radioButton2.Text = "50元";
            radioButton2.Value = null;
            radioButton3.ID = "one";
            radioButton3.Text = "100元";
            radioButton3.Value = null;
            radioButton4.ID = "two";
            radioButton4.Text = "200元";
            radioButton4.Value = null;
            radioButton5.ID = "three";
            radioButton5.Text = "300元";
            radioButton5.Value = null;
            radioButton6.ID = "five";
            radioButton6.Text = "500元";
            radioButton6.Value = null;
            this.radioGroup1.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton1,
            radioButton2,
            radioButton3,
            radioButton4,
            radioButton5,
            radioButton6});
            this.radioGroup1.FontSize = 15F;
            this.radioGroup1.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioGroup1.Location = new System.Drawing.Point(0, 167);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Size = new System.Drawing.Size(300, 185);
            this.radioGroup1.ButtonPress += new Smobiler.Core.Controls.RadioButtonPressEventHandler(this.radioGroup1_ButtonPress);
            // 
            // label3
            // 
            this.label3.FontSize = 15F;
            this.label3.Location = new System.Drawing.Point(14, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 44);
            this.label3.Text = "充值：";
            // 
            // label4
            // 
            this.label4.FontSize = 15F;
            this.label4.Location = new System.Drawing.Point(6, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 40);
            this.label4.Text = "自定义数额：";
            // 
            // textBox1
            // 
            this.textBox1.Border = new Smobiler.Core.Controls.Border(1F);
            this.textBox1.BorderColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(113, 363);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 46);
            this.textBox1.WaterMarkText = "请输入您要充值的数额";
            // 
            // button1
            // 
            this.button1.FontSize = 15F;
            this.button1.Location = new System.Drawing.Point(79, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.Text = "确认充值";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // title_Control1
            // 
            this.title_Control1.BackColor = System.Drawing.Color.Gray;
            this.title_Control1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Control1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.title_Control1.Location = new System.Drawing.Point(107, 23);
            this.title_Control1.Name = "title_Control1";
            this.title_Control1.Size = new System.Drawing.Size(100, 36);
            this.title_Control1.Text = "我的余额";
            this.title_Control1.ExitButtonpPress += new System.EventHandler(this.title_Control1_ExitButtonpPress);
            // 
            // Myblance
            // 
            this.BackgroundImage = "background.png";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.title_Control1});
            this.Name = "Myblance";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.RadioGroup radioGroup1;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Button button1;
        private Title_Control title_Control1;
    }
}