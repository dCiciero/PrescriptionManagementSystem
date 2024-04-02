namespace PrescriptionManagementSystem
{
    partial class Admin
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
            btnLoadData = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(41, 82);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(112, 34);
            btnLoadData.TabIndex = 0;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(344, 208);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnLoadData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadData;
        private Button btnClose;
    }
}