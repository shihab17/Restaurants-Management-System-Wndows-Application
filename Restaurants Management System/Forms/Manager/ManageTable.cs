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
    public partial class ManageTable : Form
    {
        Tables tables = new Tables();
        public ManageTable()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            btnAddTable.Visible = true;
            btnDeleteTable.Visible = false;
            btnUpdateTable.Visible = false;
            txtStatus.Visible = false;
            dgvTables.DataSource = tables.GetAllTables();
        }
        private void RefreshData()
        {
            txtStatus.Text = "";
            txtTableId.Text = "";
            cbTableType.SelectedItem = null;
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.TableId = txtTableId.Text;
            table.TableType = cbTableType.SelectedItem.ToString();
            table.TableStatus = (int)Table.TableStatusEnum.Unbooked;
            bool isInsertTable = tables.isInsert(table);
            if (isInsertTable)
            {
                MessageBox.Show("Successfully insert");
                dgvTables.DataSource = tables.GetAllTables();
                RefreshData();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void dgvTables_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAddTable.Visible = false;
            btnUpdateTable.Visible = true;
            btnDeleteTable.Visible = true;

            var tableId = dgvTables.SelectedRows[0].Cells[0].Value.ToString();
            var tableTypes = dgvTables.SelectedRows[0].Cells[1].Value.ToString();
            var status = dgvTables.SelectedRows[0].Cells[2].Value.ToString();

            txtTableId.Text = tableId;
            cbTableType.SelectedItem = tableTypes;
            txtStatus.Text = status;
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.TableId = txtTableId.Text;
            table.TableType = cbTableType.SelectedItem.ToString();
            table.TableStatus = Int32.Parse(txtStatus.Text);
            bool isUpdateTable = tables.isUpdate(table);
            if (isUpdateTable)
            {
                MessageBox.Show("Successfully Updated");
                RefreshData();
                LoadData();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            bool isDeleteTable = tables.isDelete(txtTableId.Text);
            if (isDeleteTable)
            {
                MessageBox.Show("Successfully Deleted");
                RefreshData();
                LoadData();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
