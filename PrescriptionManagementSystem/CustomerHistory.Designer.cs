namespace PrescriptionManagementSystem
{
    partial class CustomerHistory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHistory));
            dataGridCustomer = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            lblCustomerName = new Label();
            ImgClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgClose).BeginInit();
            SuspendLayout();
            // 
            // dataGridCustomer
            // 
            dataGridCustomer.AllowUserToAddRows = false;
            dataGridCustomer.AllowUserToDeleteRows = false;
            dataGridCustomer.AllowUserToResizeColumns = false;
            dataGridCustomer.AllowUserToResizeRows = false;
            dataGridCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCustomer.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCustomer.ColumnHeadersHeight = 40;
            dataGridCustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridCustomer.EnableHeadersVisualStyles = false;
            dataGridCustomer.Location = new Point(18, 102);
            dataGridCustomer.MultiSelect = false;
            dataGridCustomer.Name = "dataGridCustomer";
            dataGridCustomer.ReadOnly = true;
            dataGridCustomer.RowHeadersVisible = false;
            dataGridCustomer.RowHeadersWidth = 30;
            dataGridCustomer.RowTemplate.DividerHeight = 2;
            dataGridCustomer.RowTemplate.Height = 34;
            dataGridCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCustomer.Size = new Size(1071, 455);
            dataGridCustomer.TabIndex = 22;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "DrugName";
            Column1.HeaderText = "Drug Name";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Condition";
            Column2.HeaderText = "Condition";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "DateGiven";
            Column3.HeaderText = "Date Administered";
            Column3.MinimumWidth = 20;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "PrescribedBy";
            Column4.HeaderText = "Prescribed By";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomerName.Location = new Point(27, 33);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(198, 32);
            lblCustomerName.TabIndex = 23;
            lblCustomerName.Text = "Customer Name";
            // 
            // ImgClose
            // 
            ImgClose.Image = (Image)resources.GetObject("ImgClose.Image");
            ImgClose.Location = new Point(1058, 2);
            ImgClose.Name = "ImgClose";
            ImgClose.Size = new Size(51, 52);
            ImgClose.SizeMode = PictureBoxSizeMode.StretchImage;
            ImgClose.TabIndex = 26;
            ImgClose.TabStop = false;
            ImgClose.Click += ImgClose_Click;
            // 
            // CustomerHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1110, 620);
            Controls.Add(ImgClose);
            Controls.Add(lblCustomerName);
            Controls.Add(dataGridCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerHistory";
            ((System.ComponentModel.ISupportInitialize)dataGridCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridCustomer;
        private Label lblCustomerName;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private PictureBox ImgClose;
    }
}