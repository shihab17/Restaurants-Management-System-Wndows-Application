using BusinessLayer;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurants_Management_System.Forms.Manager
{
    public partial class ManageOrder : Form
    {
        Categories categories = new Categories();
        SubCategories subCategories = new SubCategories();
        Items items = new Items();
        public ManageOrder()
        {
            InitializeComponent();
            ManageCategories();
            LoadData();
        }

        private void LoadData()
        {
            txtItemName.Enabled = false;
            btnDeleteOrder.Visible = false;
            btnUpdateOrder.Visible = false;
        }

        private void ManageCategories()
        {
            List<Category> categoryList = categories.GetAllCategories();
            int startPosition = 5;
            int endPosition = 10;
            for (int i = 0; i < categoryList.Count; i++)
            {
                Category c = categoryList[i];
                Button btn = CreateCategoriesButton(c.CategoryName, startPosition, endPosition);
                metroPanelCategory.Controls.Add(btn);
                endPosition += 60;
                btn.Click += new System.EventHandler(this.Label_Click);
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            List<SubCategory> subCategoriesList = subCategories.GetSubCategoryByCategoryName(currentButton.Text);
            SubCategories(subCategoriesList);
        }

        private void SubCategories(List<SubCategory> subCategoriesList)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < subCategoriesList.Count; i++)
            {
                SubCategory sub = subCategoriesList[i];
                Button btn = CreateSubCategoriesButton(sub);
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += new System.EventHandler(BtnSubCategory_Click);
            }
        }

        private Button CreateSubCategoriesButton(SubCategory sub)
        {
            Button button = new Button();
            button.Text = sub.SubCategoryName;
            button.Name = "btn"+ sub.SubCategoryName;
            button.ForeColor = Color.White;
            button.BackColor = Color.Green;
            button.Size = new Size(80, 50);
            return button;
        }

        private void BtnSubCategory_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            List<Item> itemList = items.GetItemsBySubCategory(currentButton.Text);
            ItemNames(itemList);
        }

        private void ItemNames(List<Item> itemList)
        {
            flowLayoutPanelItemName.Controls.Clear();
            for (int i = 0;i < itemList.Count; i++)
            {
                Item item = itemList[i];
                Button button = CreateItemsButton(item);
                flowLayoutPanelItemName.Controls.Add(button);
                button.Click += ButtonItemName_Click;
            }
        }

        private void ButtonItemName_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            MessageBox.Show(currentButton.Text);
            Item item = items.GetItemByItemName(currentButton.Text);
            AddToOrder(item);
        }

        private void AddToOrder(Item item)
        {
            int quantity = 1;
            int total = quantity * item.Price;
            dgvOrder.Rows.Add(item.ItemName, quantity, item.Price, total);
        }

        private Button CreateItemsButton(Item i)
        {
            Button button = new Button();
            button.Text = i.ItemName;
            button.Name = "btn" + i.ItemName;
            button.ForeColor = Color.White;
            button.BackColor = Color.Green;
            button.Size = new Size(80, 50);
            return button;
        }

        private Button CreateCategoriesButton(string i, int start, int end)
        {
            
            Button b = new Button();
            b.Text = i.ToString();
            b.Name = i.ToString();
            b.Size = new Size(80, 50);
            b.Location = new Point(start, end);
            b.Margin = new Padding(3);
            
            return b;
        }

        private void dgvOrder_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUpdateOrder.Visible = true;
            btnDeleteOrder.Visible = true;
            txtItemName.Text = dgvOrder.SelectedRows[0].Cells[0].Value.ToString();
            txtQuantity.Text = dgvOrder.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = dgvOrder.SelectedRows[0].Cells[2].Value.ToString();
            txtTotal.Text = dgvOrder.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            dgvOrder.SelectedRows[0].Cells[1].Value = txtQuantity.Text;
            dgvOrder.SelectedRows[0].Cells[2].Value = txtPrice.Text;
            txtTotal.Text = (Int32.Parse(txtQuantity.Text) * Int32.Parse(txtPrice.Text)).ToString();
            dgvOrder.SelectedRows[0].Cells[3].Value = txtTotal.Text;
        }

      
    }
}
