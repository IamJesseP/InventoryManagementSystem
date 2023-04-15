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
    public partial class AddPart : Form
    {
        bool isInHouse;
        public AddPart()
        {
            InitializeComponent();
            ValidateForm();
            int partCount = Inventory.FullParts.Count + 1;
            txtbxID.Text = partCount.ToString();
            txtbxID.ReadOnly = true;
            txtbxID.BackColor = Color.WhiteSmoke;
            txtbxID.TabStop = false;
            rbInHouse.Checked = true;
        }


        #region Event Listeners
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isInHouse)
            {
                Part part = new InHouse(Convert.ToInt32(txtbxID.Text), txtbxName.Text, Convert.ToDecimal(txtbxPrice.Text),
                    Convert.ToInt32(txtbxInventory.Text), Convert.ToInt32(txtbxMin.Text), Convert.ToInt32(txtbxMax.Text),
                    Convert.ToInt32(txtbxDynamicVar.Text));
                Inventory.FullParts.Add(part);
            }
            else
            {
                Part part = new OutSourced(Convert.ToInt32(txtbxID.Text), txtbxName.Text, Convert.ToDecimal(txtbxPrice.Text),
                    Convert.ToInt32(txtbxInventory.Text), Convert.ToInt32(txtbxMin.Text), Convert.ToInt32(txtbxMax.Text),
                    txtbxDynamicVar.Text);
                Inventory.FullParts.Add(part);
            }

            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        private void txtbxMin_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxMin, "int");
        }
        private void txtbxMax_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxMax, "int");
        }
        private void txtbxPrice_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxPrice, "decimal");
        }
        private void txtbxInventory_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxInventory, "int");
        }
        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxName, "string");
        }
        private void txtbxID_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxID, "int");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        private void txtbxDynamicVar_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxDynamicVar, isInHouse ? "int" : "string");
        }
        private void rbInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblDynamicVar.Text = "Machine ID";
            isInHouse = true;
            ValidateTextBox(txtbxDynamicVar, "int");
        }
        private void rbOutSourced_CheckedChanged(object sender, EventArgs e)
        {
            lblDynamicVar.Text = "Company Name";
            isInHouse = false;
            ValidateTextBox(txtbxDynamicVar, "string");
        }
        #endregion

        #region Validation Methods
        // Validates for empty text, type of each textbox, and whether to enable btnSave
        private void ValidateTextBox(TextBox textBox, string type)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || (isInHouse && !int.TryParse(txtbxDynamicVar.Text, out int number)))
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
            ValidateTextBox(txtbxDynamicVar, isInHouse ? "int" : "string");
        }
        #endregion
    }
}
