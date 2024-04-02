namespace PrescriptionManagementSystem
{
    partial class EmployeeMgmtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMgmtForm));
            mainPanel = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            btnExit = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtFirstName = new TextBox();
            lblFirstname = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            textBox3 = new TextBox();
            label10 = new Label();
            textBox4 = new TextBox();
            label11 = new Label();
            textBox5 = new TextBox();
            label12 = new Label();
            comboBox1 = new ComboBox();
            label13 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label14 = new Label();
            txtCounty = new TextBox();
            label15 = new Label();
            txtCIty = new TextBox();
            label16 = new Label();
            txtPhone = new TextBox();
            rdBtnNo = new RadioButton();
            rdBtnYes = new RadioButton();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
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
            mainPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomer).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(tabControl1);
            mainPanel.Controls.Add(panel2);
            mainPanel.Controls.Add(panel3);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1373, 870);
            mainPanel.TabIndex = 7;
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
            panel2.Location = new Point(103, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1270, 67);
            panel2.TabIndex = 5;
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
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(103, 870);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(136, 126);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1150, 732);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dataGridCustomer);
            tabPage1.Controls.Add(rdBtnNo);
            tabPage1.Controls.Add(rdBtnYes);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(txtCounty);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(txtCIty);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(txtPhone);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(dtpDateOfBirth);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(lblFirstname);
            tabPage1.Controls.Add(txtFirstName);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1142, 694);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create/Modify";
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1189, 454);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Search";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(13, 28);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(434, 39);
            txtFirstName.TabIndex = 36;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstname.Location = new Point(33, 12);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(97, 25);
            lblFirstname.TabIndex = 35;
            lblFirstname.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(487, 12);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 37;
            label7.Text = "Middle Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(467, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(434, 39);
            textBox1.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(33, 211);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 41;
            label8.Text = "House No";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(13, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(434, 39);
            textBox2.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(33, 76);
            label9.Name = "label9";
            label9.Size = new Size(95, 25);
            label9.TabIndex = 39;
            label9.Text = "Last Name";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(13, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(434, 39);
            textBox3.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(33, 281);
            label10.Name = "label10";
            label10.Size = new Size(93, 25);
            label10.TabIndex = 45;
            label10.Text = "Post Code";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(13, 297);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(434, 39);
            textBox4.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(487, 211);
            label11.Name = "label11";
            label11.Size = new Size(57, 25);
            label11.TabIndex = 43;
            label11.Text = "Street";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(467, 227);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(434, 39);
            textBox5.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(472, 142);
            label12.Name = "label12";
            label12.Size = new Size(69, 25);
            label12.TabIndex = 36;
            label12.Text = "Gender";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(467, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(434, 38);
            comboBox1.TabIndex = 35;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(484, 69);
            label13.Name = "label13";
            label13.Size = new Size(112, 25);
            label13.TabIndex = 33;
            label13.Text = "Date of Birth";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(467, 90);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(434, 39);
            dtpDateOfBirth.TabIndex = 34;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(37, 349);
            label14.Name = "label14";
            label14.Size = new Size(69, 25);
            label14.TabIndex = 52;
            label14.Text = "County";
            // 
            // txtCounty
            // 
            txtCounty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCounty.Location = new Point(13, 364);
            txtCounty.Name = "txtCounty";
            txtCounty.Size = new Size(434, 39);
            txtCounty.TabIndex = 51;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(484, 282);
            label15.Name = "label15";
            label15.Size = new Size(42, 25);
            label15.TabIndex = 50;
            label15.Text = "City";
            // 
            // txtCIty
            // 
            txtCIty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCIty.Location = new Point(467, 297);
            txtCIty.Name = "txtCIty";
            txtCIty.Size = new Size(434, 39);
            txtCIty.TabIndex = 49;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(33, 146);
            label16.Name = "label16";
            label16.Size = new Size(62, 25);
            label16.TabIndex = 48;
            label16.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(13, 161);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(434, 39);
            txtPhone.TabIndex = 47;
            // 
            // rdBtnNo
            // 
            rdBtnNo.AutoSize = true;
            rdBtnNo.Location = new Point(566, 374);
            rdBtnNo.Name = "rdBtnNo";
            rdBtnNo.Size = new Size(61, 29);
            rdBtnNo.TabIndex = 54;
            rdBtnNo.TabStop = true;
            rdBtnNo.Text = "No";
            rdBtnNo.UseVisualStyleBackColor = true;
            // 
            // rdBtnYes
            // 
            rdBtnYes.AutoSize = true;
            rdBtnYes.Location = new Point(498, 373);
            rdBtnYes.Name = "rdBtnYes";
            rdBtnYes.Size = new Size(62, 29);
            rdBtnYes.TabIndex = 53;
            rdBtnYes.TabStop = true;
            rdBtnYes.Text = "Yes";
            rdBtnYes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(468, 345);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 66);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vulnerable";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(9, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(1123, 10);
            panel1.TabIndex = 57;
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
            dataGridCustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column14, Id, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridCustomer.EnableHeadersVisualStyles = false;
            dataGridCustomer.Location = new Point(11, 434);
            dataGridCustomer.MultiSelect = false;
            dataGridCustomer.Name = "dataGridCustomer";
            dataGridCustomer.ReadOnly = true;
            dataGridCustomer.RowHeadersVisible = false;
            dataGridCustomer.RowHeadersWidth = 30;
            dataGridCustomer.RowTemplate.DividerHeight = 2;
            dataGridCustomer.RowTemplate.Height = 34;
            dataGridCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCustomer.Size = new Size(1121, 247);
            dataGridCustomer.TabIndex = 56;
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
            // EmployeeMgmtForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1373, 870);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeMgmtForm";
            Text = "EmployeeMgmtForm";
            mainPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel panel3;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel5;
        private PictureBox btnExit;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label7;
        private TextBox textBox1;
        private Label lblFirstname;
        private TextBox txtFirstName;
        private Label label10;
        private TextBox textBox4;
        private Label label11;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox2;
        private Label label9;
        private TextBox textBox3;
        private Label label12;
        private ComboBox comboBox1;
        private Label label13;
        private DateTimePicker dtpDateOfBirth;
        private Label label14;
        private TextBox txtCounty;
        private Label label15;
        private TextBox txtCIty;
        private Label label16;
        private TextBox txtPhone;
        private RadioButton rdBtnNo;
        private RadioButton rdBtnYes;
        private GroupBox groupBox1;
        private Panel panel1;
        private DataGridView dataGridCustomer;
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
    }
}