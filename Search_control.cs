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
    partial class Search_control : Smobiler.Core.Controls.MobileUserControl
    {
        public Search_control() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public event EventHandler Search_control_Press;
        private void panel1_Press(object sender, EventArgs e)
        {
            if (Search_control_Press != null)
                Search_control_Press.Invoke(this, EventArgs.Empty);
        }
    }
}