namespace JessePerez.view
{
    partial class ModifyPart
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
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxInventory = new System.Windows.Forms.TextBox();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.txtbxMin = new System.Windows.Forms.TextBox();
            this.txtbxMax = new System.Windows.Forms.TextBox();
            this.txtbxDynamicVar = new System.Windows.Forms.TextBox();
            this.rbInHouse = new System.Windows.Forms.RadioButton();
            this.rbOutSourced = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDynamicName = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(146, 72);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(165, 20);
            this.txtbxID.TabIndex = 3;
            this.txtbxID.TextChanged += new System.EventHandler(this.txtbxID_TextChanged);
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(146, 108);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(165, 20);
            this.txtbxName.TabIndex = 5;
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged);
            // 
            // txtbxInventory
            // 
            this.txtbxInventory.Location = new System.Drawing.Point(146, 155);
            this.txtbxInventory.Name = "txtbxInventory";
            this.txtbxInventory.Size = new System.Drawing.Size(165, 20);
            this.txtbxInventory.TabIndex = 7;
            this.txtbxInventory.TextChanged += new System.EventHandler(this.txtbxInventory_TextChanged);
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(146, 205);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(165, 20);
            this.txtbxPrice.TabIndex = 9;
            this.txtbxPrice.TextChanged += new System.EventHandler(this.txtbxPrice_TextChanged);
            // 
            // txtbxMin
            // 
            this.txtbxMin.Location = new System.Drawing.Point(146, 246);
            this.txtbxMin.Name = "txtbxMin";
            this.txtbxMin.Size = new System.Drawing.Size(68, 20);
            this.txtbxMin.TabIndex = 11;
            this.txtbxMin.TextChanged += new System.EventHandler(this.txtbxMin_TextChanged);
            // 
            // txtbxMax
            // 
            this.txtbxMax.Location = new System.Drawing.Point(266, 246);
            this.txtbxMax.Name = "txtbxMax";
            this.txtbxMax.Size = new System.Drawing.Size(68, 20);
            this.txtbxMax.TabIndex = 12;
            this.txtbxMax.TextChanged += new System.EventHandler(this.txtbxMax_TextChanged);
            // 
            // txtbxDynamicVar
            // 
            this.txtbxDynamicVar.Location = new System.Drawing.Point(146, 295);
            this.txtbxDynamicVar.Name = "txtbxDynamicVar";
            this.txtbxDynamicVar.Size = new System.Drawing.Size(165, 20);
            this.txtbxDynamicVar.TabIndex = 18;
            this.txtbxDynamicVar.TextChanged += new System.EventHandler(this.txtbxDynamicVar_TextChanged);
            // 
            // rbInHouse
            // 
            this.rbInHouse.AutoSize = true;
            this.rbInHouse.Location = new System.Drawing.Point(129, 31);
            this.rbInHouse.Name = "rbInHouse";
            this.rbInHouse.Size = new System.Drawing.Size(68, 17);
            this.rbInHouse.TabIndex = 19;
            this.rbInHouse.TabStop = true;
            this.rbInHouse.Text = "In-House";
            this.rbInHouse.UseVisualStyleBackColor = true;
            this.rbInHouse.CheckedChanged += new System.EventHandler(this.rbInHouse_CheckedChanged);
            // 
            // rbOutSourced
            // 
            this.rbOutSourced.AutoSize = true;
            this.rbOutSourced.Location = new System.Drawing.Point(237, 31);
            this.rbOutSourced.Name = "rbOutSourced";
            this.rbOutSourced.Size = new System.Drawing.Size(80, 17);
            this.rbOutSourced.TabIndex = 20;
            this.rbOutSourced.TabStop = true;
            this.rbOutSourced.Text = "Outsourced";
            this.rbOutSourced.UseVisualStyleBackColor = true;
            this.rbOutSourced.CheckedChanged += new System.EventHandler(this.rbOutSourced_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 13);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Modify Part";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 39);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 39);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblDynamicName
            // 
            this.lblDynamicName.AutoSize = true;
            this.lblDynamicName.Location = new System.Drawing.Point(58, 298);
            this.lblDynamicName.Name = "lblDynamicName";
            this.lblDynamicName.Size = new System.Drawing.Size(82, 13);
            this.lblDynamicName.TabIndex = 24;
            this.lblDynamicName.Text = "Company Name";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(109, 249);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 25;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(236, 249);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 26;
            this.lblMax.Text = "Max";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(109, 208);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "Price";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(89, 158);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(51, 13);
            this.lblInventory.TabIndex = 28;
            this.lblInventory.Text = "Inventory";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(105, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(122, 75);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "ID";
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 410);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblDynamicName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rbOutSourced);
            this.Controls.Add(this.rbInHouse);
            this.Controls.Add(this.txtbxDynamicVar);
            this.Controls.Add(this.txtbxMax);
            this.Controls.Add(this.txtbxMin);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.txtbxInventory);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.txtbxID);
            this.Name = "ModifyPart";
            this.Text = "ModifyPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxID;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxInventory;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.TextBox txtbxMin;
        private System.Windows.Forms.TextBox txtbxMax;
        private System.Windows.Forms.TextBox txtbxDynamicVar;
        private System.Windows.Forms.RadioButton rbInHouse;
        private System.Windows.Forms.RadioButton rbOutSourced;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDynamicName;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
    }
}