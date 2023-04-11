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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lvlPrice = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(146, 72);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(165, 20);
            this.txtbxID.TabIndex = 2;
            this.txtbxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(122, 75);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(146, 108);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(165, 20);
            this.txtbxName.TabIndex = 4;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 6;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 20);
            this.textBox2.TabIndex = 8;
            // 
            // lvlPrice
            // 
            this.lvlPrice.AutoSize = true;
            this.lvlPrice.Location = new System.Drawing.Point(109, 208);
            this.lvlPrice.Name = "lvlPrice";
            this.lvlPrice.Size = new System.Drawing.Size(31, 13);
            this.lvlPrice.TabIndex = 9;
            this.lvlPrice.Text = "Price";
            this.lvlPrice.Click += new System.EventHandler(this.lvlPrice_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(266, 246);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 20);
            this.textBox4.TabIndex = 11;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(109, 249);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 12;
            this.lblMin.Text = "Min";
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
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 13);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Add Part";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtbxDynamicName
            // 
            this.txtbxDynamicName.Location = new System.Drawing.Point(146, 295);
            this.txtbxDynamicName.Name = "txtbxDynamicName";
            this.txtbxDynamicName.Size = new System.Drawing.Size(165, 20);
            this.txtbxDynamicName.TabIndex = 17;
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
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lvlPrice);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lvlPrice;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.RadioButton btnInHouse;
        private System.Windows.Forms.RadioButton btnOutSourced;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtbxDynamicName;
        private System.Windows.Forms.Label lblDynamicName;
    }
}