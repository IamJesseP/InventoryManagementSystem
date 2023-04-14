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

namespace JessePerez.view
{
    public partial class ModifyPart : Form
    {
        bool isInHouse;

        private bool allowSave()
        {
            if(string.IsNullOrWhiteSpace(txtbxName.Text) && string.IsNullOrWhiteSpace(txtbxDynamicName.Text))
            {
                return false;
                // Is isInHouse needed?
            } else if (isInHouse && int.TryParse(txtbxDynamicName.Text, out int number))
            {
                return false;
            } else { return true; }

        }

        public ModifyPart()
        {
            InitializeComponent();
            txtbxID.Text = Inventory.CurrentPart.Id.ToString();
            txtbxName.Text = Inventory.CurrentPart.Name.ToString();
            txtbxInventory.Text = Inventory.CurrentPart.InStock.ToString();
            txtbxPrice.Text = Inventory.CurrentPart.Price.ToString();
            txtbxMin.Text = Inventory.CurrentPart.Min.ToString();
            txtbxMax.Text = Inventory.CurrentPart.Max.ToString();

        }

        private void btnInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblDynamicName.Text = "Machine ID";

        }

        private void btnOutSourced_CheckedChanged(object sender, EventArgs e)
        {
            lblDynamicName.Text = "Company Name";
        }

        private void txtbxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {

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

        private void txtbxDynamicName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
   
        }
    }
}
