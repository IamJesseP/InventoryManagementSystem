namespace JessePerez
{
    partial class AddPart
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbxInventory = new System.Windows.Forms.TextBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtbxMin = new System.Windows.Forms.TextBox();
            this.txtbxMax = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.btnInHouse = new System.Windows.Forms.RadioButton();
            this.btnOutSourced = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtbxDynamicName = new System.Windows.Forms.TextBox();
            this.lblDynamicName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(146, 72);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(165, 20);
            this.txtbxID.TabIndex = 2;
            this.txtbxID.TextChanged += new System.EventHandler(this.txtbxID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(122, 75);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(146, 108);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(165, 20);
            this.txtbxName.TabIndex = 4;
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(105, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // txtbxInventory
            // 
            this.txtbxInventory.Location = new System.Drawing.Point(146, 155);
            this.txtbxInventory.Name = "txtbxInventory";
            this.txtbxInventory.Size = new System.Drawing.Size(165, 20);
            this.txtbxInventory.TabIndex = 6;
            this.txtbxInventory.TextChanged += new System.EventHandler(this.txtbxInventory_TextChanged);
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(89, 158);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(51, 13);
            this.lblInventory.TabIndex = 7;
            this.lblInventory.Text = "Inventory";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(146, 205);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(165, 20);
            this.txtbxPrice.TabIndex = 8;
            this.txtbxPrice.TextChanged += new System.EventHandler(this.txtbxPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(109, 208);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // txtbxMin
            // 
            this.txtbxMin.Location = new System.Drawing.Point(146, 246);
            this.txtbxMin.Name = "txtbxMin";
            this.txtbxMin.Size = new System.Drawing.Size(68, 20);
            this.txtbxMin.TabIndex = 10;
            this.txtbxMin.TextChanged += new System.EventHandler(this.txtbxMin_TextChanged);
            // 
            // txtbxMax
            // 
            this.txtbxMax.Location = new System.Drawing.Point(266, 246);
            this.txtbxMax.Name = "txtbxMax";
            this.txtbxMax.Size = new System.Drawing.Size(68, 20);
            this.txtbxMax.TabIndex = 11;
            this.txtbxMax.TextChanged += new System.EventHandler(this.txtbxMax_TextChanged);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(109, 249);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 12;
            this.lblMin.Text = "Min";
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(236, 249);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 13;
            this.lblMax.Text = "Max";
            // 
            // btnInHouse
            // 
            this.btnInHouse.AutoSize = true;
            this.btnInHouse.Location = new System.Drawing.Point(129, 31);
            this.btnInHouse.Name = "btnInHouse";
            this.btnInHouse.Size = new System.Drawing.Size(68, 17);
            this.btnInHouse.TabIndex = 14;
            this.btnInHouse.TabStop = true;
            this.btnInHouse.Text = "In-House";
            this.btnInHouse.UseVisualStyleBackColor = true;
            this.btnInHouse.CheckedChanged += new System.EventHandler(this.btnInHouse_CheckedChanged);
            // 
            // btnOutSourced
            // 
            this.btnOutSourced.AutoSize = true;
            this.btnOutSourced.Location = new System.Drawing.Point(237, 31);
            this.btnOutSourced.Name = "btnOutSourced";
            this.btnOutSourced.Size = new System.Drawing.Size(80, 17);
            this.btnOutSourced.TabIndex = 15;
            this.btnOutSourced.TabStop = true;
            this.btnOutSourced.Text = "Outsourced";
            this.btnOutSourced.UseVisualStyleBackColor = true;
            this.btnOutSourced.CheckedChanged += new System.EventHandler(this.btnOutSourced_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 13);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Add Part";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // txtbxDynamicName
            // 
            this.txtbxDynamicName.Location = new System.Drawing.Point(146, 295);
            this.txtbxDynamicName.Name = "txtbxDynamicName";
            this.txtbxDynamicName.Size = new System.Drawing.Size(165, 20);
            this.txtbxDynamicName.TabIndex = 17;
            this.txtbxDynamicName.TextChanged += new System.EventHandler(this.txtbxDynamicName_TextChanged);
            // 
            // lblDynamicName
            // 
            this.lblDynamicName.AutoSize = true;
            this.lblDynamicName.Location = new System.Drawing.Point(58, 298);
            this.lblDynamicName.Name = "lblDynamicName";
            this.lblDynamicName.Size = new System.Drawing.Size(82, 13);
            this.lblDynamicName.TabIndex = 18;
            this.lblDynamicName.Text = "Company Name";
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 410);
            this.Controls.Add(this.lblDynamicName);
            this.Controls.Add(this.txtbxDynamicName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnOutSourced);
            this.Controls.Add(this.btnInHouse);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtbxMax);
            this.Controls.Add(this.txtbxMin);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.txtbxInventory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "AddPart";
            this.Text = "AddPart";
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtbxID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbxInventory;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtbxMin;
        private System.Windows.Forms.TextBox txtbxMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.RadioButton btnInHouse;
        private System.Windows.Forms.RadioButton btnOutSourced;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtbxDynamicName;
        private System.Windows.Forms.Label lblDynamicName;
    }
}