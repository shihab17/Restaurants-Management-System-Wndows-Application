namespace Restaurants_Management_System.Forms.Admin
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanelEmployeeData = new MetroFramework.Controls.MetroPanel();
            this.metroPanelEmployee = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeHireDate = new MetroFramework.Controls.MetroDateTime();
            this.cbTimeSchedule = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbSalary = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new MetroFramework.Controls.MetroRadioButton();
            this.rbMale = new MetroFramework.Controls.MetroRadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFisrtName = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.labelFirstName = new MetroFramework.Controls.MetroLabel();
            this.btnAddEmplyee = new MetroFramework.Controls.MetroPanel();
            this.btnDeleteEmployee = new MetroFramework.Controls.MetroButton();
            this.btnUpdateEmployee = new MetroFramework.Controls.MetroButton();
            this.btnAddEmployee = new MetroFramework.Controls.MetroButton();
            this.metroPanelUser = new MetroFramework.Controls.MetroPanel();
            this.btnAddUser = new MetroFramework.Controls.MetroButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.metroLabelPassword = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanelEmployeeView = new MetroFramework.Controls.MetroPanel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelEmployee.SuspendLayout();
            this.metroPanelEmployeeData.SuspendLayout();
            this.metroPanelEmployee.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.btnAddEmplyee.SuspendLayout();
            this.metroPanelUser.SuspendLayout();
            this.metroPanelEmployeeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelEmployee
            // 
            this.tableLayoutPanelEmployee.ColumnCount = 1;
            this.tableLayoutPanelEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelEmployee.Controls.Add(this.metroPanelEmployeeData, 0, 1);
            this.tableLayoutPanelEmployee.Controls.Add(this.metroPanelEmployeeView, 0, 0);
            this.tableLayoutPanelEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEmployee.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelEmployee.Name = "tableLayoutPanelEmployee";
            this.tableLayoutPanelEmployee.RowCount = 2;
            this.tableLayoutPanelEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanelEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanelEmployee.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelEmployee.TabIndex = 0;
            // 
            // metroPanelEmployeeData
            // 
            this.metroPanelEmployeeData.Controls.Add(this.metroPanelEmployee);
            this.metroPanelEmployeeData.Controls.Add(this.btnAddEmplyee);
            this.metroPanelEmployeeData.Controls.Add(this.metroPanelUser);
            this.metroPanelEmployeeData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelEmployeeData.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroPanelEmployeeData.HorizontalScrollbarBarColor = true;
            this.metroPanelEmployeeData.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelEmployeeData.HorizontalScrollbarSize = 10;
            this.metroPanelEmployeeData.Location = new System.Drawing.Point(3, 202);
            this.metroPanelEmployeeData.Name = "metroPanelEmployeeData";
            this.metroPanelEmployeeData.Size = new System.Drawing.Size(797, 245);
            this.metroPanelEmployeeData.TabIndex = 0;
            this.metroPanelEmployeeData.VerticalScrollbarBarColor = true;
            this.metroPanelEmployeeData.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelEmployeeData.VerticalScrollbarSize = 10;
            // 
            // metroPanelEmployee
            // 
            this.metroPanelEmployee.Controls.Add(this.metroLabel8);
            this.metroPanelEmployee.Controls.Add(this.metroDateTimeHireDate);
            this.metroPanelEmployee.Controls.Add(this.cbTimeSchedule);
            this.metroPanelEmployee.Controls.Add(this.metroLabel7);
            this.metroPanelEmployee.Controls.Add(this.cbSalary);
            this.metroPanelEmployee.Controls.Add(this.metroLabel6);
            this.metroPanelEmployee.Controls.Add(this.txtEmail);
            this.metroPanelEmployee.Controls.Add(this.metroLabel5);
            this.metroPanelEmployee.Controls.Add(this.txtPhoneNumber);
            this.metroPanelEmployee.Controls.Add(this.metroLabel4);
            this.metroPanelEmployee.Controls.Add(this.gbGender);
            this.metroPanelEmployee.Controls.Add(this.txtLastName);
            this.metroPanelEmployee.Controls.Add(this.txtFisrtName);
            this.metroPanelEmployee.Controls.Add(this.metroLabel3);
            this.metroPanelEmployee.Controls.Add(this.labelFirstName);
            this.metroPanelEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelEmployee.HorizontalScrollbarBarColor = true;
            this.metroPanelEmployee.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelEmployee.HorizontalScrollbarSize = 10;
            this.metroPanelEmployee.Location = new System.Drawing.Point(200, 0);
            this.metroPanelEmployee.Name = "metroPanelEmployee";
            this.metroPanelEmployee.Size = new System.Drawing.Size(477, 245);
            this.metroPanelEmployee.TabIndex = 4;
            this.metroPanelEmployee.VerticalScrollbarBarColor = true;
            this.metroPanelEmployee.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelEmployee.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(215, 181);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(63, 19);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Join Date";
            // 
            // metroDateTimeHireDate
            // 
            this.metroDateTimeHireDate.Location = new System.Drawing.Point(215, 203);
            this.metroDateTimeHireDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeHireDate.Name = "metroDateTimeHireDate";
            this.metroDateTimeHireDate.Size = new System.Drawing.Size(200, 29);
            this.metroDateTimeHireDate.TabIndex = 21;
            // 
            // cbTimeSchedule
            // 
            this.cbTimeSchedule.FormattingEnabled = true;
            this.cbTimeSchedule.ItemHeight = 23;
            this.cbTimeSchedule.Items.AddRange(new object[] {
            "3 Pm - 7 Pm",
            "7 Pm - 11 Pm"});
            this.cbTimeSchedule.Location = new System.Drawing.Point(6, 203);
            this.cbTimeSchedule.Name = "cbTimeSchedule";
            this.cbTimeSchedule.Size = new System.Drawing.Size(179, 29);
            this.cbTimeSchedule.TabIndex = 20;
            this.cbTimeSchedule.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 181);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(42, 19);
            this.metroLabel7.TabIndex = 19;
            this.metroLabel7.Text = "Time ";
            // 
            // cbSalary
            // 
            this.cbSalary.FormattingEnabled = true;
            this.cbSalary.ItemHeight = 23;
            this.cbSalary.Items.AddRange(new object[] {
            "25000",
            "20000",
            "18000",
            "15000",
            "12000",
            "10000",
            "8000"});
            this.cbSalary.Location = new System.Drawing.Point(215, 151);
            this.cbSalary.Name = "cbSalary";
            this.cbSalary.Size = new System.Drawing.Size(179, 29);
            this.cbSalary.TabIndex = 18;
            this.cbSalary.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(215, 129);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Salary";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 25);
            this.txtEmail.TabIndex = 16;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 129);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Email Address";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(215, 92);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(179, 25);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(215, 70);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Phone Number";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(6, 70);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(179, 56);
            this.gbGender.TabIndex = 12;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(88, 24);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(61, 15);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseSelectable = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(0, 24);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(49, 15);
            this.rbMale.TabIndex = 0;
            this.rbMale.Text = "Male";
            this.rbMale.UseSelectable = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(215, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(179, 25);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFisrtName
            // 
            this.txtFisrtName.Location = new System.Drawing.Point(6, 38);
            this.txtFisrtName.Name = "txtFisrtName";
            this.txtFisrtName.Size = new System.Drawing.Size(179, 25);
            this.txtFisrtName.TabIndex = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(215, 11);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(6, 11);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(74, 19);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Fisrt Name";
            // 
            // btnAddEmplyee
            // 
            this.btnAddEmplyee.Controls.Add(this.btnDeleteEmployee);
            this.btnAddEmplyee.Controls.Add(this.btnUpdateEmployee);
            this.btnAddEmplyee.Controls.Add(this.btnAddEmployee);
            this.btnAddEmplyee.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddEmplyee.HorizontalScrollbarBarColor = true;
            this.btnAddEmplyee.HorizontalScrollbarHighlightOnWheel = false;
            this.btnAddEmplyee.HorizontalScrollbarSize = 10;
            this.btnAddEmplyee.Location = new System.Drawing.Point(677, 0);
            this.btnAddEmplyee.Name = "btnAddEmplyee";
            this.btnAddEmplyee.Size = new System.Drawing.Size(120, 245);
            this.btnAddEmplyee.TabIndex = 3;
            this.btnAddEmplyee.VerticalScrollbarBarColor = true;
            this.btnAddEmplyee.VerticalScrollbarHighlightOnWheel = false;
            this.btnAddEmplyee.VerticalScrollbarSize = 10;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(33, 141);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmployee.TabIndex = 25;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseSelectable = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(33, 107);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateEmployee.TabIndex = 24;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseSelectable = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(33, 70);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmployee.TabIndex = 23;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseSelectable = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // metroPanelUser
            // 
            this.metroPanelUser.Controls.Add(this.btnAddUser);
            this.metroPanelUser.Controls.Add(this.txtPassword);
            this.metroPanelUser.Controls.Add(this.txtUserId);
            this.metroPanelUser.Controls.Add(this.metroLabelPassword);
            this.metroPanelUser.Controls.Add(this.metroLabel1);
            this.metroPanelUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanelUser.HorizontalScrollbarBarColor = true;
            this.metroPanelUser.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelUser.HorizontalScrollbarSize = 10;
            this.metroPanelUser.Location = new System.Drawing.Point(0, 0);
            this.metroPanelUser.Name = "metroPanelUser";
            this.metroPanelUser.Size = new System.Drawing.Size(200, 245);
            this.metroPanelUser.TabIndex = 2;
            this.metroPanelUser.VerticalScrollbarBarColor = true;
            this.metroPanelUser.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelUser.VerticalScrollbarSize = 10;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(59, 183);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Next";
            this.btnAddUser.UseSelectable = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(11, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 25);
            this.txtPassword.TabIndex = 10;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(11, 70);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(179, 25);
            this.txtUserId.TabIndex = 9;
            // 
            // metroLabelPassword
            // 
            this.metroLabelPassword.AutoSize = true;
            this.metroLabelPassword.Location = new System.Drawing.Point(11, 107);
            this.metroLabelPassword.Name = "metroLabelPassword";
            this.metroLabelPassword.Size = new System.Drawing.Size(63, 19);
            this.metroLabelPassword.TabIndex = 8;
            this.metroLabelPassword.Text = "Password";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "User Name";
            // 
            // metroPanelEmployeeView
            // 
            this.metroPanelEmployeeView.Controls.Add(this.dgvEmployee);
            this.metroPanelEmployeeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelEmployeeView.HorizontalScrollbarBarColor = true;
            this.metroPanelEmployeeView.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelEmployeeView.HorizontalScrollbarSize = 10;
            this.metroPanelEmployeeView.Location = new System.Drawing.Point(3, 3);
            this.metroPanelEmployeeView.Name = "metroPanelEmployeeView";
            this.metroPanelEmployeeView.Size = new System.Drawing.Size(797, 193);
            this.metroPanelEmployeeView.TabIndex = 1;
            this.metroPanelEmployeeView.VerticalScrollbarBarColor = true;
            this.metroPanelEmployeeView.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelEmployeeView.VerticalScrollbarSize = 10;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 25;
            this.dgvEmployee.Size = new System.Drawing.Size(797, 193);
            this.dgvEmployee.TabIndex = 2;
            this.dgvEmployee.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployee_CellMouseDoubleClick_1);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelEmployee);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.tableLayoutPanelEmployee.ResumeLayout(false);
            this.metroPanelEmployeeData.ResumeLayout(false);
            this.metroPanelEmployee.ResumeLayout(false);
            this.metroPanelEmployee.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.btnAddEmplyee.ResumeLayout(false);
            this.metroPanelUser.ResumeLayout(false);
            this.metroPanelUser.PerformLayout();
            this.metroPanelEmployeeView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEmployee;
        private MetroFramework.Controls.MetroPanel metroPanelEmployeeData;
        private MetroFramework.Controls.MetroPanel metroPanelUser;
        private MetroFramework.Controls.MetroPanel metroPanelEmployeeView;
        private MetroFramework.Controls.MetroPanel btnAddEmplyee;
        private MetroFramework.Controls.MetroButton btnAddUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserId;
        private MetroFramework.Controls.MetroLabel metroLabelPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private MetroFramework.Controls.MetroPanel metroPanelEmployee;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroDateTime metroDateTimeHireDate;
        private MetroFramework.Controls.MetroComboBox cbTimeSchedule;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbSalary;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox gbGender;
        private MetroFramework.Controls.MetroRadioButton rbFemale;
        private MetroFramework.Controls.MetroRadioButton rbMale;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFisrtName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel labelFirstName;
        private MetroFramework.Controls.MetroButton btnAddEmployee;
        private MetroFramework.Controls.MetroButton btnDeleteEmployee;
        private MetroFramework.Controls.MetroButton btnUpdateEmployee;
    }
}