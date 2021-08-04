using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerAppTEST7._17
{
    partial class cinema_select : Smobiler.Core.Controls.MobileForm
    {
        public cinema_select(string a) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        public void setToolbarIndex(int i)
        {
            toolBar1.SelectedIndex = i;//底部栏默认选项
        }
        public string ToolBarItemName { get; set; }//底部工具栏选项
        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)//底部栏单击事件
        {
            ToolBarItemName = e.Name;
            switch (e.Name)
            {
                case "cinema-icon":
                    break;
                default:
                    this.Close();
                    break;
            }
        }


    }
}