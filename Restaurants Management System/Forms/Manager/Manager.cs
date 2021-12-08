using BusinessLayer.Entities;
using Restaurants_Management_System.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurants_Management_System.Forms.Manager
{
    public partial class Manager : Form
    {
        User user;
        public Manager(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnManageTable_Click(object sender, EventArgs e)
        {
            new OpenChildForm(new ManageTable(), metroPanelManagerMain);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            new OpenChildForm(new ManageOrder(), metroPanelManagerMain);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
