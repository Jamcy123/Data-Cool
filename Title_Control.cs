using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Drawing;

namespace SmobilerAppTEST7._17
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    [System.ComponentModel.ToolboxItem(true)]
    partial class Title_Control : Smobiler.Core.Controls.MobileUserControl
    {
        public Title_Control() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public event EventHandler ExitButtonpPress;//定义事件
        public string Text
        {
            get { return Title_lbl.Text; }
            set { this.Title_lbl.Text = value; }
        }

        public Color BACKColor_re
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        private void panel2_Press(object sender, EventArgs e)
        {
            if (ExitButtonpPress != null)
                ExitButtonpPress.Invoke(this, EventArgs.Empty);
        }
    }
}