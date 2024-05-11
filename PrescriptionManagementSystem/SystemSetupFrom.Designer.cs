namespace PrescriptionManagementSystem
{
    partial class SystemSetupFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemSetupFrom));
            lblCompanyName = new Label();
            txtCompanyName = new TextBox();
            lblCompanyAddress = new Label();
            txtCompanyAddress = new TextBox();
            lblCompanyEmail = new Label();
            txtCompanyEmail = new TextBox();
            btnReset = new PictureBox();
            ImgSave = new PictureBox();
            panel1 = new Panel();
            lbltitle = new Label();
            btnClose = new Button();
            label1 = new Label();
            lblCompanyPhone = new Label();
            txtCompanyPhone = new TextBox();
            nudStockLevel = new NumericUpDown();
            nudSaleQty = new NumericUpDown();
            label2 = new Label();
            btnLoadData = new Button();
            ((System.ComponentModel.ISupportInitialize)btnReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgSave).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSaleQty).BeginInit();
            SuspendLayout();
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompanyName.Location = new Point(43, 69);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(144, 25);
            lblCompanyName.TabIndex = 83;
            lblCompanyName.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompanyName.Location = new Point(27, 91);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.PlaceholderText = "Company Name";
            txtCompanyName.Size = new Size(882, 39);
            txtCompanyName.TabIndex = 84;
            // 
            // lblCompanyAddress
            // 
            lblCompanyAddress.AutoSize = true;
            lblCompanyAddress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompanyAddress.Location = new Point(43, 147);
            lblCompanyAddress.Name = "lblCompanyAddress";
            lblCompanyAddress.Size = new Size(162, 25);
            lblCompanyAddress.TabIndex = 85;
            lblCompanyAddress.Text = "Company Address";
            // 
            // txtCompanyAddress
            // 
            txtCompanyAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompanyAddress.Location = new Point(27, 169);
            txtCompanyAddress.Name = "txtCompanyAddress";
            txtCompanyAddress.PlaceholderText = "Enter Company Address";
            txtCompanyAddress.Size = new Size(882, 39);
            txtCompanyAddress.TabIndex = 86;
            // 
            // lblCompanyEmail
            // 
            lblCompanyEmail.AutoSize = true;
            lblCompanyEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompanyEmail.Location = new Point(43, 221);
            lblCompanyEmail.Name = "lblCompanyEmail";
            lblCompanyEmail.Size = new Size(139, 25);
            lblCompanyEmail.TabIndex = 87;
            lblCompanyEmail.Text = "Company Email";
            // 
            // txtCompanyEmail
            // 
            txtCompanyEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompanyEmail.Location = new Point(27, 243);
            txtCompanyEmail.Name = "txtCompanyEmail";
            txtCompanyEmail.PlaceholderText = "Company Email";
            txtCompanyEmail.Size = new Size(882, 39);
            txtCompanyEmail.TabIndex = 88;
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(869, 396);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(40, 40);
            btnReset.SizeMode = PictureBoxSizeMode.Zoom;
            btnReset.TabIndex = 98;
            btnReset.TabStop = false;
            btnReset.Click += btnReset_Click;
            // 
            // ImgSave
            // 
            ImgSave.Image = (Image)resources.GetObject("ImgSave.Image");
            ImgSave.Location = new Point(816, 396);
            ImgSave.Name = "ImgSave";
            ImgSave.Size = new Size(40, 40);
            ImgSave.SizeMode = PictureBoxSizeMode.Zoom;
            ImgSave.TabIndex = 97;
            ImgSave.TabStop = false;
            ImgSave.Click += ImgSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(lbltitle);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 55);
            panel1.TabIndex = 99;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.SteelBlue;
            lbltitle.Location = new Point(124, 6);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(666, 38);
            lbltitle.TabIndex = 146;
            lbltitle.Text = "Prescription Management System - System Setup";
            lbltitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(886, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 55);
            btnClose.TabIndex = 145;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(477, 291);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 102;
            label1.Text = "Minimum Stock Level";
            // 
            // lblCompanyPhone
            // 
            lblCompanyPhone.AutoSize = true;
            lblCompanyPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompanyPhone.Location = new Point(43, 296);
            lblCompanyPhone.Name = "lblCompanyPhone";
            lblCompanyPhone.Size = new Size(148, 25);
            lblCompanyPhone.TabIndex = 100;
            lblCompanyPhone.Text = "Company Phone";
            // 
            // txtCompanyPhone
            // 
            txtCompanyPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompanyPhone.Location = new Point(27, 318);
            txtCompanyPhone.Name = "txtCompanyPhone";
            txtCompanyPhone.PlaceholderText = "Enter Company Phone";
            txtCompanyPhone.Size = new Size(434, 39);
            txtCompanyPhone.TabIndex = 101;
            // 
            // nudStockLevel
            // 
            nudStockLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudStockLevel.Location = new Point(477, 319);
            nudStockLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudStockLevel.Name = "nudStockLevel";
            nudStockLevel.Size = new Size(180, 39);
            nudStockLevel.TabIndex = 104;
            nudStockLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudSaleQty
            // 
            nudSaleQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudSaleQty.Location = new Point(718, 319);
            nudSaleQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSaleQty.Name = "nudSaleQty";
            nudSaleQty.Size = new Size(180, 39);
            nudSaleQty.TabIndex = 106;
            nudSaleQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(718, 291);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 105;
            label2.Text = "Max Sale Quantity";
            // 
            // btnLoadData
            // 
            btnLoadData.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadData.ForeColor = Color.SteelBlue;
            btnLoadData.Location = new Point(644, 396);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(130, 45);
            btnLoadData.TabIndex = 107;
            btnLoadData.Text = "View Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // SystemSetupFrom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 475);
            Controls.Add(btnLoadData);
            Controls.Add(nudSaleQty);
            Controls.Add(label2);
            Controls.Add(nudStockLevel);
            Controls.Add(label1);
            Controls.Add(lblCompanyPhone);
            Controls.Add(txtCompanyPhone);
            Controls.Add(panel1);
            Controls.Add(btnReset);
            Controls.Add(ImgSave);
            Controls.Add(lblCompanyEmail);
            Controls.Add(txtCompanyEmail);
            Controls.Add(lblCompanyAddress);
            Controls.Add(txtCompanyAddress);
            Controls.Add(lblCompanyName);
            Controls.Add(txtCompanyName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SystemSetupFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordForm";
            Load += ChangePasswordForm_Load;
            ((System.ComponentModel.ISupportInitialize)btnReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgSave).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSaleQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCompanyName;
        private TextBox txtCompanyName;
        private Label lblCompanyAddress;
        private TextBox txtCompanyAddress;
        private Label lblCompanyEmail;
        private TextBox txtCompanyEmail;
        private PictureBox btnReset;
        private PictureBox ImgSave;
        private Panel panel1;
        private Label lbltitle;
        private Button btnClose;
        private Label label1;
        private Label lblCompanyPhone;
        private TextBox txtCompanyPhone;
        private NumericUpDown nudStockLevel;
        private NumericUpDown nudSaleQty;
        private Label label2;
        private Button btnLoadData;
    }
}