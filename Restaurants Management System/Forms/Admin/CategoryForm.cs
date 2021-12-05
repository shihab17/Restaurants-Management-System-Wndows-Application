using BusinessLayer;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurants_Management_System.Forms.Admin
{
    public partial class CategoryForm : Form
    {
        Categories categories = new Categories();
        public CategoryForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            btnUpdateCatygory.Visible = false;
            btnDeleteCategory.Visible = false;
            txtCategoryId.Visible = false;
            txtCategoryId.Enabled = false;
            dgvCategories.DataSource = categories.GetAllCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            bool isInsertCategory = categories.IsInsert(txtCategoryName.Text);
            if (isInsertCategory)
            {
                MessageBox.Show("Succefully Insert");
                dgvCategories.DataSource = categories.GetAllCategories();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnUpdateCatygory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryId = Int32.Parse(txtCategoryId.Text);
            category.CategoryName = txtCategoryName.Text;
            bool isUpdateCategory = categories.IsUpdate(category);
            if (isUpdateCategory)
            {
                MessageBox.Show("Succefully Update");
                dgvCategories.DataSource = categories.GetAllCategories();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void dgvCategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAddCategory.Visible = false;
            btnUpdateCatygory.Visible = true;
            btnDeleteCategory.Visible = true;
            txtCategoryId.Visible=true;
            var categoryId = dgvCategories.SelectedRows[0].Cells[0].Value.ToString();
            var categoryName = dgvCategories.SelectedRows[0].Cells[1].Value.ToString();

            txtCategoryId.Text = categoryId;
            txtCategoryName.Text = categoryName;

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            bool isDeleteCategory = categories.IsDelete(Int32.Parse(txtCategoryId.Text));
            if (isDeleteCategory)
            {
                MessageBox.Show("Succefully Deleted");
                dgvCategories.DataSource = categories.GetAllCategories();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
