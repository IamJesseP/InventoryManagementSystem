using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using JessePerez.model;

namespace JessePerez.view
{
    public partial class ModifyPart : Form
    {
        bool isInHouse;

        // Checks for text, and int value if is Inhouse
        private bool validateSave(TextBox textBox)
        { 
            if(string.IsNullOrWhiteSpace(textBox.Text) || string.IsNullOrWhiteSpace(txtbxDynamicVar.Text))
            {
                return false;
            } 
            else if (isInHouse && !int.TryParse(txtbxDynamicVar.Text, out int number))
            {
                return false;
            } 
            else { return true; }
        }

        private void validateOnRBSwitch()
        {
            if (string.IsNullOrWhiteSpace(txtbxDynamicVar.Text) || (isInHouse && !int.TryParse(txtbxDynamicVar.Text, out int number)))
            {
                txtbxDynamicVar.BackColor = Color.Salmon;
            }
            else
            {
                txtbxDynamicVar.BackColor = Color.White;
            }
            btnSave.Enabled = validateSave(txtbxDynamicVar);
        }

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

        private void txtbxID_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxID);
        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxName);
        }

        private void txtbxInventory_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxInventory);
        }

        private void txtbxPrice_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxPrice);
        }

        private void txtbxMin_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxMin);
        }

        private void txtbxMax_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtbxMax);
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
            validateOnRBSwitch();
        }

        private void rbInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblDynamicName.Text = "Machine ID";
            isInHouse = true;
            validateOnRBSwitch();
        }

        private void rbOutSourced_CheckedChanged(object sender, EventArgs e)
        {
            lblDynamicName.Text = "Company Name";
            isInHouse = false;
            validateOnRBSwitch();
        }

        private void ValidateTextBox(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BackColor = Color.Salmon;
            }
            else
            {
                textBox.BackColor = Color.White;
            }
            btnSave.Enabled = validateSave(textBox);
        }

    }
}
