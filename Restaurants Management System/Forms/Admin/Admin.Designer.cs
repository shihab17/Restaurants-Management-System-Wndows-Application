
namespace Restaurants_Management_System.Forms.Admin
{
    partial class Admin
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
            this.metroPanelTop = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabPageManageEmployee = new System.Windows.Forms.TabPage();
            this.btnWaiter = new MetroFramework.Controls.MetroButton();
            this.btnChef = new MetroFramework.Controls.MetroButton();
            this.btnManager = new MetroFramework.Controls.MetroButton();
            this.tabPageManageFoodItems = new System.Windows.Forms.TabPage();
            this.metroPanelAdminMain = new MetroFramework.Controls.MetroPanel();
            this.btnCategory = new MetroFramework.Controls.MetroButton();
            this.btnItems = new MetroFramework.Controls.MetroButton();
            this.metroPanelTop.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageDashboard.SuspendLayout();
            this.tabPageManageEmployee.SuspendLayout();
            this.tabPageManageFoodItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelTop
            // 
            this.metroPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroPanelTop.Controls.Add(this.metroPanel1);
            this.metroPanelTop.Controls.Add(this.tabControlAdmin);
            this.metroPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.metroPanelTop.HorizontalScrollbarBarColor = true;
            this.metroPanelTop.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelTop.HorizontalScrollbarSize = 10;
            this.metroPanelTop.Location = new System.Drawing.Point(0, 0);
            this.metroPanelTop.Name = "metroPanelTop";
            this.metroPanelTop.Size = new System.Drawing.Size(914, 86);
            this.metroPanelTop.TabIndex = 0;
            this.metroPanelTop.VerticalScrollbarBarColor = true;
            this.metroPanelTop.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelTop.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnLogout);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(819, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(95, 86);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageDashboard);
            this.tabControlAdmin.Controls.Add(this.tabPageManageEmployee);
            this.tabControlAdmin.Controls.Add(this.tabPageManageFoodItems);
            this.tabControlAdmin.Location = new System.Drawing.Point(3, 3);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(799, 74);
            this.tabControlAdmin.TabIndex = 2;
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.Controls.Add(this.metroLabel1);
            this.tabPageDashboard.Location = new System.Drawing.Point(4, 26);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDashboard.Size = new System.Drawing.Size(791, 44);
            this.tabPageDashboard.TabIndex = 0;
            this.tabPageDashboard.Text = "Dashboard";
            this.tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(18, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Dashboard";
            // 
            // tabPageManageEmployee
            // 
            this.tabPageManageEmployee.Controls.Add(this.btnWaiter);
            this.tabPageManageEmployee.Controls.Add(this.btnChef);
            this.tabPageManageEmployee.Controls.Add(this.btnManager);
            this.tabPageManageEmployee.Location = new System.Drawing.Point(4, 26);
            this.tabPageManageEmployee.Name = "tabPageManageEmployee";
            this.tabPageManageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageEmployee.Size = new System.Drawing.Size(791, 44);
            this.tabPageManageEmployee.TabIndex = 1;
            this.tabPageManageEmployee.Text = "Manamge Employee";
            this.tabPageManageEmployee.UseVisualStyleBackColor = true;
            // 
            // btnWaiter
            // 
            this.btnWaiter.BackColor = System.Drawing.Color.Transparent;
            this.btnWaiter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWaiter.Location = new System.Drawing.Point(221, 3);
            this.btnWaiter.Name = "btnWaiter";
            this.btnWaiter.Size = new System.Drawing.Size(109, 38);
            this.btnWaiter.TabIndex = 2;
            this.btnWaiter.Text = "Waiter";
            this.btnWaiter.UseSelectable = true;
            this.btnWaiter.UseVisualStyleBackColor = false;
            this.btnWaiter.Click += new System.EventHandler(this.btnWaiter_Click);
            // 
            // btnChef
            // 
            this.btnChef.BackColor = System.Drawing.Color.Transparent;
            this.btnChef.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChef.Location = new System.Drawing.Point(112, 3);
            this.btnChef.Name = "btnChef";
            this.btnChef.Size = new System.Drawing.Size(109, 38);
            this.btnChef.TabIndex = 1;
            this.btnChef.Text = "Chef";
            this.btnChef.UseSelectable = true;
            this.btnChef.UseVisualStyleBackColor = false;
            this.btnChef.Click += new System.EventHandler(this.btnChef_Click);
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.Transparent;
            this.btnManager.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManager.Location = new System.Drawing.Point(3, 3);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(109, 38);
            this.btnManager.TabIndex = 0;
            this.btnManager.Text = " Manager";
            this.btnManager.UseSelectable = true;
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // tabPageManageFoodItems
            // 
            this.tabPageManageFoodItems.Controls.Add(this.btnItems);
            this.tabPageManageFoodItems.Controls.Add(this.btnCategory);
            this.tabPageManageFoodItems.Location = new System.Drawing.Point(4, 26);
            this.tabPageManageFoodItems.Name = "tabPageManageFoodItems";
            this.tabPageManageFoodItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageFoodItems.Size = new System.Drawing.Size(791, 44);
            this.tabPageManageFoodItems.TabIndex = 2;
            this.tabPageManageFoodItems.Text = "Manage Food Items";
            this.tabPageManageFoodItems.UseVisualStyleBackColor = true;
            // 
            // metroPanelAdminMain
            // 
            this.metroPanelAdminMain.BackColor = System.Drawing.SystemColors.Window;
            this.metroPanelAdminMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAdminMain.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminMain.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminMain.HorizontalScrollbarSize = 10;
            this.metroPanelAdminMain.Location = new System.Drawing.Point(0, 86);
            this.metroPanelAdminMain.Name = "metroPanelAdminMain";
            this.metroPanelAdminMain.Size = new System.Drawing.Size(914, 424);
            this.metroPanelAdminMain.TabIndex = 1;
            this.metroPanelAdminMain.VerticalScrollbarBarColor = true;
            this.metroPanelAdminMain.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminMain.VerticalScrollbarSize = 10;
            // 
            // btnCategory
            // 
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCategory.Location = new System.Drawing.Point(3, 3);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(75, 38);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseSelectable = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnItems
            // 
            this.btnItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnItems.Location = new System.Drawing.Point(78, 3);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(75, 38);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "Items";
            this.btnItems.UseSelectable = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(914, 510);
            this.Controls.Add(this.metroPanelAdminMain);
            this.Controls.Add(this.metroPanelTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Admin";
            this.Text = "Admin";
            this.metroPanelTop.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageDashboard.ResumeLayout(false);
            this.tabPageDashboard.PerformLayout();
            this.tabPageManageEmployee.ResumeLayout(false);
            this.tabPageManageFoodItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelTop;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TabPage tabPageManageEmployee;
        private MetroFramework.Controls.MetroButton btnManager;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnWaiter;
        private MetroFramework.Controls.MetroButton btnChef;
        private System.Windows.Forms.TabPage tabPageManageFoodItems;
        private MetroFramework.Controls.MetroPanel metroPanelAdminMain;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnItems;
        private MetroFramework.Controls.MetroButton btnCategory;
    }
}