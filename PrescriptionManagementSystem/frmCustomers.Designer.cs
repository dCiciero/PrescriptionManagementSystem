namespace PrescriptionManagementSystem
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblFirstname = new Label();
            txtFirstName = new TextBox();
            txtSurname = new TextBox();
            label1 = new Label();
            txtOtherName = new TextBox();
            label2 = new Label();
            lblHouseNo = new Label();
            label4 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            ImgSave = new PictureBox();
            label5 = new Label();
            txtPhone = new TextBox();
            dataGridCustomer = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
            txtPostCode = new TextBox();
            txtStreet = new TextBox();
            txtHouseNo = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtCIty = new TextBox();
            label9 = new Label();
            txtCounty = new TextBox();
            rdBtnYes = new RadioButton();
            groupBox1 = new GroupBox();
            rdBtnNo = new RadioButton();
            btnReset = new PictureBox();
            comboBox1 = new ComboBox();
            label10 = new Label();
            btnClose = new Button();
            panel3 = new Panel();
            lbltitle = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ImgSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReset).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstname.Location = new Point(48, 52);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(89, 25);
            lblFirstname.TabIndex = 0;
            lblFirstname.Text = "Firstname";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(28, 71);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(850, 39);
            txtFirstName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSurname.Location = new Point(28, 128);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(850, 39);
            txtSurname.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(965, 53);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "Othername";
            // 
            // txtOtherName
            // 
            txtOtherName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOtherName.Location = new Point(945, 71);
            txtOtherName.Name = "txtOtherName";
            txtOtherName.Size = new Size(850, 39);
            txtOtherName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 113);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 4;
            label2.Text = "Surname";
            // 
            // lblHouseNo
            // 
            lblHouseNo.AutoSize = true;
            lblHouseNo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblHouseNo.Location = new Point(960, 111);
            lblHouseNo.Name = "lblHouseNo";
            lblHouseNo.Size = new Size(92, 25);
            lblHouseNo.TabIndex = 6;
            lblHouseNo.Text = "House No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(963, 170);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 9;
            label4.Text = "Date of Birth";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(946, 191);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(420, 34);
            dtpDateOfBirth.TabIndex = 10;
            // 
            // ImgSave
            // 
            ImgSave.Image = (Image)resources.GetObject("ImgSave.Image");
            ImgSave.Location = new Point(1709, 328);
            ImgSave.Name = "ImgSave";
            ImgSave.Size = new Size(40, 45);
            ImgSave.SizeMode = PictureBoxSizeMode.Zoom;
            ImgSave.TabIndex = 14;
            ImgSave.TabStop = false;
            ImgSave.Click += ImgSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1395, 234);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 16;
            label5.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(1375, 249);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(420, 39);
            txtPhone.TabIndex = 15;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridCustomer.ColumnHeadersHeight = 40;
            dataGridCustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column14, Id, Delete });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridCustomer.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridCustomer.EnableHeadersVisualStyles = false;
            dataGridCustomer.Location = new Point(23, 405);
            dataGridCustomer.MultiSelect = false;
            dataGridCustomer.Name = "dataGridCustomer";
            dataGridCustomer.ReadOnly = true;
            dataGridCustomer.RowHeadersVisible = false;
            dataGridCustomer.RowHeadersWidth = 30;
            dataGridCustomer.RowTemplate.DividerHeight = 2;
            dataGridCustomer.RowTemplate.Height = 34;
            dataGridCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCustomer.Size = new Size(1776, 368);
            dataGridCustomer.TabIndex = 17;
            dataGridCustomer.CellContentClick += dataGridCustomer_CellContentClick;
            dataGridCustomer.CellContentDoubleClick += dataGridCustomer_CellContentDoubleClick;
            dataGridCustomer.DataBindingComplete += dataGridCustomer_DataBindingComplete;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "FirstName";
            Column1.FillWeight = 104.132233F;
            Column1.HeaderText = "First Name";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "OtherName";
            Column2.FillWeight = 104.132233F;
            Column2.HeaderText = "Middle Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "LastName";
            Column3.FillWeight = 104.132233F;
            Column3.HeaderText = "Last Name";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "DateOfBirth";
            Column4.FillWeight = 104.132233F;
            Column4.HeaderText = "Date of Birth";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "HouseNo";
            Column5.FillWeight = 104.132233F;
            Column5.HeaderText = "House No";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "StreetName";
            Column6.FillWeight = 104.132233F;
            Column6.HeaderText = "Street Name";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "PostCode";
            Column7.FillWeight = 104.132233F;
            Column7.HeaderText = "Post Code";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "City";
            Column8.FillWeight = 104.132233F;
            Column8.HeaderText = "City";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "County";
            Column9.FillWeight = 104.132233F;
            Column9.HeaderText = "County";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "Country";
            Column10.FillWeight = 104.132233F;
            Column10.HeaderText = "Country";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.DataPropertyName = "Vulnerable";
            Column14.FillWeight = 104.132233F;
            Column14.HeaderText = "Vulnerable";
            Column14.MinimumWidth = 8;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Delete
            // 
            Delete.FillWeight = 54.54545F;
            Delete.HeaderText = "Delete";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(26, 386);
            panel1.Name = "panel1";
            panel1.Size = new Size(1774, 10);
            panel1.TabIndex = 18;
            // 
            // txtPostCode
            // 
            txtPostCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPostCode.Location = new Point(28, 249);
            txtPostCode.Name = "txtPostCode";
            txtPostCode.Size = new Size(420, 39);
            txtPostCode.TabIndex = 19;
            // 
            // txtStreet
            // 
            txtStreet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStreet.Location = new Point(28, 186);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(850, 39);
            txtStreet.TabIndex = 20;
            // 
            // txtHouseNo
            // 
            txtHouseNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHouseNo.Location = new Point(946, 128);
            txtHouseNo.Name = "txtHouseNo";
            txtHouseNo.Size = new Size(420, 39);
            txtHouseNo.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(45, 234);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 22;
            label6.Text = "Post Code";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(48, 172);
            label7.Name = "label7";
            label7.Size = new Size(57, 25);
            label7.TabIndex = 23;
            label7.Text = "Street";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(475, 234);
            label8.Name = "label8";
            label8.Size = new Size(42, 25);
            label8.TabIndex = 25;
            label8.Text = "City";
            // 
            // txtCIty
            // 
            txtCIty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCIty.Location = new Point(458, 249);
            txtCIty.Name = "txtCIty";
            txtCIty.Size = new Size(420, 39);
            txtCIty.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(970, 235);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 27;
            label9.Text = "County";
            // 
            // txtCounty
            // 
            txtCounty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCounty.Location = new Point(946, 250);
            txtCounty.Name = "txtCounty";
            txtCounty.Size = new Size(420, 39);
            txtCounty.TabIndex = 26;
            // 
            // rdBtnYes
            // 
            rdBtnYes.AutoSize = true;
            rdBtnYes.Location = new Point(58, 342);
            rdBtnYes.Name = "rdBtnYes";
            rdBtnYes.Size = new Size(62, 29);
            rdBtnYes.TabIndex = 28;
            rdBtnYes.TabStop = true;
            rdBtnYes.Text = "Yes";
            rdBtnYes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(28, 314);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(197, 66);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vulnerable";
            // 
            // rdBtnNo
            // 
            rdBtnNo.AutoSize = true;
            rdBtnNo.Location = new Point(126, 343);
            rdBtnNo.Name = "rdBtnNo";
            rdBtnNo.Size = new Size(61, 29);
            rdBtnNo.TabIndex = 29;
            rdBtnNo.TabStop = true;
            rdBtnNo.Text = "No";
            rdBtnNo.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(1755, 328);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(40, 45);
            btnReset.SizeMode = PictureBoxSizeMode.Zoom;
            btnReset.TabIndex = 30;
            btnReset.TabStop = false;
            btnReset.Click += btnReset_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(1375, 191);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(420, 38);
            comboBox1.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(1380, 172);
            label10.Name = "label10";
            label10.Size = new Size(69, 25);
            label10.TabIndex = 32;
            label10.Text = "Gender";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1798, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 55);
            btnClose.TabIndex = 145;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(lbltitle);
            panel3.Controls.Add(btnClose);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1845, 55);
            panel3.TabIndex = 34;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.SteelBlue;
            lbltitle.Location = new Point(567, 7);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(710, 38);
            lbltitle.TabIndex = 146;
            lbltitle.Text = "Prescription Management System - Create Customer";
            lbltitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(1389, 111);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 35;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(1375, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(420, 39);
            txtEmail.TabIndex = 36;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1846, 785);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(panel3);
            Controls.Add(rdBtnNo);
            Controls.Add(label10);
            Controls.Add(rdBtnYes);
            Controls.Add(comboBox1);
            Controls.Add(btnReset);
            Controls.Add(label9);
            Controls.Add(txtCounty);
            Controls.Add(label8);
            Controls.Add(txtCIty);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtStreet);
            Controls.Add(txtPostCode);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(ImgSave);
            Controls.Add(label4);
            Controls.Add(lblHouseNo);
            Controls.Add(label2);
            Controls.Add(txtSurname);
            Controls.Add(label1);
            Controls.Add(lblFirstname);
            Controls.Add(txtOtherName);
            Controls.Add(txtFirstName);
            Controls.Add(txtHouseNo);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(groupBox1);
            Controls.Add(dataGridCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomers";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomers";
            Load += frmCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)ImgSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReset).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstname;
        private TextBox txtFirstName;
        private TextBox txtSurname;
        private Label label1;
        private TextBox txtOtherName;
        private Label label2;
        private Label lblHouseNo;
        private Label label4;
        private DateTimePicker dtpDateOfBirth;
        private PictureBox ImgSave;
        private Label label5;
        private TextBox txtPhone;
        private DataGridView dataGridCustomer;
        private Panel panel1;
        private TextBox txtPostCode;
        private TextBox txtStreet;
        private TextBox txtHouseNo;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtCIty;
        private Label label9;
        private TextBox txtCounty;
        private DataGridViewTextBoxColumn Customer_Name;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn street;
        private DataGridViewTextBoxColumn PostCode;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Edit;
        private RadioButton rdBtnYes;
        private GroupBox groupBox1;
        private RadioButton rdBtnNo;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Surname;
        private PictureBox btnReset;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewImageColumn Delete;
        private ComboBox comboBox1;
        private Label label10;
        private Button btnClose;
        private Panel panel3;
        private Label lbltitle;
        private Label lblEmail;
        private TextBox txtEmail;
    }
}