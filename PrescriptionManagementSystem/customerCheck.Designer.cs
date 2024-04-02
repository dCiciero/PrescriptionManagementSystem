namespace PrescriptionManagementSystem
{
    partial class customerCheck
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            medication = new DataGridViewTextBoxColumn();
            condition = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(393, 39);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(411, 35);
            button1.Name = "button1";
            button1.Size = new Size(41, 39);
            button1.TabIndex = 2;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { medication, condition, date });
            dataGridView1.Location = new Point(12, 198);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(545, 225);
            dataGridView1.TabIndex = 3;
            // 
            // medication
            // 
            medication.HeaderText = "Medication";
            medication.MinimumWidth = 8;
            medication.Name = "medication";
            medication.Width = 150;
            // 
            // condition
            // 
            condition.HeaderText = "Condition";
            condition.MinimumWidth = 8;
            condition.Name = "condition";
            condition.Width = 150;
            // 
            // date
            // 
            date.HeaderText = "Date Administered";
            date.MinimumWidth = 8;
            date.Name = "date";
            date.Width = 150;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(11, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(1136, 11);
            panel1.TabIndex = 19;
            // 
            // customerCheck
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 514);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "customerCheck";
            Text = "customerCheck";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn medication;
        private DataGridViewTextBoxColumn condition;
        private DataGridViewTextBoxColumn date;
        private Panel panel1;
    }
}