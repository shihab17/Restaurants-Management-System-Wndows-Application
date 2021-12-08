namespace Restaurants_Management_System.Forms.Admin
{
    partial class ManageMenu
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
            this.tableLayoutPanelctegories = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanelCategoriesView = new MetroFramework.Controls.MetroPanel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.dgvSubCategories = new System.Windows.Forms.DataGridView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanelCategoryData = new MetroFramework.Controls.MetroPanel();
            this.btnDeleteSubCategory = new MetroFramework.Controls.MetroButton();
            this.btnUpdateSubCategory = new MetroFramework.Controls.MetroButton();
            this.btnAddSubCategory = new MetroFramework.Controls.MetroButton();
            this.txtSubCategory = new System.Windows.Forms.TextBox();
            this.labelSubCategory = new MetroFramework.Controls.MetroLabel();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.btnDeleteCategory = new MetroFramework.Controls.MetroButton();
            this.btnUpdateCatygory = new MetroFramework.Controls.MetroButton();
            this.btnAddCategory = new MetroFramework.Controls.MetroButton();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbSubCategory = new MetroFramework.Controls.MetroComboBox();
            this.btnDeleteMenu = new MetroFramework.Controls.MetroButton();
            this.btnUpdateMenu = new MetroFramework.Controls.MetroButton();
            this.btnAddMenu = new MetroFramework.Controls.MetroButton();
            this.txtMenuId = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.cbCategory = new MetroFramework.Controls.MetroComboBox();
            this.tableLayoutPanelctegories.SuspendLayout();
            this.metroPanelCategoriesView.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategories)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanelCategoryData.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelctegories
            // 
            this.tableLayoutPanelctegories.ColumnCount = 2;
            this.tableLayoutPanelctegories.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelctegories.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelctegories.Controls.Add(this.metroPanelCategoriesView, 0, 0);
            this.tableLayoutPanelctegories.Controls.Add(this.metroPanelCategoryData, 1, 0);
            this.tableLayoutPanelctegories.Controls.Add(this.metroPanel2, 0, 1);
            this.tableLayoutPanelctegories.Controls.Add(this.metroPanel5, 1, 1);
            this.tableLayoutPanelctegories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelctegories.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelctegories.Name = "tableLayoutPanelctegories";
            this.tableLayoutPanelctegories.RowCount = 2;
            this.tableLayoutPanelctegories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.94993F));
            this.tableLayoutPanelctegories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.05007F));
            this.tableLayoutPanelctegories.Size = new System.Drawing.Size(923, 502);
            this.tableLayoutPanelctegories.TabIndex = 0;
            // 
            // metroPanelCategoriesView
            // 
            this.metroPanelCategoriesView.Controls.Add(this.metroPanel6);
            this.metroPanelCategoriesView.Controls.Add(this.metroPanel1);
            this.metroPanelCategoriesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelCategoriesView.HorizontalScrollbarBarColor = true;
            this.metroPanelCategoriesView.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelCategoriesView.HorizontalScrollbarSize = 10;
            this.metroPanelCategoriesView.Location = new System.Drawing.Point(3, 3);
            this.metroPanelCategoriesView.Name = "metroPanelCategoriesView";
            this.metroPanelCategoriesView.Size = new System.Drawing.Size(455, 189);
            this.metroPanelCategoriesView.TabIndex = 0;
            this.metroPanelCategoriesView.VerticalScrollbarBarColor = true;
            this.metroPanelCategoriesView.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelCategoriesView.VerticalScrollbarSize = 10;
            // 
            // metroPanel6
            // 
            this.metroPanel6.Controls.Add(this.tableLayoutPanel1);
            this.metroPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(0, 37);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(455, 152);
            this.metroPanel6.TabIndex = 5;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvCategories, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvSubCategories, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 152);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvCategories
            // 
            this.dgvCategories.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvCategories.Location = new System.Drawing.Point(3, 3);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowTemplate.Height = 25;
            this.dgvCategories.Size = new System.Drawing.Size(221, 146);
            this.dgvCategories.TabIndex = 2;
            this.dgvCategories.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategories_CellMouseDoubleClick);
            // 
            // dgvSubCategories
            // 
            this.dgvSubCategories.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSubCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubCategories.Location = new System.Drawing.Point(230, 3);
            this.dgvSubCategories.Name = "dgvSubCategories";
            this.dgvSubCategories.RowTemplate.Height = 25;
            this.dgvSubCategories.Size = new System.Drawing.Size(222, 146);
            this.dgvSubCategories.TabIndex = 3;
            this.dgvSubCategories.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubCategories_CellMouseDoubleClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(455, 37);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(154, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Category List";
            // 
            // metroPanelCategoryData
            // 
            this.metroPanelCategoryData.Controls.Add(this.btnDeleteSubCategory);
            this.metroPanelCategoryData.Controls.Add(this.btnUpdateSubCategory);
            this.metroPanelCategoryData.Controls.Add(this.btnAddSubCategory);
            this.metroPanelCategoryData.Controls.Add(this.txtSubCategory);
            this.metroPanelCategoryData.Controls.Add(this.labelSubCategory);
            this.metroPanelCategoryData.Controls.Add(this.txtCategoryId);
            this.metroPanelCategoryData.Controls.Add(this.btnDeleteCategory);
            this.metroPanelCategoryData.Controls.Add(this.btnUpdateCatygory);
            this.metroPanelCategoryData.Controls.Add(this.btnAddCategory);
            this.metroPanelCategoryData.Controls.Add(this.txtCategoryName);
            this.metroPanelCategoryData.Controls.Add(this.metroLabel1);
            this.metroPanelCategoryData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelCategoryData.HorizontalScrollbarBarColor = true;
            this.metroPanelCategoryData.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelCategoryData.HorizontalScrollbarSize = 10;
            this.metroPanelCategoryData.Location = new System.Drawing.Point(464, 3);
            this.metroPanelCategoryData.Name = "metroPanelCategoryData";
            this.metroPanelCategoryData.Size = new System.Drawing.Size(456, 189);
            this.metroPanelCategoryData.TabIndex = 1;
            this.metroPanelCategoryData.VerticalScrollbarBarColor = true;
            this.metroPanelCategoryData.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelCategoryData.VerticalScrollbarSize = 10;
            // 
            // btnDeleteSubCategory
            // 
            this.btnDeleteSubCategory.Location = new System.Drawing.Point(117, 160);
            this.btnDeleteSubCategory.Name = "btnDeleteSubCategory";
            this.btnDeleteSubCategory.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSubCategory.TabIndex = 21;
            this.btnDeleteSubCategory.Text = "Delete";
            this.btnDeleteSubCategory.UseSelectable = true;
            this.btnDeleteSubCategory.Click += new System.EventHandler(this.btnDeleteSubCategory_Click);
            // 
            // btnUpdateSubCategory
            // 
            this.btnUpdateSubCategory.Location = new System.Drawing.Point(15, 160);
            this.btnUpdateSubCategory.Name = "btnUpdateSubCategory";
            this.btnUpdateSubCategory.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSubCategory.TabIndex = 20;
            this.btnUpdateSubCategory.Text = "Update";
            this.btnUpdateSubCategory.UseSelectable = true;
            this.btnUpdateSubCategory.Click += new System.EventHandler(this.btnUpdateSubCategory_Click);
            // 
            // btnAddSubCategory
            // 
            this.btnAddSubCategory.Location = new System.Drawing.Point(200, 102);
            this.btnAddSubCategory.Name = "btnAddSubCategory";
            this.btnAddSubCategory.Size = new System.Drawing.Size(106, 23);
            this.btnAddSubCategory.TabIndex = 19;
            this.btnAddSubCategory.Text = "Add Sub Category";
            this.btnAddSubCategory.UseSelectable = true;
            this.btnAddSubCategory.Click += new System.EventHandler(this.btnAddSubCategory_Click);
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.Location = new System.Drawing.Point(13, 102);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(179, 23);
            this.txtSubCategory.TabIndex = 18;
            // 
            // labelSubCategory
            // 
            this.labelSubCategory.AutoSize = true;
            this.labelSubCategory.Location = new System.Drawing.Point(13, 79);
            this.labelSubCategory.Name = "labelSubCategory";
            this.labelSubCategory.Size = new System.Drawing.Size(130, 19);
            this.labelSubCategory.TabIndex = 17;
            this.labelSubCategory.Text = "Sub Category Name";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(13, 4);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(100, 23);
            this.txtCategoryId.TabIndex = 16;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(117, 131);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCategory.TabIndex = 15;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseSelectable = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCatygory
            // 
            this.btnUpdateCatygory.Location = new System.Drawing.Point(13, 131);
            this.btnUpdateCatygory.Name = "btnUpdateCatygory";
            this.btnUpdateCatygory.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCatygory.TabIndex = 14;
            this.btnUpdateCatygory.Text = "Update";
            this.btnUpdateCatygory.UseSelectable = true;
            this.btnUpdateCatygory.Click += new System.EventHandler(this.btnUpdateCatygory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(200, 52);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(83, 23);
            this.btnAddCategory.TabIndex = 13;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseSelectable = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(15, 52);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(179, 23);
            this.txtCategoryName.TabIndex = 12;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Category Name";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroPanel4);
            this.metroPanel2.Controls.Add(this.metroPanel3);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 198);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(455, 301);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.dgvMenu);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 41);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(455, 260);
            this.metroPanel4.TabIndex = 3;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // dgvMenu
            // 
            this.dgvMenu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(0, 0);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowTemplate.Height = 25;
            this.dgvMenu.Size = new System.Drawing.Size(455, 260);
            this.dgvMenu.TabIndex = 2;
            this.dgvMenu.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMenu_CellMouseDoubleClick);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(455, 41);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(154, 11);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Menu List";
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.metroLabel7);
            this.metroPanel5.Controls.Add(this.cbSubCategory);
            this.metroPanel5.Controls.Add(this.btnDeleteMenu);
            this.metroPanel5.Controls.Add(this.btnUpdateMenu);
            this.metroPanel5.Controls.Add(this.btnAddMenu);
            this.metroPanel5.Controls.Add(this.txtMenuId);
            this.metroPanel5.Controls.Add(this.metroLabel6);
            this.metroPanel5.Controls.Add(this.metroLabel5);
            this.metroPanel5.Controls.Add(this.metroLabel4);
            this.metroPanel5.Controls.Add(this.txtPrice);
            this.metroPanel5.Controls.Add(this.txtItemName);
            this.metroPanel5.Controls.Add(this.cbCategory);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(464, 198);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(456, 301);
            this.metroPanel5.TabIndex = 3;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            this.metroPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel5_Paint);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(200, 47);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(92, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Sub-Category";
            // 
            // cbSubCategory
            // 
            this.cbSubCategory.FormattingEnabled = true;
            this.cbSubCategory.ItemHeight = 23;
            this.cbSubCategory.Location = new System.Drawing.Point(200, 70);
            this.cbSubCategory.Name = "cbSubCategory";
            this.cbSubCategory.Size = new System.Drawing.Size(140, 29);
            this.cbSubCategory.TabIndex = 12;
            this.cbSubCategory.UseSelectable = true;
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Location = new System.Drawing.Point(233, 190);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMenu.TabIndex = 11;
            this.btnDeleteMenu.Text = "Delete";
            this.btnDeleteMenu.UseSelectable = true;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
            // 
            // btnUpdateMenu
            // 
            this.btnUpdateMenu.Location = new System.Drawing.Point(119, 190);
            this.btnUpdateMenu.Name = "btnUpdateMenu";
            this.btnUpdateMenu.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMenu.TabIndex = 10;
            this.btnUpdateMenu.Text = "Update";
            this.btnUpdateMenu.UseSelectable = true;
            this.btnUpdateMenu.Click += new System.EventHandler(this.btnUpdateMenu_Click);
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(26, 190);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(75, 23);
            this.btnAddMenu.TabIndex = 9;
            this.btnAddMenu.Text = "Add ";
            this.btnAddMenu.UseSelectable = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // txtMenuId
            // 
            this.txtMenuId.Location = new System.Drawing.Point(15, 7);
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.Size = new System.Drawing.Size(64, 23);
            this.txtMenuId.TabIndex = 8;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(200, 111);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Price";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 111);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Item Name";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 47);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Category";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(200, 133);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(135, 23);
            this.txtPrice.TabIndex = 4;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(15, 133);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(169, 23);
            this.txtItemName.TabIndex = 3;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 23;
            this.cbCategory.Location = new System.Drawing.Point(15, 70);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(140, 29);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.UseSelectable = true;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // ManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 502);
            this.Controls.Add(this.tableLayoutPanelctegories);
            this.Name = "ManageMenu";
            this.Text = "CategoryForm";
            this.tableLayoutPanelctegories.ResumeLayout(false);
            this.metroPanelCategoriesView.ResumeLayout(false);
            this.metroPanel6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategories)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanelCategoryData.ResumeLayout(false);
            this.metroPanelCategoryData.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelctegories;
        private MetroFramework.Controls.MetroPanel metroPanelCategoriesView;
        private System.Windows.Forms.DataGridView dgvCategories;
        private MetroFramework.Controls.MetroPanel metroPanelCategoryData;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnDeleteCategory;
        private MetroFramework.Controls.MetroButton btnUpdateCatygory;
        private MetroFramework.Controls.MetroButton btnAddCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryId;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.DataGridView dgvMenu;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroButton btnDeleteMenu;
        private MetroFramework.Controls.MetroButton btnUpdateMenu;
        private MetroFramework.Controls.MetroButton btnAddMenu;
        private System.Windows.Forms.TextBox txtMenuId;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtItemName;
        private MetroFramework.Controls.MetroComboBox cbCategory;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvSubCategories;
        private MetroFramework.Controls.MetroButton btnDeleteSubCategory;
        private MetroFramework.Controls.MetroButton btnUpdateSubCategory;
        private MetroFramework.Controls.MetroButton btnAddSubCategory;
        private System.Windows.Forms.TextBox txtSubCategory;
        private MetroFramework.Controls.MetroLabel labelSubCategory;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbSubCategory;
    }
}