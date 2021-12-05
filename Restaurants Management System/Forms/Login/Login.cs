using BusinessLayer;
using BusinessLayer.Entities;
using DatabaseLayer;
using Restaurants_Management_System.Forms.Admin;
using Restaurants_Management_System.Forms.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurants_Management_System
{
    public partial class Login : Form
    {
        Users users;
        public Login()
        {
            InitializeComponent();
            users = new Users();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            User user = users.LoginAccess(tbUserId.Text, tbPassword.Text);
            if(user == null)
            {
                MessageBox.Show("Failled");
            }
            else
            {
                switch (user.UserType)
                {
                    case (int)User.UserTypeEnum.Admin:
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                        break;
                    case (int)User.UserTypeEnum.Manager:
                        Manager manager = new Manager(user);
                        manager.Show();
                        this.Hide();
                        break;
                }
            }
            
        }
    }
}
