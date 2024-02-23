namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            lbCarID = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            lbManufacturer = new System.Windows.Forms.Label();
            lbReleaseYear = new System.Windows.Forms.Label();
            txtCarID = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.MaskedTextBox();
            txtReleaseYear = new System.Windows.Forms.MaskedTextBox();
            cboManufacturer = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(105, 147);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(118, 48);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(105, 251);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(178, 48);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(105, 479);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(98, 48);
            lbPrice.TabIndex = 2;
            lbPrice.Text = "Price";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new System.Drawing.Point(105, 365);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(233, 48);
            lbManufacturer.TabIndex = 3;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new System.Drawing.Point(105, 583);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new System.Drawing.Size(217, 48);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(400, 140);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(520, 55);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(400, 244);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(520, 55);
            txtCarName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(400, 472);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(527, 55);
            txtPrice.TabIndex = 7;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(400, 576);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(527, 55);
            txtReleaseYear.TabIndex = 8;
            txtReleaseYear.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi\t", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new System.Drawing.Point(400, 357);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new System.Drawing.Size(520, 56);
            cboManufacturer.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(400, 699);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(225, 69);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(702, 699);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(225, 69);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            ClientSize = new System.Drawing.Size(1091, 1093);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbManufacturer);
            Controls.Add(lbPrice);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtReleaseYear;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}