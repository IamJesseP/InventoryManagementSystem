using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JessePerez.model;

namespace JessePerez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Inventory.SampleInventoryData();


            //set the data source for Parts, edit props
            BindingSource partsBindingSource = new BindingSource
            {
                DataSource = Inventory.FullParts
            };
            dgvParts.DataSource = partsBindingSource;
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParts.ReadOnly = true;
            dgvParts.MultiSelect = false;
            dgvParts.AllowUserToAddRows = false;


            //set the data source for Products, edit props
            BindingSource productsBindingSource = new BindingSource
            {
                DataSource = Inventory.FullProducts
            };

            dgvProducts.DataSource = productsBindingSource;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.ReadOnly = true;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;


        }

        private void myPartBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clears selection upon init
            dgvParts.ClearSelection();
        }

        private void myProductBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clears selection upon init
            dgvProducts.ClearSelection();
        }

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow == null || !dgvParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected!");
            }
            else
            {

            }

            Part S = dgvParts.CurrentRow.DataBoundItem as Part;


            int Index = dgvParts.CurrentCell.RowIndex;

        }


        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow == null || !dgvParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected! Please make a selection.");
            }
            else
            {
            Part S = dgvParts.CurrentRow.DataBoundItem as Part;
            Inventory.FullParts.Remove(S);
            }
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchPart_Click(object sender, EventArgs e)
        {

        }

        private void txtbxSearchPart_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null || !dgvProducts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected! Please make a selection.");
            }
            else
            {
                Product S = dgvProducts.CurrentRow.DataBoundItem as Product;
                Inventory.FullProducts.Remove(S);
            }
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

        }

        private void txtbxSearchProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {

        }
    }
}
