using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Restaurants_Management_System.ChildForm
{
    internal class OpenChildForm
    {
        private Form activeFrom = null;

        public OpenChildForm(Form childForm, Panel panel)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
