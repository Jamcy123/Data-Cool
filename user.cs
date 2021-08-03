using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerAppTEST7._17
{
    partial class user : Smobiler.Core.Controls.MobileForm
    {
        public user() : base()
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
                case "user-icon":
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void button1_Press(object sender, EventArgs e)
        {
            this.Form.Client.ReStart();
        }

        private void button2_Press(object sender, EventArgs e)
        {
            Alterpassword alterpassword = new Alterpassword();
            this.Show(alterpassword);
        }
    }
}