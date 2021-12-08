namespace Restaurants_Management_System.Forms.Manager
{
    partial class ManageTable
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanelViewTable = new MetroFramework.Controls.MetroPanel();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.metroPanelTableData = new MetroFramework.Controls.MetroPanel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnDeleteTable = new MetroFramework.Controls.MetroButton();
            this.btnUpdateTable = new MetroFramework.Controls.MetroButton();
            this.btnAddTable = new MetroFramework.Controls.MetroButton();
            this.cbTableType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTableId = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanelViewTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.metroPanelTableData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.52874F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.47126F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanelViewTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroPanelTableData, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroPanelViewTable
            // 
            this.metroPanelViewTable.Controls.Add(this.dgvTables);
            this.metroPanelViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelViewTable.HorizontalScrollbarBarColor = true;
            this.metroPanelViewTable.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelViewTable.HorizontalScrollbarSize = 10;
            this.metroPanelViewTable.Location = new System.Drawing.Point(3, 3);
            this.metroPanelViewTable.Name = "metroPanelViewTable";
            this.metroPanelViewTable.Size = new System.Drawing.Size(334, 444);
            this.metroPanelViewTable.TabIndex = 0;
            this.metroPanelViewTable.VerticalScrollbarBarColor = true;
            this.metroPanelViewTable.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelViewTable.VerticalScrollbarSize = 10;
            // 
            // dgvTables
            // 
            this.dgvTables.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTables.Location = new System.Drawing.Point(0, 0);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.RowTemplate.Height = 25;
            this.dgvTables.Size = new System.Drawing.Size(334, 444);
            this.dgvTables.TabIndex = 2;
            this.dgvTables.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTables_CellMouseDoubleClick);
            // 
            // metroPanelTableData
            // 
            this.metroPanelTableData.Controls.Add(this.txtStatus);
            this.metroPanelTableData.Controls.Add(this.btnDeleteTable);
            this.metroPanelTableData.Controls.Add(this.btnUpdateTable);
            this.metroPanelTableData.Controls.Add(this.btnAddTable);
            this.metroPanelTableData.Controls.Add(this.cbTableType);
            this.metroPanelTableData.Controls.Add(this.metroLabel2);
            this.metroPanelTableData.Controls.Add(this.txtTableId);
            this.metroPanelTableData.Controls.Add(this.metroLabel1);
            this.metroPanelTableData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelTableData.HorizontalScrollbarBarColor = true;
            this.metroPanelTableData.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelTableData.HorizontalScrollbarSize = 10;
            this.metroPanelTableData.Location = new System.Drawing.Point(343, 3);
            this.metroPanelTableData.Name = "metroPanelTableData";
            this.metroPanelTableData.Size = new System.Drawing.Size(454, 444);
            this.metroPanelTableData.TabIndex = 1;
            this.metroPanelTableData.VerticalScrollbarBarColor = true;
            this.metroPanelTableData.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelTableData.VerticalScrollbarSize = 10;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(23, 189);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(147, 23);
            this.txtStatus.TabIndex = 9;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(206, 143);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTable.TabIndex = 8;
            this.btnDeleteTable.Text = "Delete Table";
            this.btnDeleteTable.UseSelectable = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnUpdateTable
            // 
            this.btnUpdateTable.Location = new System.Drawing.Point(206, 114);
            this.btnUpdateTable.Name = "btnUpdateTable";
            this.btnUpdateTable.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTable.TabIndex = 7;
            this.btnUpdateTable.Text = "Update Table";
            this.btnUpdateTable.UseSelectable = true;
            this.btnUpdateTable.Click += new System.EventHandler(this.btnUpdateTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(206, 82);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 23);
            this.btnAddTable.TabIndex = 6;
            this.btnAddTable.Text = "Add Table";
            this.btnAddTable.UseSelectable = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // cbTableType
            // 
            this.cbTableType.FormattingEnabled = true;
            this.cbTableType.ItemHeight = 23;
            this.cbTableType.Items.AddRange(new object[] {
            "Big Table",
            "Small Table"});
            this.cbTableType.Location = new System.Drawing.Point(23, 136);
            this.cbTableType.Name = "cbTableType";
            this.cbTableType.Size = new System.Drawing.Size(146, 29);
            this.cbTableType.TabIndex = 5;
            this.cbTableType.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Table Type";
            // 
            // txtTableId
            // 
            this.txtTableId.Location = new System.Drawing.Point(22, 82);
            this.txtTableId.Name = "txtTableId";
            this.txtTableId.Size = new System.Drawing.Size(147, 23);
            this.txtTableId.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Table Id";
            // 
            // ManageTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageTable";
            this.Text = "ManageTable";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanelViewTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.metroPanelTableData.ResumeLayout(false);
            this.metroPanelTableData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanelViewTable;
        private System.Windows.Forms.DataGridView dgvTables;
        private MetroFramework.Controls.MetroPanel metroPanelTableData;
        private MetroFramework.Controls.MetroButton btnDeleteTable;
        private MetroFramework.Controls.MetroButton btnUpdateTable;
        private MetroFramework.Controls.MetroButton btnAddTable;
        private MetroFramework.Controls.MetroComboBox cbTableType;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txtTableId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtStatus;
    }
}