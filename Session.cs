using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmobilerAppTEST7._17
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class Session : Smobiler.Core.Controls.MobileUserControl
    {
        public Session() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
    }
}