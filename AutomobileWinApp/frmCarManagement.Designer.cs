using System;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtReleaseYear = new TextBox();
            txtManufacturer = new TextBox();
            txtCarName = new TextBox();
            txtPrice = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(79, 103);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(118, 48);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(79, 206);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(178, 48);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new System.Drawing.Point(79, 301);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(233, 48);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(750, 107);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(98, 48);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new System.Drawing.Point(750, 202);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new System.Drawing.Size(217, 48);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(318, 100);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(398, 55);
            txtCarID.TabIndex = 5;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(978, 206);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(347, 55);
            txtReleaseYear.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new System.Drawing.Point(318, 298);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new System.Drawing.Size(398, 55);
            txtManufacturer.TabIndex = 7;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(318, 199);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(398, 55);
            txtCarName.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(978, 100);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(347, 55);
            txtPrice.TabIndex = 9;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(318, 407);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(217, 69);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(664, 407);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(213, 69);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(1023, 407);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(207, 69);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new System.Drawing.Point(18, 519);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 123;
            dgvCarList.RowTemplate.Height = 57;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new System.Drawing.Size(1346, 450);
            dgvCarList.TabIndex = 13;
            dgvCarList.CellDoubleClick += dgvCarList_CellDoubleClick;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(664, 1028);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(213, 65);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            ClientSize = new System.Drawing.Size(1376, 1126);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dgvCarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Button btnClose;
    }
}