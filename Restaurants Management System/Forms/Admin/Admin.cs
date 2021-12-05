using BusinessLayer.Entities;
using Restaurants_Management_System.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurants_Management_System.Forms.Admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            new OpenChildForm(new EmployeeForm((int)User.UserTypeEnum.Manager), metroPanelAdminMain);
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            new OpenChildForm(new EmployeeForm((int)User.UserTypeEnum.Chef), metroPanelAdminMain);
        }

        private void btnWaiter_Click(object sender, EventArgs e)
        {
            new OpenChildForm(new EmployeeForm((int)User.UserTypeEnum.Waiter), metroPanelAdminMain);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            new OpenChildForm(new CategoryForm(), metroPanelAdminMain);
        }
    }
}
