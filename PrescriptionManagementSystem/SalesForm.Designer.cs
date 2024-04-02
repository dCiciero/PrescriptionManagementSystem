namespace PrescriptionManagementSystem
{
    partial class SalesForm
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
            panelContent = new Panel();
            lblKey = new Label();
            btnSearchCustomer = new Button();
            label2 = new Label();
            lblBalance = new Label();
            label1 = new Label();
            txtAmountPaid = new TextBox();
            lblFirstname = new Label();
            panelControl = new Panel();
            lbltitle = new Label();
            btnClose = new Button();
            btnGenerateReceipt = new Button();
            label3 = new Label();
            txtSearchDrug = new TextBox();
            lstBoxReceipt = new ListBox();
            txtTotalPayable = new TextBox();
            dataGridDrugs = new DataGridView();
            DrugName = new DataGridViewTextBoxColumn();
            Condition = new DataGridViewTextBoxColumn();
            AvailableQty = new DataGridViewTextBoxColumn();
            UnitCost = new DataGridViewTextBoxColumn();
            IdCheck = new DataGridViewCheckBoxColumn();
            Stoke = new DataGridViewCheckBoxColumn();
            Hanley = new DataGridViewCheckBoxColumn();
            Fenton = new DataGridViewCheckBoxColumn();
            Tunstall = new DataGridViewCheckBoxColumn();
            Longton = new DataGridViewCheckBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            chkAddToList = new DataGridViewCheckBoxColumn();
            StockId = new DataGridViewTextBoxColumn();
            DrugId = new DataGridViewTextBoxColumn();
            lblCustomerId = new Label();
            panelContent.SuspendLayout();
            panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDrugs).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.Controls.Add(lblCustomerId);
            panelContent.Controls.Add(lblKey);
            panelContent.Controls.Add(btnSearchCustomer);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(lblBalance);
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(txtAmountPaid);
            panelContent.Controls.Add(lblFirstname);
            panelContent.Controls.Add(panelControl);
            panelContent.Controls.Add(btnGenerateReceipt);
            panelContent.Controls.Add(label3);
            panelContent.Controls.Add(txtSearchDrug);
            panelContent.Controls.Add(lstBoxReceipt);
            panelContent.Controls.Add(txtTotalPayable);
            panelContent.Controls.Add(dataGridDrugs);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1700, 707);
            panelContent.TabIndex = 0;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.BackColor = Color.Transparent;
            lblKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKey.ForeColor = Color.Red;
            lblKey.Location = new Point(604, 569);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(494, 32);
            lblKey.TabIndex = 126;
            lblKey.Text = "Items in red are not available in this branch.";
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.FlatStyle = FlatStyle.Flat;
            btnSearchCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchCustomer.ForeColor = Color.SteelBlue;
            btnSearchCustomer.Location = new Point(1498, 96);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(190, 39);
            btnSearchCustomer.TabIndex = 125;
            btnSearchCustomer.Text = "Lookup Customer";
            btnSearchCustomer.UseVisualStyleBackColor = true;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(445, 631);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 124;
            label2.Text = "Balance";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(455, 661);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(46, 25);
            lblBalance.TabIndex = 123;
            lblBalance.Text = "0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 631);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 121;
            label1.Text = "Amount Paid";
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmountPaid.Location = new Point(252, 654);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(168, 37);
            txtAmountPaid.TabIndex = 122;
            txtAmountPaid.Text = "0.00";
            txtAmountPaid.TextAlign = HorizontalAlignment.Right;
            txtAmountPaid.TextChanged += textBox1_TextChanged;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstname.Location = new Point(248, 559);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(142, 25);
            lblFirstname.TabIndex = 108;
            lblFirstname.Text = "Amount Payable";
            // 
            // panelControl
            // 
            panelControl.BackColor = Color.Gainsboro;
            panelControl.Controls.Add(lbltitle);
            panelControl.Controls.Add(btnClose);
            panelControl.Dock = DockStyle.Top;
            panelControl.Location = new Point(0, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1700, 55);
            panelControl.TabIndex = 120;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.SteelBlue;
            lbltitle.Location = new Point(541, 8);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(557, 38);
            lbltitle.TabIndex = 147;
            lbltitle.Text = "Prescription Management System - Sales";
            lbltitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1653, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 55);
            btnClose.TabIndex = 145;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnGenerateReceipt
            // 
            btnGenerateReceipt.FlatStyle = FlatStyle.Flat;
            btnGenerateReceipt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerateReceipt.ForeColor = Color.SteelBlue;
            btnGenerateReceipt.Location = new Point(1498, 648);
            btnGenerateReceipt.Name = "btnGenerateReceipt";
            btnGenerateReceipt.Size = new Size(190, 44);
            btnGenerateReceipt.TabIndex = 119;
            btnGenerateReceipt.Text = "Process Transaction";
            btnGenerateReceipt.UseVisualStyleBackColor = true;
            btnGenerateReceipt.Click += btnGenerateReceipt_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(252, 78);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 112;
            label3.Text = "Drug";
            // 
            // txtSearchDrug
            // 
            txtSearchDrug.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchDrug.Location = new Point(252, 101);
            txtSearchDrug.Name = "txtSearchDrug";
            txtSearchDrug.PlaceholderText = "Type drug name to search";
            txtSearchDrug.Size = new Size(1240, 37);
            txtSearchDrug.TabIndex = 111;
            txtSearchDrug.TextChanged += txtSearchDrug_TextChanged;
            // 
            // lstBoxReceipt
            // 
            lstBoxReceipt.FormattingEnabled = true;
            lstBoxReceipt.HorizontalScrollbar = true;
            lstBoxReceipt.ItemHeight = 25;
            lstBoxReceipt.Location = new Point(12, 93);
            lstBoxReceipt.Name = "lstBoxReceipt";
            lstBoxReceipt.Size = new Size(212, 329);
            lstBoxReceipt.TabIndex = 110;
            // 
            // txtTotalPayable
            // 
            txtTotalPayable.BackColor = Color.Gainsboro;
            txtTotalPayable.Enabled = false;
            txtTotalPayable.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalPayable.Location = new Point(250, 579);
            txtTotalPayable.Name = "txtTotalPayable";
            txtTotalPayable.Size = new Size(168, 37);
            txtTotalPayable.TabIndex = 109;
            txtTotalPayable.Text = "0.00";
            txtTotalPayable.TextAlign = HorizontalAlignment.Right;
            // 
            // dataGridDrugs
            // 
            dataGridDrugs.AllowUserToAddRows = false;
            dataGridDrugs.AllowUserToDeleteRows = false;
            dataGridDrugs.AllowUserToResizeColumns = false;
            dataGridDrugs.AllowUserToResizeRows = false;
            dataGridDrugs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridDrugs.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridDrugs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridDrugs.ColumnHeadersHeight = 40;
            dataGridDrugs.Columns.AddRange(new DataGridViewColumn[] { DrugName, Condition, AvailableQty, UnitCost, IdCheck, Stoke, Hanley, Fenton, Tunstall, Longton, Quantity, Price, chkAddToList, StockId, DrugId });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridDrugs.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridDrugs.EnableHeadersVisualStyles = false;
            dataGridDrugs.GridColor = Color.LightGray;
            dataGridDrugs.Location = new Point(252, 146);
            dataGridDrugs.MultiSelect = false;
            dataGridDrugs.Name = "dataGridDrugs";
            dataGridDrugs.RowHeadersVisible = false;
            dataGridDrugs.RowHeadersWidth = 30;
            dataGridDrugs.RowTemplate.DividerHeight = 2;
            dataGridDrugs.RowTemplate.Height = 34;
            dataGridDrugs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDrugs.Size = new Size(1445, 394);
            dataGridDrugs.TabIndex = 117;
            dataGridDrugs.CellContentClick += dataGridDrugs_CellContentClick;
            dataGridDrugs.CellDoubleClick += dataGridDrugs_CellDoubleClick;
            dataGridDrugs.CellLeave += dataGridDrugs_CellLeave;
            dataGridDrugs.CellValueChanged += dataGridDrugs_CellValueChanged;
            dataGridDrugs.DataBindingComplete += dataGridDrugs_DataBindingComplete;
            // 
            // DrugName
            // 
            DrugName.DataPropertyName = "Name";
            DrugName.HeaderText = "DrugName";
            DrugName.MinimumWidth = 8;
            DrugName.Name = "DrugName";
            DrugName.ReadOnly = true;
            DrugName.Width = 149;
            // 
            // Condition
            // 
            Condition.DataPropertyName = "Condition";
            Condition.HeaderText = "Condition";
            Condition.MinimumWidth = 8;
            Condition.Name = "Condition";
            Condition.ReadOnly = true;
            Condition.Width = 138;
            // 
            // AvailableQty
            // 
            AvailableQty.DataPropertyName = "Quantity";
            AvailableQty.HeaderText = "Available Qty";
            AvailableQty.MinimumWidth = 8;
            AvailableQty.Name = "AvailableQty";
            AvailableQty.Width = 174;
            // 
            // UnitCost
            // 
            UnitCost.DataPropertyName = "UnitCost";
            UnitCost.HeaderText = "UnitCost";
            UnitCost.MinimumWidth = 8;
            UnitCost.Name = "UnitCost";
            UnitCost.ReadOnly = true;
            UnitCost.Width = 127;
            // 
            // IdCheck
            // 
            IdCheck.DataPropertyName = "IdCheck";
            IdCheck.HeaderText = "Check Id";
            IdCheck.MinimumWidth = 8;
            IdCheck.Name = "IdCheck";
            IdCheck.ReadOnly = true;
            IdCheck.Resizable = DataGridViewTriState.True;
            IdCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            IdCheck.Width = 126;
            // 
            // Stoke
            // 
            Stoke.DataPropertyName = "InStoke";
            Stoke.HeaderText = "Stoke";
            Stoke.MinimumWidth = 8;
            Stoke.Name = "Stoke";
            Stoke.ReadOnly = true;
            Stoke.Resizable = DataGridViewTriState.True;
            Stoke.SortMode = DataGridViewColumnSortMode.Automatic;
            Stoke.Width = 99;
            // 
            // Hanley
            // 
            Hanley.DataPropertyName = "InHanley";
            Hanley.HeaderText = "Hanley";
            Hanley.MinimumWidth = 8;
            Hanley.Name = "Hanley";
            Hanley.ReadOnly = true;
            Hanley.Resizable = DataGridViewTriState.True;
            Hanley.SortMode = DataGridViewColumnSortMode.Automatic;
            Hanley.Width = 112;
            // 
            // Fenton
            // 
            Fenton.DataPropertyName = "InFenton";
            Fenton.HeaderText = "Fenton";
            Fenton.MinimumWidth = 8;
            Fenton.Name = "Fenton";
            Fenton.ReadOnly = true;
            Fenton.Resizable = DataGridViewTriState.True;
            Fenton.SortMode = DataGridViewColumnSortMode.Automatic;
            Fenton.Width = 111;
            // 
            // Tunstall
            // 
            Tunstall.DataPropertyName = "InTunstall";
            Tunstall.HeaderText = "Tunstall";
            Tunstall.MinimumWidth = 8;
            Tunstall.Name = "Tunstall";
            Tunstall.ReadOnly = true;
            Tunstall.Resizable = DataGridViewTriState.True;
            Tunstall.SortMode = DataGridViewColumnSortMode.Automatic;
            Tunstall.Width = 121;
            // 
            // Longton
            // 
            Longton.DataPropertyName = "InLongton";
            Longton.HeaderText = "Longton";
            Longton.MinimumWidth = 8;
            Longton.Name = "Longton";
            Longton.ReadOnly = true;
            Longton.Resizable = DataGridViewTriState.True;
            Longton.SortMode = DataGridViewColumnSortMode.Automatic;
            Longton.Width = 124;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.Width = 129;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 93;
            // 
            // chkAddToList
            // 
            chkAddToList.HeaderText = "AddToList";
            chkAddToList.MinimumWidth = 8;
            chkAddToList.Name = "chkAddToList";
            chkAddToList.Width = 109;
            // 
            // StockId
            // 
            StockId.DataPropertyName = "StockId";
            StockId.HeaderText = "StockId";
            StockId.MinimumWidth = 8;
            StockId.Name = "StockId";
            StockId.Visible = false;
            StockId.Width = 116;
            // 
            // DrugId
            // 
            DrugId.DataPropertyName = "DrugId";
            DrugId.HeaderText = "DrugId";
            DrugId.MinimumWidth = 8;
            DrugId.Name = "DrugId";
            DrugId.Visible = false;
            DrugId.Width = 111;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Location = new Point(1498, 58);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(77, 25);
            lblCustomerId.TabIndex = 127;
            lblCustomerId.Text = "Cust Id: ";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1700, 707);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesForm";
            Load += SalesForm_Load;
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panelControl.ResumeLayout(false);
            panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDrugs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private Button btnGenerateReceipt;
        private DataGridView dataGridDrugs;
        private Label label3;
        private TextBox txtSearchDrug;
        private ListBox lstBoxReceipt;
        private TextBox txtTotalPayable;
        private Label lblFirstname;
        private Panel panelControl;
        private Button btnClose;
        private Label label1;
        private TextBox txtAmountPaid;
        private Label lbltitle;
        private Label label2;
        private Label lblBalance;
        private Button btnSearchCustomer;
        private DataGridViewTextBoxColumn DrugName;
        private DataGridViewTextBoxColumn Condition;
        private DataGridViewTextBoxColumn AvailableQty;
        private DataGridViewTextBoxColumn UnitCost;
        private DataGridViewCheckBoxColumn IdCheck;
        private DataGridViewCheckBoxColumn Stoke;
        private DataGridViewCheckBoxColumn Hanley;
        private DataGridViewCheckBoxColumn Fenton;
        private DataGridViewCheckBoxColumn Tunstall;
        private DataGridViewCheckBoxColumn Longton;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewCheckBoxColumn chkAddToList;
        private DataGridViewTextBoxColumn StockId;
        private DataGridViewTextBoxColumn DrugId;
        private Label lblKey;
        private Label lblCustomerId;
    }
}