using BusinessLayer;
using BusinessLayer.Entities;
using Restaurants_Management_System.RandomSample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurants_Management_System.Forms.Admin
{
    public partial class EmployeeForm : Form
    {
        Users users = new Users();
        Employees employees = new Employees();
        RandomGenerator randomGenerator = new RandomGenerator();
        int UserType;
        public EmployeeForm(int UserType)
        {
            InitializeComponent();
            this.UserType = UserType;
            LoadData();
        }

        private void LoadData()
        {  
            dgvEmployee.DataSource = employees.GetEmployeesByUserType(UserType);
            txtUserId.Text = randomGenerator.RandomString(5, false);
            txtPassword.Text = randomGenerator.RandomPassword();

            txtUserId.Enabled = false;
            txtPassword.Enabled = false;

            metroPanelEmployee.Visible = false;
            
            btnAddEmployee.Visible = false;
            btnUpdateEmployee.Visible = false;
            btnDeleteEmployee.Visible = false;
        }

        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            user.UserId = txtUserId.Text;
            user.Password = txtPassword.Text;
            user.UserType = UserType;
            bool isInsertUser = users.InsertUser(user);
            if (isInsertUser)
            {
                metroPanelEmployee.Visible = true;
                btnAddEmployee.Visible = true;
                metroPanelUser.Enabled = false;

                MessageBox.Show("Succefully Insert");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.UserId = txtUserId.Text;
            employee.FisrtName = txtFisrtName.Text;
            employee.LastName = txtLastName.Text;
            employee.Gender = (rbMale.Checked) ? "Male" : "Female";
            employee.PhoneNumber = txtPhoneNumber.Text;
            employee.Email = txtEmail.Text;
            employee.Salary = Int32.Parse(cbSalary.SelectedItem.ToString()) ;
            employee.TimeSchedule = cbTimeSchedule.SelectedItem.ToString();
            employee.HireDate = metroDateTimeHireDate.Value.ToString();
            employee.UserType = UserType;
            bool isInsertEmployee = employees.IsInsert(employee);
            if (isInsertEmployee)
            {
                MessageBox.Show("Succefully Insert");
                dgvEmployee.DataSource = employees.GetEmployeesByUserType(UserType);
                this.Close();
                this.Show();
            }

            else
            {
                MessageBox.Show("Something went wrong");
            }

        }

        private void dgvEmployee_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvEmployee_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            metroPanelEmployee.Visible = true;
            btnUpdateEmployee.Visible = true;
            btnDeleteEmployee.Visible = true;

            btnAddEmployee.Visible = false;
            btnAddUser.Visible = false;
            metroLabelPassword.Visible = false;
            txtPassword.Visible = false;
           
            var userId = dgvEmployee.SelectedRows[0].Cells[0].Value.ToString();
            var firstName = dgvEmployee.SelectedRows[0].Cells[1].Value.ToString();
            var lastName = dgvEmployee.SelectedRows[0].Cells[2].Value.ToString();
            var gender = dgvEmployee.SelectedRows[0].Cells[3].Value.ToString();
            var phoneNumber = dgvEmployee.SelectedRows[0].Cells[4].Value.ToString();
            var email = dgvEmployee.SelectedRows[0].Cells[5].Value.ToString();
            var salary = dgvEmployee.SelectedRows[0].Cells[6].Value.ToString();
            var timeSchedule = dgvEmployee.SelectedRows[0].Cells[7].Value.ToString();
            var joinDate = dgvEmployee.SelectedRows[0].Cells[8].Value.ToString();

            txtUserId.Text = userId;
            txtFisrtName.Text = firstName;
            txtLastName.Text = lastName;
            if (gender.Trim() == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtEmail.Text = email;
            txtPhoneNumber.Text = phoneNumber;
            cbSalary.SelectedItem = salary;
            cbTimeSchedule.SelectedItem = timeSchedule;
            metroDateTimeHireDate.Value = Convert.ToDateTime(joinDate);

        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.UserId = txtUserId.Text;
            employee.FisrtName = txtFisrtName.Text;
            employee.LastName = txtLastName.Text;
            employee.Gender = (rbMale.Checked) ? "Male" : "Female";
            employee.PhoneNumber = txtPhoneNumber.Text;
            employee.Email = txtEmail.Text;
            employee.Salary = Int32.Parse(cbSalary.SelectedItem.ToString());
            employee.TimeSchedule = cbTimeSchedule.SelectedItem.ToString();
            employee.HireDate = metroDateTimeHireDate.Value.ToString();
            bool isUpdateEmplyee = employees.IsUpdate(employee);
            if (isUpdateEmplyee)
            {
                MessageBox.Show("Succefully Updated");
                dgvEmployee.DataSource = employees.GetEmployeesByUserType(UserType);
                this.Close();
                this.Show();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            bool isDeleteUser = users.DeleteUser(txtUserId.Text);
            bool isDeleteEmployee = employees.IsDelete(txtUserId.Text);
            if (isDeleteUser && isDeleteEmployee)
            {
                MessageBox.Show("Succefully Deleted");
                dgvEmployee.DataSource = employees.GetEmployeesByUserType(UserType);
                this.Close();
                this.Show();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
