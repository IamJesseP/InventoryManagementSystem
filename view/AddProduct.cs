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

namespace JessePerez.view
{
    public partial class AddProduct : Form
    {
        private static int associatedIndex = -1;

        Product prod = new Product();
        public AddProduct()
        {
            InitializeComponent();
            ValidateForm();
            int productCount = Inventory.FullProducts.Count + 1;
            txtbxID.Text = productCount.ToString();
            txtbxID.ReadOnly = true;
            txtbxID.BackColor = Color.WhiteSmoke;
            txtbxID.TabStop = false;

            dgvAllParts.DataSource = Inventory.FullParts;
            dgvAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllParts.ReadOnly = true;
            dgvAllParts.MultiSelect = false;
            dgvAllParts.AllowUserToAddRows = false;

            
            dgvPartsAssociated.DataSource = prod.AssociatedParts;
            dgvPartsAssociated.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPartsAssociated.ReadOnly = true;
            dgvPartsAssociated.MultiSelect = false;
            dgvPartsAssociated.AllowUserToAddRows = false;
        }

        #region Event Listeners
        private void txtbxID_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxID, "int");
        }
        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxName, "string");
        }
        private void txtbxInventory_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxInventory, "int");
        }
        private void txtbxPrice_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxPrice, "decimal");
        }
        private void txtbxMin_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxMin, "int");
        }
        private void txtbxMax_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxMax, "int");
        }
        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            StartPartSearch();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvAllParts.CurrentRow == null || !dgvAllParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected!");
            }
            else
            {
                if (prod.AssociatedParts.Contains(Inventory.CurrentPart))
                {
                    MessageBox.Show("Part is already associated.");
                }
                else
                {
                    prod.AddAssociatedPart(Inventory.CurrentPart);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPartsAssociated.CurrentRow == null || !dgvPartsAssociated.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected!");
            }
            else
            {
                if (ConfirmDeletion())
                {
                    prod.RemoveAssociatedPart(associatedIndex);
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMinMax()) return;
            Product product = new Product(Convert.ToInt32(txtbxID.Text), txtbxName.Text, Convert.ToInt32(txtbxInventory.Text),
                Convert.ToDecimal(txtbxPrice.Text), Convert.ToInt32(txtbxMin.Text), Convert.ToInt32(txtbxMax.Text));
            foreach (Part p in prod.AssociatedParts)
            {
                product.AddAssociatedPart(p);
            }
            Inventory.AddProduct(product);

            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        private void dgvAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexSelected = e.RowIndex;
            if (indexSelected < 0) { return; }//Error handler for clicking header row

            //Sets the object for the currently selected Part row
            Inventory.CurrentPartID = (int)dgvAllParts.Rows[indexSelected].Cells[0].Value;
            Inventory.CurrentPart = Inventory.LookupPart(Inventory.CurrentPartID);
        }
        private void dgvPartsAssociated_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            associatedIndex = e.RowIndex;
            if (associatedIndex < 0) { return; }//Error handler for clicking header row
        }
        #endregion

        #region Clears Row Selection
        private void dgvAllParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAllParts.ClearSelection();
        }
        private void dgvPartsAssociated_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPartsAssociated.ClearSelection();
        }
        #endregion

        #region Helper Methods
        #region Validation Methods
        // Validates for empty text, type of each textbox, and whether to enable btnSave
        private void ValidateTextBox(TextBox textBox, string type)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BackColor = Color.Salmon;
            }
            else
            {
                textBox.BackColor = Color.White;
            }
            btnSave.Enabled = ValidateSave(textBox, type);
        }

        private bool ValidateSave(TextBox textBox, string type)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return false;
            }
            else if (!ValidateType(textBox, type))
            {
                return false;
            }
            else { return true; }
        }
        private bool ValidateType(TextBox textBox, string type)
        {
            switch (type)
            {
                case "int":
                    if (int.TryParse(textBox.Text, out int intNumber))
                    {
                        textBox.BackColor = Color.White;
                        return true;
                    }
                    else
                    {
                        textBox.BackColor = Color.Salmon;
                        return false;
                    }
                case "decimal":
                    if (decimal.TryParse(textBox.Text, out decimal decimalNumber))
                    {
                        textBox.BackColor = Color.White;
                        return true;
                    }
                    else
                    {
                        textBox.BackColor = Color.Salmon;
                        return false;
                    }
                case "string":
                    textBox.BackColor = Color.White;
                    return true;
                default:
                    return false;
            }
        }
        private void ValidateForm()
        {
            ValidateTextBox(txtbxName, "string");
            ValidateTextBox(txtbxInventory, "int");
            ValidateTextBox(txtbxPrice, "decimal");
            ValidateTextBox(txtbxMin, "int");
            ValidateTextBox(txtbxMax, "int");
        }
        private bool ValidateMinMax()
        {
            int max = int.Parse(txtbxMax.Text);
            int min = int.Parse(txtbxMin.Text);
            int inventory = int.Parse(txtbxInventory.Text);
            if (max < min)
            {
                MessageBox.Show($"Max value '{max}' cannot be less than Min value '{min}'.");
                return false;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show($"Inventory value cannot be greater than the Max value or less" +
                    $" than the Min value.");
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
        private bool ConfirmDeletion()
        {
            var confirmResult = MessageBox.Show("Are you sure you want to remove this item?",
                                      "Confirm Removal",
                                      MessageBoxButtons.YesNo);
            return confirmResult == DialogResult.Yes ? true : false;
        }
        private void StartPartSearch()
        {
            string partSearchText = "";
            Regex numberCheck = new Regex("^(0|[1-9][0-9]*)$");
            partSearchText = txtbxSearch.Text;
            dgvAllParts.ClearSelection();
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
                            dgvAllParts.Rows[index].Selected = true;
                            txtbxSearch.Text = "";
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
                        dgvAllParts.Rows[index].Selected = true;
                        txtbxSearch.Text = "";
                        return;
                    }
                }
                MessageBox.Show("Part not found");
            }
        }
#endregion
    }
}
