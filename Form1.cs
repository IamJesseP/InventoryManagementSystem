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
using JessePerez.view;

namespace JessePerez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //set the data source for Parts, edit props
            dgvParts.DataSource = Inventory.FullParts;
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParts.ReadOnly = true;
            dgvParts.MultiSelect = false;
            dgvParts.AllowUserToAddRows = false;

            //set the data source for Products, edit props
            dgvProducts.DataSource = Inventory.FullProducts;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.ReadOnly = true;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;
        }

        #region Clears Row Selection
        //clears selection upon initialization
        private void myPartBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvParts.ClearSelection();
        }

        private void myProductBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProducts.ClearSelection();
        }
        #endregion

        #region Parts Event Listeners 
        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Select part and part ID
            int indexSelected = e.RowIndex;
            Inventory.CurrentPartID = (int)dgvParts.Rows[indexSelected].Cells[0].Value;

            //Sets the object for the currently selected Part row
            Inventory.CurrentPart = Inventory.LookupPart(Inventory.CurrentPartID);


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
        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow == null || !dgvParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected!");
            }
            else
            {
                new ModifyPart().Show();
                this.Hide();
            }
        }
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            new AddPart().Show();
            this.Hide();
        }
        private void btnSearchPart_Click(object sender, EventArgs e)
        {

        }
        private void txtbxSearchPart_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Products Event Listeners
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Select part and part ID
            int indexSelected = e.RowIndex;
            Inventory.CurrentProductID = (int)dgvProducts.Rows[indexSelected].Cells[0].Value;

            //Sets the object for the currently selected Part row
            Inventory.CurrentProduct = Inventory.LookupProduct(Inventory.CurrentProductID);
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
            if (dgvProducts.CurrentRow == null || !dgvProducts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected! Please make a selection.");
            }
            else
            {
                new ModifyProduct().Show();
                this.Hide();
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new AddProduct().Show();
            this.Hide();
        }
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

        }
        private void txtbxSearchProduct_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
