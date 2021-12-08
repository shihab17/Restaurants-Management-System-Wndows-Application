namespace Restaurants_Management_System.Forms.Manager
{
    partial class Manager
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
            this.metroPanelManagerTop = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tabControlManager = new System.Windows.Forms.TabControl();
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.tabPageManageOrder = new System.Windows.Forms.TabPage();
            this.btnOrder = new MetroFramework.Controls.MetroButton();
            this.tabPageManageTable = new System.Windows.Forms.TabPage();
            this.btnManageTable = new MetroFramework.Controls.MetroButton();
            this.metroPanelTopRight = new MetroFramework.Controls.MetroPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.metroPanelManagerMain = new MetroFramework.Controls.MetroPanel();
            this.metroPanelManagerTop.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.tabControlManager.SuspendLayout();
            this.tabPageManageOrder.SuspendLayout();
            this.tabPageManageTable.SuspendLayout();
            this.metroPanelTopRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelManagerTop
            // 
            this.metroPanelManagerTop.Controls.Add(this.metroPanel1);
            this.metroPanelManagerTop.Controls.Add(this.metroPanelTopRight);
            this.metroPanelManagerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelManagerTop.HorizontalScrollbarBarColor = true;
            this.metroPanelManagerTop.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelManagerTop.HorizontalScrollbarSize = 10;
            this.metroPanelManagerTop.Location = new System.Drawing.Point(0, 0);
            this.metroPanelManagerTop.Name = "metroPanelManagerTop";
            this.metroPanelManagerTop.Size = new System.Drawing.Size(800, 93);
            this.metroPanelManagerTop.TabIndex = 0;
            this.metroPanelManagerTop.VerticalScrollbarBarColor = true;
            this.metroPanelManagerTop.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelManagerTop.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tabControlManager);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(676, 93);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tabControlManager
            // 
            this.tabControlManager.Controls.Add(this.tabPageDashboard);
            this.tabControlManager.Controls.Add(this.tabPageManageOrder);
            this.tabControlManager.Controls.Add(this.tabPageManageTable);
            this.tabControlManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlManager.Location = new System.Drawing.Point(0, 0);
            this.tabControlManager.Name = "tabControlManager";
            this.tabControlManager.SelectedIndex = 0;
            this.tabControlManager.Size = new System.Drawing.Size(676, 93);
            this.tabControlManager.TabIndex = 2;
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.Location = new System.Drawing.Point(4, 24);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDashboard.Size = new System.Drawing.Size(668, 65);
            this.tabPageDashboard.TabIndex = 0;
            this.tabPageDashboard.Text = "Dashboard";
            this.tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // tabPageManageOrder
            // 
            this.tabPageManageOrder.Controls.Add(this.btnOrder);
            this.tabPageManageOrder.Location = new System.Drawing.Point(4, 24);
            this.tabPageManageOrder.Name = "tabPageManageOrder";
            this.tabPageManageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageOrder.Size = new System.Drawing.Size(668, 65);
            this.tabPageManageOrder.TabIndex = 1;
            this.tabPageManageOrder.Text = "Manage Order";
            this.tabPageManageOrder.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrder.Location = new System.Drawing.Point(3, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 59);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseSelectable = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // tabPageManageTable
            // 
            this.tabPageManageTable.Controls.Add(this.btnManageTable);
            this.tabPageManageTable.Location = new System.Drawing.Point(4, 24);
            this.tabPageManageTable.Name = "tabPageManageTable";
            this.tabPageManageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageTable.Size = new System.Drawing.Size(668, 65);
            this.tabPageManageTable.TabIndex = 2;
            this.tabPageManageTable.Text = "Manage Table";
            this.tabPageManageTable.UseVisualStyleBackColor = true;
            // 
            // btnManageTable
            // 
            this.btnManageTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManageTable.Location = new System.Drawing.Point(3, 3);
            this.btnManageTable.Name = "btnManageTable";
            this.btnManageTable.Size = new System.Drawing.Size(93, 59);
            this.btnManageTable.TabIndex = 0;
            this.btnManageTable.Text = "Manage Table";
            this.btnManageTable.UseSelectable = true;
            this.btnManageTable.Click += new System.EventHandler(this.btnManageTable_Click);
            // 
            // metroPanelTopRight
            // 
            this.metroPanelTopRight.Controls.Add(this.btnLogout);
            this.metroPanelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanelTopRight.HorizontalScrollbarBarColor = true;
            this.metroPanelTopRight.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelTopRight.HorizontalScrollbarSize = 10;
            this.metroPanelTopRight.Location = new System.Drawing.Point(676, 0);
            this.metroPanelTopRight.Name = "metroPanelTopRight";
            this.metroPanelTopRight.Size = new System.Drawing.Size(124, 93);
            this.metroPanelTopRight.TabIndex = 2;
            this.metroPanelTopRight.VerticalScrollbarBarColor = true;
            this.metroPanelTopRight.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelTopRight.VerticalScrollbarSize = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(124, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // metroPanelManagerMain
            // 
            this.metroPanelManagerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelManagerMain.HorizontalScrollbarBarColor = true;
            this.metroPanelManagerMain.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelManagerMain.HorizontalScrollbarSize = 10;
            this.metroPanelManagerMain.Location = new System.Drawing.Point(0, 93);
            this.metroPanelManagerMain.Name = "metroPanelManagerMain";
            this.metroPanelManagerMain.Size = new System.Drawing.Size(800, 357);
            this.metroPanelManagerMain.TabIndex = 1;
            this.metroPanelManagerMain.VerticalScrollbarBarColor = true;
            this.metroPanelManagerMain.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelManagerMain.VerticalScrollbarSize = 10;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanelManagerMain);
            this.Controls.Add(this.metroPanelManagerTop);
            this.Name = "Manager";
            this.Text = "Manager";
            this.metroPanelManagerTop.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.tabControlManager.ResumeLayout(false);
            this.tabPageManageOrder.ResumeLayout(false);
            this.tabPageManageTable.ResumeLayout(false);
            this.metroPanelTopRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelManagerTop;
        private MetroFramework.Controls.MetroPanel metroPanelManagerMain;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TabControl tabControlManager;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.TabPage tabPageManageOrder;
        private System.Windows.Forms.TabPage tabPageManageTable;
        private MetroFramework.Controls.MetroButton btnManageTable;
        private MetroFramework.Controls.MetroPanel metroPanelTopRight;
        private System.Windows.Forms.Button btnLogout;
        private MetroFramework.Controls.MetroButton btnOrder;
    }
}