﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JessePerez.model;

namespace JessePerez.view
{
    public partial class ModifyProduct : Form
    {
        private static int AssociatedIndex = -1;
        public ModifyProduct()
        {
            // Loads data into Modify Product Screen
            InitializeComponent();
            txtbxID.Text = Inventory.CurrentProduct.Id.ToString();
            txtbxID.ReadOnly = true;
            txtbxID.BackColor = Color.WhiteSmoke;
            txtbxID.TabStop = false;

            txtbxName.Text = Inventory.CurrentProduct.Name.ToString();
            txtbxInventory.Text = Inventory.CurrentProduct.InStock.ToString();
            txtbxPrice.Text = Inventory.CurrentProduct.Price.ToString();
            txtbxMin.Text = Inventory.CurrentProduct.Min.ToString();
            txtbxMax.Text = Inventory.CurrentProduct.Max.ToString();

            //set the data source for AllParts, edit props
            dgvAllParts.DataSource = Inventory.FullParts;
            dgvAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllParts.ReadOnly = true;
            dgvAllParts.MultiSelect = false;
            dgvAllParts.AllowUserToAddRows = false;

            
            dgvPartsAssociated.DataSource = Inventory.CurrentProduct.AssociatedParts;
            dgvPartsAssociated.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPartsAssociated.ReadOnly = true;
            dgvPartsAssociated.MultiSelect = false;
            dgvPartsAssociated.AllowUserToAddRows = false;
        }

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

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvAllParts.CurrentRow == null || !dgvAllParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected!");
            }
            else
            {
                if (Inventory.CurrentProduct.AssociatedParts.Contains(Inventory.CurrentPart))
                {
                    MessageBox.Show("Part is already associated.");
                }
                else
                {
                    Inventory.CurrentProduct.AssociatedParts.Add(Inventory.CurrentPart);
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
                Inventory.CurrentProduct.AssociatedParts.RemoveAt(AssociatedIndex);
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
            foreach (Part p in Inventory.CurrentProduct.AssociatedParts)
            {
                product.AssociatedParts.Add(p);
            }
            Inventory.SwapProduct(product);
            
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();    
        }
        private void dgvAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Select part and part ID
            int indexSelected = e.RowIndex;
            Inventory.CurrentPartID = (int)dgvAllParts.Rows[indexSelected].Cells[0].Value;

            //Sets the object for the currently selected Part row
            Inventory.CurrentPart = Inventory.LookupPart(Inventory.CurrentPartID);
        }
        private void dgvPartsAssociated_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           AssociatedIndex = e.RowIndex;
        }
        #endregion

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

    }
}
