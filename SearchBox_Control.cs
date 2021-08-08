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
    partial class SearchBox_Control : Smobiler.Core.Controls.MobileUserControl
    {
        public SearchBox_Control() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public event EventHandler SearchButtonPress;
        public string TextBox_Text//textBox1的属性
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        private void panel2_Press(object sender, EventArgs e)//点击搜索按钮时发生
        {
            if (SearchButtonPress != null)
                SearchButtonPress.Invoke(this, EventArgs.Empty);
        }
        private void textBox1_SubmitEditing(object sender, EventArgs e)//软键盘确认/提交按钮点击时发生
        {
            if (SearchButtonPress != null)
                SearchButtonPress.Invoke(this, EventArgs.Empty);
        }
    }
}