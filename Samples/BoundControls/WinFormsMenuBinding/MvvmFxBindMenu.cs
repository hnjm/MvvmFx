﻿using System.Windows.Forms;
using BoundControls.Business;
using MvvmFx.CaliburnMicro;

namespace WinForms.MenuBinding
{
    public partial class MvvmFxBindMenu : Form
    {
        private readonly MvvmFxBindComponents _binder = new MvvmFxBindComponents();

        public MvvmFxBindMenu()
        {
            InitializeComponent();
        }

        private void MvvmFxBindMenu_Load(object sender, System.EventArgs e)
        {
            var menu = MenuCollection.GetMenu("menuItem6");
            menu.Visible = false;
            menu.Text = "Hidden";
            menu.ToolTipText = "Hidden menu entry";

            _binder.SetMvvmFxBindings(this);
        }

        private void showItem_Click(object sender, System.EventArgs e)
        {
            var menu = MenuCollection.GetMenu("menuItem6");
            menu.Visible = true;
        }

        private void changeItem_Click(object sender, System.EventArgs e)
        {
            var menu = MenuCollection.GetMenu("menuItem6");
            menu.Text = "Help";
            menu.ToolTipText = "Get help about an application topic.";
        }
    }
}