using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerAppTEST7._17
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    [System.ComponentModel.ToolboxItem(true)]
    partial class BuyBtn_Control : Smobiler.Core.Controls.MobileUserControl
    {
        public BuyBtn_Control() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        public event EventHandler Sure_btn_press;//单击事件
        public string Sure_lbl_Text//确认键文本 属性
        {
            get { return sure_lbl.Text; }
            set { sure_lbl.Text = value; }
        }
        public Panel Sure_Panel//确认键颜色 属性BackColor
        {
            get { return sure_panel; }
            set { sure_panel = value; }
        }
        public Panel Touch_Panel//确认键选中 属性Visible
        {
            get { return touch_panel; }
            set { touch_panel = value; }
        }
        private void sure_panel_Press(object sender, EventArgs e)//单击响应事件
        {
            if (Sure_btn_press != null)
                Sure_btn_press.Invoke(this, EventArgs.Empty);
        }
    }
}