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
        private bool validateSave()
        { 
            if(string.IsNullOrWhiteSpace(txtbxName.Text) || string.IsNullOrWhiteSpace(txtbxDynamicVar.Text))
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
            btnSave.Enabled = validateSave();
        }

        public ModifyPart()
        {
            InitializeComponent();
            // Loads data into Modify Part Screen
            txtbxID.Text = Inventory.CurrentPart.Id.ToString();
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

        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxName.Text))
            {
                txtbxName.BackColor = Color.Salmon;
            }
            else
            {
                txtbxName.BackColor = Color.White;
            }
            btnSave.Enabled = validateSave();
        }

        private void txtbxInventory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
   
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
    }
}
