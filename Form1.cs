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


            //set the data source for Parts, edit props
            dgvParts.DataSource = Part.parts;

            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvParts.ReadOnly = true;

            dgvParts.MultiSelect = false;

            dgvParts.AllowUserToAddRows = false;

            //set the data source for Products, edit props

            dgvProducts.DataSource = Product.products;

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
            dgvParts.ClearSelection();
        }

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!dgvParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected!");
            }

            Part S = dgvParts.CurrentRow.DataBoundItem as Part;

            int Index = dgvParts.CurrentCell.RowIndex;

        }
    }
}
