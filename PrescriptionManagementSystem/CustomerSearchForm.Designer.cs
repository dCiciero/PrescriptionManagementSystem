namespace PrescriptionManagementSystem
{
    partial class CustomerSearchForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelPrescriptionHistory = new Panel();
            btnCustSale = new Button();
            btnHideHistory = new Button();
            dgvPrescriptionHistory = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Condition = new DataGridViewTextBoxColumn();
            DateSold = new DataGridViewTextBoxColumn();
            SoldBy = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            lbltitle = new Label();
            btnClose = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            dgvCustomer = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            OtherName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Vulnerable = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            lblFirstname = new Label();
            txtSearchCustomer = new TextBox();
            panelPrescriptionHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptionHistory).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // panelPrescriptionHistory
            // 
            panelPrescriptionHistory.BackColor = Color.WhiteSmoke;
            panelPrescriptionHistory.Controls.Add(btnCustSale);
            panelPrescriptionHistory.Controls.Add(btnHideHistory);
            panelPrescriptionHistory.Controls.Add(dgvPrescriptionHistory);
            panelPrescriptionHistory.Dock = DockStyle.Bottom;
            panelPrescriptionHistory.Location = new Point(0, 549);
            panelPrescriptionHistory.Name = "panelPrescriptionHistory";
            panelPrescriptionHistory.Size = new Size(1395, 377);
            panelPrescriptionHistory.TabIndex = 26;
            // 
            // btnCustSale
            // 
            btnCustSale.FlatStyle = FlatStyle.Flat;
            btnCustSale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustSale.ForeColor = Color.SteelBlue;
            btnCustSale.Location = new Point(1048, 16);
            btnCustSale.Name = "btnCustSale";
            btnCustSale.Size = new Size(168, 43);
            btnCustSale.TabIndex = 29;
            btnCustSale.Text = "Conitue with sale";
            btnCustSale.UseVisualStyleBackColor = true;
            btnCustSale.Click += btnCustSale_Click;
            // 
            // btnHideHistory
            // 
            btnHideHistory.FlatStyle = FlatStyle.Flat;
            btnHideHistory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHideHistory.ForeColor = Color.SteelBlue;
            btnHideHistory.Location = new Point(1239, 16);
            btnHideHistory.Name = "btnHideHistory";
            btnHideHistory.Size = new Size(139, 43);
            btnHideHistory.TabIndex = 28;
            btnHideHistory.Text = "Close History";
            btnHideHistory.UseVisualStyleBackColor = true;
            btnHideHistory.Click += btnHideHistory_Click;
            // 
            // dgvPrescriptionHistory
            // 
            dgvPrescriptionHistory.AllowUserToAddRows = false;
            dgvPrescriptionHistory.AllowUserToDeleteRows = false;
            dgvPrescriptionHistory.AllowUserToResizeColumns = false;
            dgvPrescriptionHistory.AllowUserToResizeRows = false;
            dgvPrescriptionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptionHistory.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dgvPrescriptionHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPrescriptionHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrescriptionHistory.ColumnHeadersHeight = 40;
            dgvPrescriptionHistory.Columns.AddRange(new DataGridViewColumn[] { ProductName, Condition, DateSold, SoldBy });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPrescriptionHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPrescriptionHistory.EnableHeadersVisualStyles = false;
            dgvPrescriptionHistory.Location = new Point(11, 63);
            dgvPrescriptionHistory.MultiSelect = false;
            dgvPrescriptionHistory.Name = "dgvPrescriptionHistory";
            dgvPrescriptionHistory.ReadOnly = true;
            dgvPrescriptionHistory.RowHeadersVisible = false;
            dgvPrescriptionHistory.RowHeadersWidth = 30;
            dgvPrescriptionHistory.RowTemplate.DividerHeight = 2;
            dgvPrescriptionHistory.RowTemplate.Height = 34;
            dgvPrescriptionHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrescriptionHistory.Size = new Size(1367, 301);
            dgvPrescriptionHistory.TabIndex = 27;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Drug Name";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Condition
            // 
            Condition.DataPropertyName = "Condition";
            Condition.HeaderText = "Condition";
            Condition.MinimumWidth = 8;
            Condition.Name = "Condition";
            Condition.ReadOnly = true;
            // 
            // DateSold
            // 
            DateSold.DataPropertyName = "DateSold";
            DateSold.HeaderText = "Date Administered";
            DateSold.MinimumWidth = 20;
            DateSold.Name = "DateSold";
            DateSold.ReadOnly = true;
            // 
            // SoldBy
            // 
            SoldBy.DataPropertyName = "SoldBy";
            SoldBy.HeaderText = "Sold By";
            SoldBy.MinimumWidth = 8;
            SoldBy.Name = "SoldBy";
            SoldBy.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(lbltitle);
            panel3.Controls.Add(btnClose);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1395, 55);
            panel3.TabIndex = 27;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.SteelBlue;
            lbltitle.Location = new Point(359, 7);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(711, 38);
            lbltitle.TabIndex = 30;
            lbltitle.Text = "Prescription Management System - Search Customer";
            lbltitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1348, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 55);
            btnClose.TabIndex = 145;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvCustomer);
            panel1.Controls.Add(lblFirstname);
            panel1.Controls.Add(txtSearchCustomer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1395, 494);
            panel1.TabIndex = 28;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(16, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(1357, 8);
            panel2.TabIndex = 29;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Location = new Point(0, 361);
            panel5.Name = "panel5";
            panel5.Size = new Size(1362, 5);
            panel5.TabIndex = 23;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.AllowUserToResizeColumns = false;
            dgvCustomer.AllowUserToResizeRows = false;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCustomer.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dgvCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomer.ColumnHeadersHeight = 40;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { FirstName, OtherName, LastName, Column4, Age, Column5, Column6, Column7, Column8, Column9, Column10, Vulnerable, Id });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCustomer.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.Location = new Point(19, 162);
            dgvCustomer.MultiSelect = false;
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.RowHeadersWidth = 30;
            dgvCustomer.RowTemplate.DividerHeight = 2;
            dgvCustomer.RowTemplate.Height = 34;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size = new Size(1359, 318);
            dgvCustomer.TabIndex = 28;
            dgvCustomer.CellDoubleClick += dataGridCustomer_CellContentDoubleClick;
            dgvCustomer.DataBindingComplete += dataGridCustomer_DataBindingComplete;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.FillWeight = 65F;
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 8;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 149;
            // 
            // OtherName
            // 
            OtherName.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            OtherName.DataPropertyName = "OtherName";
            OtherName.FillWeight = 67F;
            OtherName.HeaderText = "Middle Name";
            OtherName.MinimumWidth = 8;
            OtherName.Name = "OtherName";
            OtherName.ReadOnly = true;
            OtherName.Width = 174;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.FillWeight = 65F;
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 8;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 146;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "DateOfBirth";
            Column4.FillWeight = 70F;
            Column4.HeaderText = "DOB";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 89;
            // 
            // Age
            // 
            Age.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Age.DataPropertyName = "Age";
            Age.HeaderText = "Age";
            Age.MinimumWidth = 8;
            Age.Name = "Age";
            Age.ReadOnly = true;
            Age.Width = 83;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "HouseNo";
            Column5.FillWeight = 60F;
            Column5.HeaderText = "House No";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 139;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column6.DataPropertyName = "StreetName";
            Column6.FillWeight = 65F;
            Column6.HeaderText = "Street Name";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 165;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column7.DataPropertyName = "PostCode";
            Column7.FillWeight = 50F;
            Column7.HeaderText = "Post Code";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 139;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "City";
            Column8.FillWeight = 50F;
            Column8.HeaderText = "City";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 83;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "County";
            Column9.FillWeight = 50F;
            Column9.HeaderText = "County";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 113;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "Country";
            Column10.FillWeight = 50F;
            Column10.HeaderText = "Country";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 122;
            // 
            // Vulnerable
            // 
            Vulnerable.DataPropertyName = "Vulnerable";
            Vulnerable.FillWeight = 50F;
            Vulnerable.HeaderText = "Vulnerable";
            Vulnerable.MinimumWidth = 8;
            Vulnerable.Name = "Vulnerable";
            Vulnerable.ReadOnly = true;
            Vulnerable.Width = 147;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 64;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstname.Location = new Point(39, 66);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(104, 25);
            lblFirstname.TabIndex = 26;
            lblFirstname.Text = "Enter Name";
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchCustomer.Location = new Point(19, 85);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(1359, 39);
            txtSearchCustomer.TabIndex = 27;
            txtSearchCustomer.TextChanged += txtSearchCustomer_TextChanged;
            // 
            // CustomerSearchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1395, 926);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panelPrescriptionHistory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerSearchForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CustomerSearchForm";
            Load += CustomerSearchForm_Load;
            panelPrescriptionHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptionHistory).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtFirstName;
        private DataGridView dataGridViewHistory;
        private Panel panelHistory;
        private Panel panel4;
        private Panel panelPrescriptionHistory;
        private Button btnHideHistory;
        private DataGridView dgvPrescriptionHistory;
        private Panel panel3;
        private Button btnClose;
        private Panel panel1;
        private Label lbltitle;
        private Panel panel2;
        private Panel panel5;
        private DataGridView dgvCustomer;
        private Label lblFirstname;
        private TextBox txtSearchCustomer;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn OtherName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Vulnerable;
        private DataGridViewTextBoxColumn Id;
        private Button btnCustSale;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Condition;
        private DataGridViewTextBoxColumn DateSold;
        private DataGridViewTextBoxColumn SoldBy;
    }
}