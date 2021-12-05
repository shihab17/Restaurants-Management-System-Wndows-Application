using BusinessLayer.Entities;
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
    }
}
