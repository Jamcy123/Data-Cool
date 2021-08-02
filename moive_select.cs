using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerAppTEST7._17
{
    partial class moive_select : Smobiler.Core.Controls.MobileForm
    {
        public moive_select() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private void moive_select_Load(object sender, EventArgs e)//界面加载事件
        {
            toolBar1.SelectedIndex = 1;//底部栏默认选项
        }

        private void ShowForm(string name)//界面选择
        {
            switch (name)
            {
                case "moive-icon":
                    toolBar1.SelectedIndex = 1;
                    break;
                case "cinema-icon":
                    Cinema_select cinema_Select = new Cinema_select();
                    cinema_Select.setToolbarIndex(0);
                    Show(cinema_Select, (obj, args) => { ShowForm(cinema_Select.ToolBarItemName); });
                    break;
                case "user-icon":
                    user user = new user();
                    user.setToolbarIndex(2);
                    Show(user, (obj, args) => { ShowForm(user.ToolBarItemName); });
                    break;
            }
        }

        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)//底部工具栏单击事件
        {
            ShowForm(e.Name);//e:单击的图标
        }


    }
}