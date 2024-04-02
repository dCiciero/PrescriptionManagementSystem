namespace PrescriptionManagementSystem
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            label1 = new Label();
            txtOldPassword = new TextBox();
            label2 = new Label();
            txtNewPassword = new TextBox();
            label3 = new Label();
            txtConfirmNewPassword = new TextBox();
            btnReset = new PictureBox();
            ImgSave = new PictureBox();
            panel3 = new Panel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)btnReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgSave).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 71);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 83;
            label1.Text = "Old Password";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOldPassword.Location = new Point(108, 93);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.PlaceholderText = "Enter Old Password";
            txtOldPassword.Size = new Size(434, 39);
            txtOldPassword.TabIndex = 84;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(124, 149);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 85;
            label2.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(108, 171);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.PlaceholderText = "Enter New Password";
            txtNewPassword.Size = new Size(434, 39);
            txtNewPassword.TabIndex = 86;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(124, 235);
            label3.Name = "label3";
            label3.Size = new Size(205, 25);
            label3.TabIndex = 87;
            label3.Text = "Confirm New Password";
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmNewPassword.Location = new Point(108, 257);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.PasswordChar = '*';
            txtConfirmNewPassword.PlaceholderText = "Confirm New Password";
            txtConfirmNewPassword.Size = new Size(434, 39);
            txtConfirmNewPassword.TabIndex = 88;
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(502, 327);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(40, 52);
            btnReset.SizeMode = PictureBoxSizeMode.Zoom;
            btnReset.TabIndex = 98;
            btnReset.TabStop = false;
            // 
            // ImgSave
            // 
            ImgSave.Image = (Image)resources.GetObject("ImgSave.Image");
            ImgSave.Location = new Point(456, 327);
            ImgSave.Name = "ImgSave";
            ImgSave.Size = new Size(40, 52);
            ImgSave.SizeMode = PictureBoxSizeMode.Zoom;
            ImgSave.TabIndex = 97;
            ImgSave.TabStop = false;
            ImgSave.Click += ImgSave_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(btnClose);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(638, 45);
            panel3.TabIndex = 99;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(591, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 45);
            btnClose.TabIndex = 145;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(638, 396);
            Controls.Add(panel3);
            Controls.Add(btnReset);
            Controls.Add(ImgSave);
            Controls.Add(label3);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(label2);
            Controls.Add(txtNewPassword);
            Controls.Add(label1);
            Controls.Add(txtOldPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordForm";
            Load += ChangePasswordForm_Load;
            ((System.ComponentModel.ISupportInitialize)btnReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgSave).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOldPassword;
        private Label label2;
        private TextBox txtNewPassword;
        private Label label3;
        private TextBox txtConfirmNewPassword;
        private PictureBox btnReset;
        private PictureBox ImgSave;
        private Panel panel3;
        private Button btnClose;
    }
}