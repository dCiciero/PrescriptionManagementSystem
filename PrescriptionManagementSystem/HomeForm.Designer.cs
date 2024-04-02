namespace PrescriptionManagementSystem
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            btnExit = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(163, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1529, 862);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 811);
            panel4.Name = "panel4";
            panel4.Size = new Size(1529, 51);
            panel4.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1529, 50);
            panel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(863, 4);
            label6.Name = "label6";
            label6.Size = new Size(85, 32);
            label6.TabIndex = 10;
            label6.Text = "Admin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(704, 5);
            label5.Name = "label5";
            label5.Size = new Size(119, 32);
            label5.TabIndex = 9;
            label5.Text = "Inventory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(574, 5);
            label4.Name = "label4";
            label4.Size = new Size(69, 32);
            label4.TabIndex = 8;
            label4.Text = "Sales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(373, 5);
            label3.Name = "label3";
            label3.Size = new Size(153, 32);
            label3.TabIndex = 7;
            label3.Text = "Prescriptions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(191, 5);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 5;
            label2.Text = "Customers";
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Location = new Point(44, 45);
            panel5.Name = "panel5";
            panel5.Size = new Size(104, 3);
            panel5.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1545, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(54, 38);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 3;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 4);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 1;
            label1.Text = "Home";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 196);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(252, 761);
            panel3.TabIndex = 3;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1692, 862);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            Load += HomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox btnExit;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel3;
    }
}