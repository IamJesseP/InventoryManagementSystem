using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using JessePerez.model;

namespace JessePerez.view
{
    public partial class ModifyPart : Form
    {
        bool isInHouse;
        public ModifyPart()
        {
            InitializeComponent();
            // Loads data into Modify Part Screen
            txtbxID.Text = Inventory.CurrentPart.Id.ToString();
            txtbxID.ReadOnly = true;
            txtbxID.BackColor = Color.WhiteSmoke;
            txtbxID.TabStop = false;

            txtbxName.Text = Inventory.CurrentPart.Name.ToString();
            txtbxInventory.Text = Inventory.CurrentPart.InStock.ToString();
            txtbxPrice.Text = Inventory.CurrentPart.Price.ToString();
            txtbxMin.Text = Inventory.CurrentPart.Min.ToString();
            txtbxMax.Text = Inventory.CurrentPart.Max.ToString();

            //Casts object to correct type, access correct props
            if (Inventory.CurrentPart is InHouse)
            {
                InHouse partData = (InHouse)Inventory.CurrentPart;
                txtbxDynamicVar.Text = partData.MachineID.ToString();
                isInHouse = true;
                rbInHouse.Checked = true;
            }
            else
            {
                OutSourced partData = (OutSourced)Inventory.CurrentPart;
                txtbxDynamicVar.Text = partData.CompanyName.ToString();
                isInHouse = false;
                rbOutSourced.Checked = true;
            }
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isInHouse)
            {
                Part part = new InHouse(Convert.ToInt32(txtbxID.Text), txtbxName.Text, Convert.ToDecimal(txtbxPrice.Text),
                    Convert.ToInt32(txtbxInventory.Text), Convert.ToInt32(txtbxMin.Text), Convert.ToInt32(txtbxMax.Text),
                    Convert.ToInt32(txtbxDynamicVar.Text));
                Inventory.swap(part);
            }
            else
            {
                Part part = new OutSourced(Convert.ToInt32(txtbxID.Text), txtbxName.Text, Convert.ToDecimal(txtbxPrice.Text),
                    Convert.ToInt32(txtbxInventory.Text), Convert.ToInt32(txtbxMin.Text), Convert.ToInt32(txtbxMax.Text),
                    txtbxDynamicVar.Text);
                Inventory.swap(part);
            }

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
            lblDynamicName.Text = "Machine ID";
            isInHouse = true;
            ValidateTextBox(txtbxDynamicVar, "int");
        }
        private void rbOutSourced_CheckedChanged(object sender, EventArgs e)
        {
            lblDynamicName.Text = "Company Name";
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
            btnSave.Enabled = validateSave(textBox, type);
        }

        private bool validateSave(TextBox textBox, string type)
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
                    if(int.TryParse(textBox.Text, out int intNumber))
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
                    return true;
                default:
                    return false;
            }
        }
        #endregion
    }
}
