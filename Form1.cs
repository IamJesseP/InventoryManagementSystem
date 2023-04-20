using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            int indexSelected = e.RowIndex;            
            if (indexSelected < 0) { return; }//Error handler for clicking header row

            //Sets the object for the currently selected Part row
            Inventory.CurrentPartID = (int)dgvParts.Rows[indexSelected].Cells[0].Value;
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
                foreach (Product p in Inventory.FullProducts)
                {   //Exception control if Part has relation to products
                    if (p.AssociatedParts.Contains(S))
                    {
                        MessageBox.Show("Cannot delete! Part is associated with a Product.");
                        return;
                    };
                }
                if (ConfirmDeletion())
                {
                    Inventory.RemovePart(S);
                }
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
            StartPartSearch();
        }
        private void txtbxSearchPart_TextChanged(object sender, EventArgs e)
        {
            

        }
        #endregion

        #region Products Event Listeners
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexSelected = e.RowIndex;
            if (indexSelected < 0) { return; }//Error handler for clicking header row
            
            //Sets the object for the currently selected Product row
            Inventory.CurrentProductID = (int)dgvProducts.Rows[indexSelected].Cells[0].Value;
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
                    //Exception control if Product has relation to parts
                    if (S.AssociatedParts.Count > 0)
                    {
                        MessageBox.Show("Cannot delete! Product is associated with parts.");
                        return;
                    };
                if (ConfirmDeletion())
                {
                    Inventory.RemoveProduct(S);
                }
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
            StartProductSearch();
        }
        private void txtbxSearchProduct_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Helper methods
        private void StartPartSearch()
        {
            string partSearchText = "";
            Regex numberCheck = new Regex("^(0|[1-9][0-9]*)$");
            partSearchText = txtbxSearchPart.Text;
            dgvParts.ClearSelection();
            //Search part by ID
            if (numberCheck.IsMatch(partSearchText) == true)
            {
                if (int.Parse(partSearchText) > Inventory.FullParts.Count)
                {
                    MessageBox.Show("Part not found");
                }
                else
                {
                    foreach (Part p in Inventory.FullParts)
                    {
                        if (partSearchText == p.Id.ToString())
                        {
                            int index = p.Id - 1;
                            dgvParts.Rows[index].Selected = true;
                            txtbxSearchPart.Text = "";
                            return;
                        }
                    }
                }
            }
            //Search part by name
            else
            {
                foreach (Part p in Inventory.FullParts)
                {
                    if (p.Name.ToLower() == partSearchText.ToLower())
                    {
                        int index = p.Id - 1;
                        dgvParts.Rows[index].Selected = true;
                        txtbxSearchPart.Text = "";
                        return;
                    }
                }
                MessageBox.Show("Part not found");
            }
        }
        private void StartProductSearch()
        {
            string productSearchText = "";
            Regex numberCheck = new Regex("^(0|[1-9][0-9]*)$");
            productSearchText = txtbxSearchProduct.Text;
            dgvProducts.ClearSelection();
            //Search product by ID
            if (numberCheck.IsMatch(productSearchText) == true)
            {
                if (int.Parse(productSearchText) > Inventory.FullProducts.Count)
                {
                    MessageBox.Show("Product not found");
                }
                else
                {
                    foreach (Product p in Inventory.FullProducts)
                    {
                        if (productSearchText == p.Id.ToString())
                        {
                            int index = p.Id - 1;
                            dgvProducts.Rows[index].Selected = true;
                            txtbxSearchProduct.Text = "";
                            return;
                        }
                    }
                }
            }
            //Search product by name
            else
            {
                foreach (Product p in Inventory.FullProducts)
                {
                    if (p.Name.ToLower() == productSearchText.ToLower())
                    {
                        int index = p.Id - 1;
                        dgvProducts.Rows[index].Selected = true;
                        txtbxSearchProduct.Text = "";
                        return;
                    }
                }
                MessageBox.Show("Product not found");
            }
        }
        private bool ConfirmDeletion()
        {
           var confirmResult = MessageBox.Show("Are you sure you want to delete this item?",
                                     "Confirm Deletion",
                                     MessageBoxButtons.YesNo);
            return confirmResult == DialogResult.Yes ? true : false;
        }
        #endregion
    }
}
