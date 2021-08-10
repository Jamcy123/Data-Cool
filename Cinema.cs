using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmobilerAppTEST7._17
{
    partial class Cinema : Smobiler.Core.Controls.MobileForm
    {
        public Cinema() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        public void setToolbarIndex(int i)
        {
            toolBar1.SelectedIndex = i;//底部栏默认选项
        }

        public string ToolBarItemName { get; set; }//底部工具栏选项

        private void toolBar1_ToolbarItemClick_1(object sender, ToolbarClickEventArgs e)
        {
            ToolBarItemName = e.Name;
            switch (e.Name)
            {
                case "cinema":
                    break;
                default:
                    this.Close();
                    break;
            }
        }
    }
}