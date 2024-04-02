namespace PrescriptionManagementSystem
{
    partial class StockManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockManagementForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lbltitle = new Label();
            panelHeader = new Panel();
            btnClose = new Button();
            panelContent = new Panel();
            panelBulkEntry = new Panel();
            dataGridDrugsBulkEntry = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            panelSingleEntry = new Panel();
            label7 = new Label();
            txtCondition = new TextBox();
            chkBoxCheckId = new CheckBox();
            label6 = new Label();
            panel3 = new Panel();
            chkBoxLongton = new CheckBox();
            chkBoxStoke = new CheckBox();
            chkBoxFenton = new CheckBox();
            chkBoxTunstall = new CheckBox();
            chkBoxHanley = new CheckBox();
            btnReset = new PictureBox();
            ImgSave = new PictureBox();
            label5 = new Label();
            txtMinStockLevel = new TextBox();
            label4 = new Label();
            txtReorderQty = new TextBox();
            label3 = new Label();
            txtUnitCost = new TextBox();
            label2 = new Label();
            dtpExpiryDate = new DateTimePicker();
            label1 = new Label();
            txtQuantity = new TextBox();
            panel1 = new Panel();
            dataGridDrugs = new DataGridView();
            DrugName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ExpiryDate = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            lblFirstname = new Label();
            txtDrugName = new TextBox();
            panelControl = new Panel();
            btnGetFile = new Button();
            panel2 = new Panel();
            panelOption = new Panel();
            rdBtnBulkEntry = new RadioButton();
            rdBtnSingleEntry = new RadioButton();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            panelBulkEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDrugsBulkEntry).BeginInit();
            panelSingleEntry.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDrugs).BeginInit();
            panelControl.SuspendLayout();
            panelOption.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.SteelBlue;
            lbltitle.Location = new Point(226, 8);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(689, 38);
            lbltitle.TabIndex = 30;
            lbltitle.Text = "Prescription Management System - Drug Inventory";
            lbltitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Gainsboro;
            panelHeader.Controls.Add(btnClose);
            panelHeader.Controls.Add(lbltitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1246, 55);
            panelHeader.TabIndex = 37;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1199, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 55);
            btnClose.TabIndex = 145;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panelBulkEntry);
            panelContent.Controls.Add(panelSingleEntry);
            panelContent.Controls.Add(panelControl);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 55);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1246, 719);
            panelContent.TabIndex = 38;
            // 
            // panelBulkEntry
            // 
            panelBulkEntry.BackColor = Color.Transparent;
            panelBulkEntry.Controls.Add(dataGridDrugsBulkEntry);
            panelBulkEntry.Location = new Point(25, 413);
            panelBulkEntry.Name = "panelBulkEntry";
            panelBulkEntry.Size = new Size(1147, 299);
            panelBulkEntry.TabIndex = 192;
            // 
            // dataGridDrugsBulkEntry
            // 
            dataGridDrugsBulkEntry.AllowUserToAddRows = false;
            dataGridDrugsBulkEntry.AllowUserToDeleteRows = false;
            dataGridDrugsBulkEntry.AllowUserToResizeColumns = false;
            dataGridDrugsBulkEntry.AllowUserToResizeRows = false;
            dataGridDrugsBulkEntry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDrugsBulkEntry.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridDrugsBulkEntry.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridDrugsBulkEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridDrugsBulkEntry.ColumnHeadersHeight = 40;
            dataGridDrugsBulkEntry.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewImageColumn1 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridDrugsBulkEntry.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridDrugsBulkEntry.EnableHeadersVisualStyles = false;
            dataGridDrugsBulkEntry.Location = new Point(16, 48);
            dataGridDrugsBulkEntry.MultiSelect = false;
            dataGridDrugsBulkEntry.Name = "dataGridDrugsBulkEntry";
            dataGridDrugsBulkEntry.ReadOnly = true;
            dataGridDrugsBulkEntry.RowHeadersVisible = false;
            dataGridDrugsBulkEntry.RowHeadersWidth = 30;
            dataGridDrugsBulkEntry.RowTemplate.DividerHeight = 2;
            dataGridDrugsBulkEntry.RowTemplate.Height = 34;
            dataGridDrugsBulkEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDrugsBulkEntry.Size = new Size(1212, 529);
            dataGridDrugsBulkEntry.TabIndex = 178;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.FillWeight = 125.757576F;
            dataGridViewTextBoxColumn1.HeaderText = "Drug Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            dataGridViewTextBoxColumn2.FillWeight = 125.757576F;
            dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Expiry";
            dataGridViewTextBoxColumn3.FillWeight = 125.757576F;
            dataGridViewTextBoxColumn3.HeaderText = "Expiry Date";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.FillWeight = 22.727272F;
            dataGridViewImageColumn1.HeaderText = "Delete";
            dataGridViewImageColumn1.Image = (Image)resources.GetObject("dataGridViewImageColumn1.Image");
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn1.MinimumWidth = 8;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.ReadOnly = true;
            dataGridViewImageColumn1.Resizable = DataGridViewTriState.False;
            // 
            // panelSingleEntry
            // 
            panelSingleEntry.BackColor = Color.WhiteSmoke;
            panelSingleEntry.Controls.Add(label7);
            panelSingleEntry.Controls.Add(txtCondition);
            panelSingleEntry.Controls.Add(chkBoxCheckId);
            panelSingleEntry.Controls.Add(label6);
            panelSingleEntry.Controls.Add(panel3);
            panelSingleEntry.Controls.Add(btnReset);
            panelSingleEntry.Controls.Add(ImgSave);
            panelSingleEntry.Controls.Add(label5);
            panelSingleEntry.Controls.Add(txtMinStockLevel);
            panelSingleEntry.Controls.Add(label4);
            panelSingleEntry.Controls.Add(txtReorderQty);
            panelSingleEntry.Controls.Add(label3);
            panelSingleEntry.Controls.Add(txtUnitCost);
            panelSingleEntry.Controls.Add(label2);
            panelSingleEntry.Controls.Add(dtpExpiryDate);
            panelSingleEntry.Controls.Add(label1);
            panelSingleEntry.Controls.Add(txtQuantity);
            panelSingleEntry.Controls.Add(panel1);
            panelSingleEntry.Controls.Add(dataGridDrugs);
            panelSingleEntry.Controls.Add(lblFirstname);
            panelSingleEntry.Controls.Add(txtDrugName);
            panelSingleEntry.Location = new Point(0, 73);
            panelSingleEntry.Name = "panelSingleEntry";
            panelSingleEntry.Size = new Size(1220, 320);
            panelSingleEntry.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(620, 13);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 200;
            label7.Text = "Condition";
            // 
            // txtCondition
            // 
            txtCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCondition.Location = new Point(613, 37);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(582, 39);
            txtCondition.TabIndex = 201;
            // 
            // chkBoxCheckId
            // 
            chkBoxCheckId.AutoSize = true;
            chkBoxCheckId.Location = new Point(50, 184);
            chkBoxCheckId.Name = "chkBoxCheckId";
            chkBoxCheckId.Size = new Size(131, 29);
            chkBoxCheckId.TabIndex = 198;
            chkBoxCheckId.Text = "ID Required";
            chkBoxCheckId.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(257, 185);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 199;
            label6.Text = "Available In";
            // 
            // panel3
            // 
            panel3.Controls.Add(chkBoxLongton);
            panel3.Controls.Add(chkBoxStoke);
            panel3.Controls.Add(chkBoxFenton);
            panel3.Controls.Add(chkBoxTunstall);
            panel3.Controls.Add(chkBoxHanley);
            panel3.Location = new Point(365, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(574, 54);
            panel3.TabIndex = 198;
            // 
            // chkBoxLongton
            // 
            chkBoxLongton.AutoSize = true;
            chkBoxLongton.Location = new Point(445, 13);
            chkBoxLongton.Name = "chkBoxLongton";
            chkBoxLongton.Size = new Size(105, 29);
            chkBoxLongton.TabIndex = 197;
            chkBoxLongton.Text = "Longton";
            chkBoxLongton.UseVisualStyleBackColor = true;
            // 
            // chkBoxStoke
            // 
            chkBoxStoke.AutoSize = true;
            chkBoxStoke.Location = new Point(31, 13);
            chkBoxStoke.Name = "chkBoxStoke";
            chkBoxStoke.Size = new Size(82, 29);
            chkBoxStoke.TabIndex = 193;
            chkBoxStoke.Text = "Stoke";
            chkBoxStoke.UseVisualStyleBackColor = true;
            // 
            // chkBoxFenton
            // 
            chkBoxFenton.AutoSize = true;
            chkBoxFenton.Location = new Point(346, 13);
            chkBoxFenton.Name = "chkBoxFenton";
            chkBoxFenton.Size = new Size(93, 29);
            chkBoxFenton.TabIndex = 196;
            chkBoxFenton.Text = "Fenton";
            chkBoxFenton.UseVisualStyleBackColor = true;
            // 
            // chkBoxTunstall
            // 
            chkBoxTunstall.AutoSize = true;
            chkBoxTunstall.Location = new Point(135, 13);
            chkBoxTunstall.Name = "chkBoxTunstall";
            chkBoxTunstall.Size = new Size(98, 29);
            chkBoxTunstall.TabIndex = 194;
            chkBoxTunstall.Text = "Tunstall";
            chkBoxTunstall.UseVisualStyleBackColor = true;
            // 
            // chkBoxHanley
            // 
            chkBoxHanley.AutoSize = true;
            chkBoxHanley.Location = new Point(248, 13);
            chkBoxHanley.Name = "chkBoxHanley";
            chkBoxHanley.Size = new Size(92, 29);
            chkBoxHanley.TabIndex = 195;
            chkBoxHanley.Text = "Hanley";
            chkBoxHanley.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(1146, 193);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(40, 40);
            btnReset.SizeMode = PictureBoxSizeMode.Zoom;
            btnReset.TabIndex = 190;
            btnReset.TabStop = false;
            btnReset.Click += btnReset_Click;
            // 
            // ImgSave
            // 
            ImgSave.Image = (Image)resources.GetObject("ImgSave.Image");
            ImgSave.Location = new Point(1099, 193);
            ImgSave.Name = "ImgSave";
            ImgSave.Size = new Size(40, 40);
            ImgSave.SizeMode = PictureBoxSizeMode.Zoom;
            ImgSave.TabIndex = 189;
            ImgSave.TabStop = false;
            ImgSave.Click += ImgSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(740, 89);
            label5.Name = "label5";
            label5.Size = new Size(180, 25);
            label5.TabIndex = 187;
            label5.Text = "Minimum Stock Level";
            // 
            // txtMinStockLevel
            // 
            txtMinStockLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMinStockLevel.Location = new Point(735, 113);
            txtMinStockLevel.Name = "txtMinStockLevel";
            txtMinStockLevel.Size = new Size(191, 39);
            txtMinStockLevel.TabIndex = 188;
            txtMinStockLevel.Text = "0";
            txtMinStockLevel.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(949, 89);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 185;
            label4.Text = "Reorder Quantity";
            // 
            // txtReorderQty
            // 
            txtReorderQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtReorderQty.Location = new Point(944, 113);
            txtReorderQty.Name = "txtReorderQty";
            txtReorderQty.Size = new Size(191, 39);
            txtReorderQty.TabIndex = 186;
            txtReorderQty.Text = "0";
            txtReorderQty.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(241, 90);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 183;
            label3.Text = "Unit Cost";
            // 
            // txtUnitCost
            // 
            txtUnitCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitCost.Location = new Point(237, 114);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.Size = new Size(191, 39);
            txtUnitCost.TabIndex = 184;
            txtUnitCost.Text = "0.00";
            txtUnitCost.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(452, 94);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 181;
            label2.Text = "Expiry Date";
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpExpiryDate.Format = DateTimePickerFormat.Short;
            dtpExpiryDate.Location = new Point(447, 118);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(277, 34);
            dtpExpiryDate.TabIndex = 182;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 89);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 179;
            label1.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(16, 113);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(191, 39);
            txtQuantity.TabIndex = 180;
            txtQuantity.Text = "0";
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(12, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 10);
            panel1.TabIndex = 178;
            // 
            // dataGridDrugs
            // 
            dataGridDrugs.AllowUserToAddRows = false;
            dataGridDrugs.AllowUserToDeleteRows = false;
            dataGridDrugs.AllowUserToResizeColumns = false;
            dataGridDrugs.AllowUserToResizeRows = false;
            dataGridDrugs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDrugs.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridDrugs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridDrugs.ColumnHeadersHeight = 40;
            dataGridDrugs.Columns.AddRange(new DataGridViewColumn[] { DrugName, Quantity, ExpiryDate, Delete });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridDrugs.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridDrugs.EnableHeadersVisualStyles = false;
            dataGridDrugs.Location = new Point(12, 255);
            dataGridDrugs.MultiSelect = false;
            dataGridDrugs.Name = "dataGridDrugs";
            dataGridDrugs.ReadOnly = true;
            dataGridDrugs.RowHeadersVisible = false;
            dataGridDrugs.RowHeadersWidth = 30;
            dataGridDrugs.RowTemplate.DividerHeight = 2;
            dataGridDrugs.RowTemplate.Height = 34;
            dataGridDrugs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDrugs.Size = new Size(1184, 384);
            dataGridDrugs.TabIndex = 177;
            dataGridDrugs.CellClick += dataGridDrugs_CellClick;
            // 
            // DrugName
            // 
            DrugName.DataPropertyName = "Name";
            DrugName.FillWeight = 125.757576F;
            DrugName.HeaderText = "Drug Name";
            DrugName.MinimumWidth = 8;
            DrugName.Name = "DrugName";
            DrugName.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.FillWeight = 125.757576F;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            ExpiryDate.DataPropertyName = "Expiry";
            ExpiryDate.FillWeight = 125.757576F;
            ExpiryDate.HeaderText = "Expiry Date";
            ExpiryDate.MinimumWidth = 8;
            ExpiryDate.Name = "ExpiryDate";
            ExpiryDate.ReadOnly = true;
            // 
            // Delete
            // 
            Delete.FillWeight = 22.727272F;
            Delete.HeaderText = "Delete";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.False;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstname.Location = new Point(23, 13);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(149, 25);
            lblFirstname.TabIndex = 175;
            lblFirstname.Text = "Enter Drug Name";
            // 
            // txtDrugName
            // 
            txtDrugName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDrugName.Location = new Point(16, 37);
            txtDrugName.Name = "txtDrugName";
            txtDrugName.Size = new Size(582, 39);
            txtDrugName.TabIndex = 176;
            // 
            // panelControl
            // 
            panelControl.BackColor = Color.Transparent;
            panelControl.BorderStyle = BorderStyle.FixedSingle;
            panelControl.Controls.Add(btnGetFile);
            panelControl.Controls.Add(panel2);
            panelControl.Controls.Add(panelOption);
            panelControl.Dock = DockStyle.Top;
            panelControl.Location = new Point(0, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1246, 73);
            panelControl.TabIndex = 0;
            // 
            // btnGetFile
            // 
            btnGetFile.BackColor = Color.White;
            btnGetFile.FlatStyle = FlatStyle.Flat;
            btnGetFile.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetFile.ForeColor = Color.SteelBlue;
            btnGetFile.Location = new Point(337, 12);
            btnGetFile.Name = "btnGetFile";
            btnGetFile.Size = new Size(169, 43);
            btnGetFile.TabIndex = 173;
            btnGetFile.Text = "Select File";
            btnGetFile.UseVisualStyleBackColor = false;
            btnGetFile.Click += btnGetFile_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(1244, 6);
            panel2.TabIndex = 175;
            // 
            // panelOption
            // 
            panelOption.BackColor = Color.WhiteSmoke;
            panelOption.Controls.Add(rdBtnBulkEntry);
            panelOption.Controls.Add(rdBtnSingleEntry);
            panelOption.Location = new Point(24, 6);
            panelOption.Name = "panelOption";
            panelOption.Size = new Size(291, 53);
            panelOption.TabIndex = 174;
            // 
            // rdBtnBulkEntry
            // 
            rdBtnBulkEntry.AutoSize = true;
            rdBtnBulkEntry.Location = new Point(161, 11);
            rdBtnBulkEntry.Name = "rdBtnBulkEntry";
            rdBtnBulkEntry.Size = new Size(115, 29);
            rdBtnBulkEntry.TabIndex = 1;
            rdBtnBulkEntry.TabStop = true;
            rdBtnBulkEntry.Text = "Bulk Entry";
            rdBtnBulkEntry.UseVisualStyleBackColor = true;
            rdBtnBulkEntry.CheckedChanged += rdBtnBulkEntry_CheckedChanged;
            // 
            // rdBtnSingleEntry
            // 
            rdBtnSingleEntry.AutoSize = true;
            rdBtnSingleEntry.Location = new Point(14, 11);
            rdBtnSingleEntry.Name = "rdBtnSingleEntry";
            rdBtnSingleEntry.Size = new Size(130, 29);
            rdBtnSingleEntry.TabIndex = 0;
            rdBtnSingleEntry.TabStop = true;
            rdBtnSingleEntry.Text = "Single Entry";
            rdBtnSingleEntry.UseVisualStyleBackColor = true;
            rdBtnSingleEntry.CheckedChanged += rdBtnSingleEntry_CheckedChanged;
            // 
            // StockManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1246, 774);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockManagementForm";
            Load += StockManagementForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelBulkEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDrugsBulkEntry).EndInit();
            panelSingleEntry.ResumeLayout(false);
            panelSingleEntry.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDrugs).EndInit();
            panelControl.ResumeLayout(false);
            panelOption.ResumeLayout(false);
            panelOption.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbltitle;
        private DataGridViewImageColumn Column1;
        private Panel panelHeader;
        private Button btnClose;
        private Panel panelContent;
        private Panel panelSingleEntry;
        private PictureBox btnReset;
        private PictureBox ImgSave;
        private Label label5;
        private TextBox txtMinStockLevel;
        private Label label4;
        private TextBox txtReorderQty;
        private Label label3;
        private TextBox txtUnitCost;
        private Label label2;
        private DateTimePicker dtpExpiryDate;
        private Label label1;
        private TextBox txtQuantity;
        private Panel panel1;
        private DataGridView dataGridDrugs;
        private DataGridViewTextBoxColumn DrugName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ExpiryDate;
        private DataGridViewImageColumn Delete;
        private Label lblFirstname;
        private TextBox txtDrugName;
        private Panel panelControl;
        private Panel panelOption;
        private RadioButton rdBtnBulkEntry;
        private RadioButton rdBtnSingleEntry;
        private Panel panel2;
        private Panel panelBulkEntry;
        private Button btnGetFile;
        private DataGridView dataGridDrugsBulkEntry;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private CheckBox chkBoxLongton;
        private CheckBox chkBoxFenton;
        private CheckBox chkBoxHanley;
        private CheckBox chkBoxTunstall;
        private CheckBox chkBoxStoke;
        private Panel panel3;
        private Label label6;
        private CheckBox chkBoxCheckId;
        private Label label7;
        private TextBox txtCondition;
    }
}