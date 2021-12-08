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
    public partial class ManageMenu : Form
    {
        Categories categories = new Categories();
        SubCategories SubCategories = new SubCategories();
        Items items = new Items();
        public ManageMenu()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            btnUpdateCatygory.Visible = false;
            btnDeleteCategory.Visible = false;

            btnAddSubCategory.Visible = false;
            btnUpdateSubCategory.Visible = false;   
            btnDeleteSubCategory.Visible = false;

            btnUpdateMenu.Visible = false;
            btnDeleteMenu.Visible = false;

            txtCategoryId.Visible = false;
            txtCategoryId.Enabled = false;
            txtSubCategory.Visible = false;
            txtMenuId.Visible = false;
            txtMenuId.Enabled = false;

            labelSubCategory.Visible = false;

            dgvCategories.DataSource = categories.GetAllCategories();
            dgvSubCategories.DataSource = SubCategories.GetAllSubCategories();
            dgvMenu.DataSource = items.GetAllItems();
            GetCategoryCombo();
        }

        private void GetCategoryCombo()
        {
            List<Category> data = categories.GetAllCategories();
            foreach (Category c in data)
            {
                cbCategory.Items.Add(c.CategoryName);
            } 
        }
        private void GetSubCategoryCombo()
        {
            cbSubCategory.Items.Clear();
            string categoryName = cbCategory.SelectedItem.ToString();
            List<SubCategory> data = SubCategories.GetSubCategoryByCategoryName(categoryName);
            foreach (SubCategory c in data)
            {
                cbSubCategory.Items.Add(c.SubCategoryName);
            }
        }

        private void RefreshCategoryForm()
        {
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
            txtSubCategory.Text = "";
            cbCategory.DataSource = items.GetAllItems();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            bool isInsertCategory = categories.IsInsert(txtCategoryName.Text);
            if (isInsertCategory)
            {
                MessageBox.Show("Succefully Insert");
                dgvCategories.DataSource = categories.GetAllCategories();
                RefreshCategoryForm();
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
                RefreshCategoryForm();
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
            btnUpdateSubCategory.Visible = false;
            btnDeleteSubCategory.Visible = false;


            labelSubCategory.Visible = true;
            txtSubCategory.Visible = true;
            btnAddSubCategory.Visible = true;

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
                RefreshCategoryForm();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnAddSubCategory_Click(object sender, EventArgs e)
        {
            bool isIsertSubCategories =  SubCategories.IsInsert(txtSubCategory.Text, txtCategoryName.Text);
            if (isIsertSubCategories)
            {
                MessageBox.Show("Succefully Insert");
                dgvSubCategories.DataSource = SubCategories.GetAllSubCategories();
                RefreshCategoryForm();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void dgvSubCategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAddSubCategory.Visible = false;
            btnUpdateCatygory.Visible = false;
            btnDeleteCategory.Visible = false;
            btnAddCategory.Visible = false;

            btnUpdateSubCategory.Visible = true;
            btnDeleteSubCategory.Visible = true;
            txtCategoryName.Enabled = false;
            txtCategoryId.Visible = true;
            txtSubCategory.Visible = true;
            labelSubCategory.Visible = true;

            var subCategoryId = dgvSubCategories.SelectedRows[0].Cells[0].Value.ToString();
            var subCategoryName = dgvSubCategories.SelectedRows[0].Cells[1].Value.ToString();
            var categoryName = dgvSubCategories.SelectedRows[0].Cells[2].Value.ToString();
            txtCategoryId.Text = subCategoryId;
            txtCategoryName.Text = categoryName;
            txtSubCategory.Text = subCategoryName;
        }

        private void btnUpdateSubCategory_Click(object sender, EventArgs e)
        {
            SubCategory subCategory = new SubCategory();
            subCategory.SubCategoryId = Int32.Parse(txtCategoryId.Text) ;
            subCategory.CategoryName = txtCategoryName.Text;
            subCategory.SubCategoryName = txtSubCategory.Text;
            bool isUpdateSubCategory = SubCategories.IsUpdate(subCategory);
            if (isUpdateSubCategory)
            {
                MessageBox.Show("Succefully Update");
                dgvSubCategories.DataSource = SubCategories.GetAllSubCategories();
                RefreshCategoryForm();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnDeleteSubCategory_Click(object sender, EventArgs e)
        {
            int subCategoryId = Int32.Parse(txtCategoryId.Text);
            bool isDeleteSubCategory = SubCategories.IsDelete(subCategoryId);
            if (isDeleteSubCategory)
            {
                MessageBox.Show("Succefully Update");
                dgvSubCategories.DataSource = SubCategories.GetAllSubCategories();
                RefreshCategoryForm();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void metroPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSubCategoryCombo();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            string categoryName = cbCategory.SelectedItem.ToString();
            string subCategoryName = cbSubCategory.SelectedItem.ToString();
            string itemName = txtItemName.Text.ToString();
            int price = Int32.Parse(txtPrice.Text);
            bool isInsertMenu = items.IsInsert(categoryName, subCategoryName, itemName, price);
            if (isInsertMenu)
            {
                MessageBox.Show("Succefully Added item");
                dgvMenu.DataSource = items.GetAllItems();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void dgvMenu_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAddMenu.Visible = false;
            btnUpdateMenu.Visible = true;
            btnDeleteMenu.Visible = true;

            txtMenuId.Visible = true;
            txtMenuId.Enabled = false;

            var itemId = dgvMenu.SelectedRows[0].Cells[0].Value.ToString();
            var categoryName = dgvMenu.SelectedRows[0].Cells[1].Value.ToString();
            var subCategoryName = dgvMenu.SelectedRows[0].Cells[2].Value.ToString();
            var itemName = dgvMenu.SelectedRows[0].Cells[3].Value.ToString();
            var price = dgvMenu.SelectedRows[0].Cells[4].Value.ToString();

            txtMenuId.Text = itemId;
            cbCategory.SelectedItem = categoryName;
            cbSubCategory.SelectedItem = subCategoryName;
            txtItemName.Text = itemName;
            txtPrice.Text = price;
        }

        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.ItemId = Int32.Parse(txtMenuId.Text);
            item.CategoryName = cbCategory.SelectedItem.ToString();
            item.SubCategoryName = cbSubCategory.SelectedItem.ToString();
            item.ItemName = txtItemName.Text;
            item.Price = Int32.Parse(txtPrice.Text);
            bool isUpdateItem = items.IsUpdate(item);
            if (isUpdateItem)
            {
                MessageBox.Show("Succefully Update");
                dgvMenu.DataSource = items.GetAllItems();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            bool isDeleteItem = items.IsDelete(Int32.Parse(txtMenuId.Text));
            if (isDeleteItem)
            {
                MessageBox.Show("Succefully Deleted");
                dgvMenu.DataSource = items.GetAllItems();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
