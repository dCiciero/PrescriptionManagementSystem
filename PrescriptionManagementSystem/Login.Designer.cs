namespace PrescriptionManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lbltitle = new Label();
            txtEmail = new TextBox();
            lblLoginUsername = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pbSignout = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnReset = new Button();
            panel2 = new Panel();
            label1 = new Label();
            cmbBoxStores = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbSignout).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.SteelBlue;
            lbltitle.Location = new Point(309, 28);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(462, 38);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Prescription Management System";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(299, 137);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(427, 39);
            txtEmail.TabIndex = 1;
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLoginUsername.ForeColor = Color.SteelBlue;
            lblLoginUsername.Location = new Point(309, 112);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(65, 28);
            lblLoginUsername.TabIndex = 2;
            lblLoginUsername.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.SteelBlue;
            lblPassword.Location = new Point(309, 185);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(299, 212);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(427, 39);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.SteelBlue;
            btnLogin.Location = new Point(34, 332);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(167, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pbSignout
            // 
            pbSignout.BackgroundImageLayout = ImageLayout.None;
            pbSignout.Image = (Image)resources.GetObject("pbSignout.Image");
            pbSignout.Location = new Point(433, 364);
            pbSignout.Name = "pbSignout";
            pbSignout.Size = new Size(34, 36);
            pbSignout.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSignout.TabIndex = 9;
            pbSignout.TabStop = false;
            pbSignout.Click += pbSignout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 413);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderColor = Color.SteelBlue;
            btnReset.FlatAppearance.BorderSize = 2;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnReset.ForeColor = Color.SteelBlue;
            btnReset.Location = new Point(233, 332);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(167, 45);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbBoxStores);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(pbSignout);
            panel2.Controls.Add(btnLogin);
            panel2.Location = new Point(289, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 410);
            panel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(20, 254);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 13;
            label1.Text = "Store";
            // 
            // cmbBoxStores
            // 
            cmbBoxStores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxStores.FormattingEnabled = true;
            cmbBoxStores.Location = new Point(10, 280);
            cmbBoxStores.Name = "cmbBoxStores";
            cmbBoxStores.Size = new Size(427, 40);
            cmbBoxStores.TabIndex = 10;
            cmbBoxStores.SelectedIndexChanged += cmbBoxStores_SelectedIndexChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(769, 417);
            Controls.Add(panel1);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblLoginUsername);
            Controls.Add(txtEmail);
            Controls.Add(lbltitle);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pbSignout).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private TextBox txtEmail;
        private Label lblLoginUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox pbSignout;
        private Panel panel1;
        private Button btnReset;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private ComboBox cmbBoxStores;
    }
}
