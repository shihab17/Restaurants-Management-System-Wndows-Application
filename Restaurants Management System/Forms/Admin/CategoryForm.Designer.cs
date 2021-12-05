namespace Restaurants_Management_System.Forms.Admin
{
    partial class CategoryForm
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
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.metroPanelCategoryData = new MetroFramework.Controls.MetroPanel();
            this.btnDeleteCategory = new MetroFramework.Controls.MetroButton();
            this.btnUpdateCatygory = new MetroFramework.Controls.MetroButton();
            this.btnAddCategory = new MetroFramework.Controls.MetroButton();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelctegories.SuspendLayout();
            this.metroPanelCategoriesView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.metroPanelCategoryData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelctegories
            // 
            this.tableLayoutPanelctegories.ColumnCount = 2;
            this.tableLayoutPanelctegories.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelctegories.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelctegories.Controls.Add(this.metroPanelCategoriesView, 0, 0);
            this.tableLayoutPanelctegories.Controls.Add(this.metroPanelCategoryData, 1, 0);
            this.tableLayoutPanelctegories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelctegories.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelctegories.Name = "tableLayoutPanelctegories";
            this.tableLayoutPanelctegories.RowCount = 1;
            this.tableLayoutPanelctegories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelctegories.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelctegories.TabIndex = 0;
            // 
            // metroPanelCategoriesView
            // 
            this.metroPanelCategoriesView.Controls.Add(this.dgvCategories);
            this.metroPanelCategoriesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelCategoriesView.HorizontalScrollbarBarColor = true;
            this.metroPanelCategoriesView.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelCategoriesView.HorizontalScrollbarSize = 10;
            this.metroPanelCategoriesView.Location = new System.Drawing.Point(3, 3);
            this.metroPanelCategoriesView.Name = "metroPanelCategoriesView";
            this.metroPanelCategoriesView.Size = new System.Drawing.Size(394, 444);
            this.metroPanelCategoriesView.TabIndex = 0;
            this.metroPanelCategoriesView.VerticalScrollbarBarColor = true;
            this.metroPanelCategoriesView.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelCategoriesView.VerticalScrollbarSize = 10;
            // 
            // dgvCategories
            // 
            this.dgvCategories.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvCategories.Location = new System.Drawing.Point(0, 0);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowTemplate.Height = 25;
            this.dgvCategories.Size = new System.Drawing.Size(394, 444);
            this.dgvCategories.TabIndex = 2;
            this.dgvCategories.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategories_CellMouseDoubleClick);
            // 
            // metroPanelCategoryData
            // 
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
            this.metroPanelCategoryData.Location = new System.Drawing.Point(403, 3);
            this.metroPanelCategoryData.Name = "metroPanelCategoryData";
            this.metroPanelCategoryData.Size = new System.Drawing.Size(394, 444);
            this.metroPanelCategoryData.TabIndex = 1;
            this.metroPanelCategoryData.VerticalScrollbarBarColor = true;
            this.metroPanelCategoryData.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelCategoryData.VerticalScrollbarSize = 10;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(29, 260);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCategory.TabIndex = 15;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseSelectable = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCatygory
            // 
            this.btnUpdateCatygory.Location = new System.Drawing.Point(29, 216);
            this.btnUpdateCatygory.Name = "btnUpdateCatygory";
            this.btnUpdateCatygory.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCatygory.TabIndex = 14;
            this.btnUpdateCatygory.Text = "Update";
            this.btnUpdateCatygory.UseSelectable = true;
            this.btnUpdateCatygory.Click += new System.EventHandler(this.btnUpdateCatygory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(26, 162);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(115, 23);
            this.btnAddCategory.TabIndex = 13;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseSelectable = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(26, 119);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(179, 23);
            this.txtCategoryName.TabIndex = 12;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Category Name";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(26, 45);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(100, 23);
            this.txtCategoryId.TabIndex = 16;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelctegories);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.tableLayoutPanelctegories.ResumeLayout(false);
            this.metroPanelCategoriesView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.metroPanelCategoryData.ResumeLayout(false);
            this.metroPanelCategoryData.PerformLayout();
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
    }
}