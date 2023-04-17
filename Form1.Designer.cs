namespace JessePerez
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnModifyPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearchPart = new System.Windows.Forms.Button();
            this.txtbxSearchPart = new System.Windows.Forms.TextBox();
            this.txtbxSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column9,
            this.Column10});
            this.dgvParts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvParts.Location = new System.Drawing.Point(42, 63);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(371, 303);
            this.dgvParts.TabIndex = 0;
            this.dgvParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellClick);
            this.dgvParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myPartBindingComplete);
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column11,
            this.Column12});
            this.dgvProducts.Location = new System.Drawing.Point(472, 63);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(371, 303);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myProductBindingComplete);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(128, 372);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(91, 44);
            this.btnAddPart.TabIndex = 2;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnModifyPart
            // 
            this.btnModifyPart.Location = new System.Drawing.Point(225, 372);
            this.btnModifyPart.Name = "btnModifyPart";
            this.btnModifyPart.Size = new System.Drawing.Size(91, 44);
            this.btnModifyPart.TabIndex = 3;
            this.btnModifyPart.Text = "Modify";
            this.btnModifyPart.UseVisualStyleBackColor = true;
            this.btnModifyPart.Click += new System.EventHandler(this.btnModifyPart_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(322, 372);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(91, 44);
            this.btnDeletePart.TabIndex = 4;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(547, 372);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(91, 44);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(644, 372);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(91, 44);
            this.btnModifyProduct.TabIndex = 6;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(741, 372);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(91, 44);
            this.btnDeleteProduct.TabIndex = 7;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(741, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 44);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearchPart
            // 
            this.btnSearchPart.Location = new System.Drawing.Point(200, 37);
            this.btnSearchPart.Name = "btnSearchPart";
            this.btnSearchPart.Size = new System.Drawing.Size(67, 22);
            this.btnSearchPart.TabIndex = 9;
            this.btnSearchPart.Text = "Search";
            this.btnSearchPart.UseVisualStyleBackColor = true;
            this.btnSearchPart.Click += new System.EventHandler(this.btnSearchPart_Click);
            // 
            // txtbxSearchPart
            // 
            this.txtbxSearchPart.Location = new System.Drawing.Point(273, 37);
            this.txtbxSearchPart.Name = "txtbxSearchPart";
            this.txtbxSearchPart.Size = new System.Drawing.Size(140, 20);
            this.txtbxSearchPart.TabIndex = 10;
            this.txtbxSearchPart.TextChanged += new System.EventHandler(this.txtbxSearchPart_TextChanged);
            // 
            // txtbxSearchProduct
            // 
            this.txtbxSearchProduct.Location = new System.Drawing.Point(692, 37);
            this.txtbxSearchProduct.Name = "txtbxSearchProduct";
            this.txtbxSearchProduct.Size = new System.Drawing.Size(140, 20);
            this.txtbxSearchProduct.TabIndex = 11;
            this.txtbxSearchProduct.TextChanged += new System.EventHandler(this.txtbxSearchProduct_TextChanged);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(619, 37);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(67, 22);
            this.btnSearchProduct.TabIndex = 12;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Products";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Id";
            this.Column5.HeaderText = "Product ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Name";
            this.Column6.HeaderText = "Product Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.DataPropertyName = "InStock";
            this.Column7.HeaderText = "Inventory";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 76;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Price";
            this.Column8.HeaderText = "Price";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 77;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Min";
            this.Column11.HeaderText = "Min";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Max";
            this.Column12.HeaderText = "Max";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Part ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Part Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.DataPropertyName = "InStock";
            this.Column3.HeaderText = "Inventory";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 76;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 77;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Min";
            this.Column9.HeaderText = "Min";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Max";
            this.Column10.HeaderText = "Max";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtbxSearchProduct);
            this.Controls.Add(this.txtbxSearchPart);
            this.Controls.Add(this.btnSearchPart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.btnModifyPart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Name = "Form1";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnModifyPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearchPart;
        private System.Windows.Forms.TextBox txtbxSearchPart;
        private System.Windows.Forms.TextBox txtbxSearchProduct;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

