namespace PrescriptionManagementSystem
{
    partial class CreateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserForm));
            panel1 = new Panel();
            lbltitle = new Label();
            btnClose = new Button();
            panel2 = new Panel();
            label2 = new Label();
            cmbBoxStores = new ComboBox();
            panel3 = new Panel();
            dataGridEmployee = new DataGridView();
            firstName = new DataGridViewTextBoxColumn();
            midName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            dob = new DataGridViewTextBoxColumn();
            employedDate = new DataGridViewTextBoxColumn();
            houseNo = new DataGridViewTextBoxColumn();
            street = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            postCode = new DataGridViewTextBoxColumn();
            county = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            isAdmin = new DataGridViewTextBoxColumn();
            country = new DataGridViewTextBoxColumn();
            terminateDate = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            StoreId = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            chkTerminateUser = new CheckBox();
            btnReset = new PictureBox();
            ImgSave = new PictureBox();
            lblTerminateDate = new Label();
            dtpTermDate = new DateTimePicker();
            lblCountry = new Label();
            txtCountry = new TextBox();
            label4 = new Label();
            dtpEmpDate = new DateTimePicker();
            grbIsAdmin = new GroupBox();
            rdBtnIsAdminTrue = new RadioButton();
            rdBtnIsAdminFalse = new RadioButton();
            label3 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            rdBtnMale = new RadioButton();
            grbGender = new GroupBox();
            rdBtnFemale = new RadioButton();
            label14 = new Label();
            txtCounty = new TextBox();
            label15 = new Label();
            txtCity = new TextBox();
            label16 = new Label();
            txtPhone = new TextBox();
            label10 = new Label();
            txtPostCode = new TextBox();
            label13 = new Label();
            label11 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            txtStreet = new TextBox();
            label8 = new Label();
            txtHouseNo = new TextBox();
            label9 = new Label();
            txtLastName = new TextBox();
            label7 = new Label();
            txtMidName = new TextBox();
            lblFirstname = new Label();
            txtFirstName = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgSave).BeginInit();
            grbIsAdmin.SuspendLayout();
            grbGender.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(lbltitle);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 55);
            panel1.TabIndex = 0;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.SteelBlue;
            lbltitle.Location = new Point(320, 8);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(642, 38);
            lbltitle.TabIndex = 146;
            lbltitle.Text = "Prescription Management System - Create User";
            lbltitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1303, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 55);
            btnClose.TabIndex = 145;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmbBoxStores);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dataGridEmployee);
            panel2.Controls.Add(chkTerminateUser);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(ImgSave);
            panel2.Controls.Add(lblTerminateDate);
            panel2.Controls.Add(dtpTermDate);
            panel2.Controls.Add(lblCountry);
            panel2.Controls.Add(txtCountry);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dtpEmpDate);
            panel2.Controls.Add(grbIsAdmin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(rdBtnMale);
            panel2.Controls.Add(grbGender);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(txtCounty);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtCity);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtPostCode);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dtpDateOfBirth);
            panel2.Controls.Add(txtStreet);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtHouseNo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtMidName);
            panel2.Controls.Add(lblFirstname);
            panel2.Controls.Add(txtFirstName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(1350, 822);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(476, 390);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 143;
            label2.Text = "Store Assigned";
            // 
            // cmbBoxStores
            // 
            cmbBoxStores.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxStores.FormattingEnabled = true;
            cmbBoxStores.Location = new Point(456, 407);
            cmbBoxStores.Name = "cmbBoxStores";
            cmbBoxStores.Size = new Size(434, 36);
            cmbBoxStores.TabIndex = 144;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Location = new Point(8, 497);
            panel3.Name = "panel3";
            panel3.Size = new Size(1321, 10);
            panel3.TabIndex = 140;
            // 
            // dataGridEmployee
            // 
            dataGridEmployee.AllowUserToAddRows = false;
            dataGridEmployee.AllowUserToDeleteRows = false;
            dataGridEmployee.AllowUserToResizeColumns = false;
            dataGridEmployee.AllowUserToResizeRows = false;
            dataGridEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridEmployee.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridEmployee.ColumnHeadersHeight = 40;
            dataGridEmployee.Columns.AddRange(new DataGridViewColumn[] { firstName, midName, lastName, phone, dob, employedDate, houseNo, street, city, postCode, county, Gender, email, isAdmin, country, terminateDate, Id, StoreId, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridEmployee.EnableHeadersVisualStyles = false;
            dataGridEmployee.Location = new Point(5, 516);
            dataGridEmployee.MultiSelect = false;
            dataGridEmployee.Name = "dataGridEmployee";
            dataGridEmployee.ReadOnly = true;
            dataGridEmployee.RowHeadersVisible = false;
            dataGridEmployee.RowHeadersWidth = 30;
            dataGridEmployee.RowTemplate.DividerHeight = 2;
            dataGridEmployee.RowTemplate.Height = 34;
            dataGridEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEmployee.Size = new Size(1324, 299);
            dataGridEmployee.TabIndex = 139;
            dataGridEmployee.CellContentClick += dataGridEmployee_CellContentClick;
            dataGridEmployee.CellDoubleClick += dataGridEmployee_CellDoubleClick;
            // 
            // firstName
            // 
            firstName.DataPropertyName = "FirstName";
            firstName.FillWeight = 104.132233F;
            firstName.HeaderText = "First Name";
            firstName.MinimumWidth = 8;
            firstName.Name = "firstName";
            firstName.ReadOnly = true;
            // 
            // midName
            // 
            midName.DataPropertyName = "MiddleName";
            midName.FillWeight = 104.132233F;
            midName.HeaderText = "Middle Name";
            midName.MinimumWidth = 8;
            midName.Name = "midName";
            midName.ReadOnly = true;
            // 
            // lastName
            // 
            lastName.DataPropertyName = "LastName";
            lastName.FillWeight = 104.132233F;
            lastName.HeaderText = "Last Name";
            lastName.MinimumWidth = 8;
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            // 
            // phone
            // 
            phone.DataPropertyName = "Phone";
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 8;
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Visible = false;
            // 
            // dob
            // 
            dob.DataPropertyName = "BirthDate";
            dob.FillWeight = 104.132233F;
            dob.HeaderText = "Date of Birth";
            dob.MinimumWidth = 8;
            dob.Name = "dob";
            dob.ReadOnly = true;
            // 
            // employedDate
            // 
            employedDate.DataPropertyName = "DateEmployed";
            employedDate.HeaderText = "Employed Date";
            employedDate.MinimumWidth = 8;
            employedDate.Name = "employedDate";
            employedDate.ReadOnly = true;
            employedDate.Visible = false;
            // 
            // houseNo
            // 
            houseNo.DataPropertyName = "HouseNo";
            houseNo.HeaderText = "HouseNo";
            houseNo.MinimumWidth = 8;
            houseNo.Name = "houseNo";
            houseNo.ReadOnly = true;
            houseNo.Visible = false;
            // 
            // street
            // 
            street.DataPropertyName = "StreetName";
            street.HeaderText = "Street";
            street.MinimumWidth = 8;
            street.Name = "street";
            street.ReadOnly = true;
            street.Visible = false;
            // 
            // city
            // 
            city.DataPropertyName = "City";
            city.HeaderText = "City";
            city.MinimumWidth = 8;
            city.Name = "city";
            city.ReadOnly = true;
            city.Visible = false;
            // 
            // postCode
            // 
            postCode.DataPropertyName = "PostCode";
            postCode.HeaderText = "Post Code";
            postCode.MinimumWidth = 8;
            postCode.Name = "postCode";
            postCode.ReadOnly = true;
            postCode.Visible = false;
            // 
            // county
            // 
            county.DataPropertyName = "County";
            county.HeaderText = "County";
            county.MinimumWidth = 8;
            county.Name = "county";
            county.ReadOnly = true;
            county.Visible = false;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Visible = false;
            // 
            // email
            // 
            email.DataPropertyName = "Email";
            email.HeaderText = "Email";
            email.MinimumWidth = 8;
            email.Name = "email";
            email.ReadOnly = true;
            email.Visible = false;
            // 
            // isAdmin
            // 
            isAdmin.DataPropertyName = "IsAdmin";
            isAdmin.HeaderText = "Is Admin?";
            isAdmin.MinimumWidth = 8;
            isAdmin.Name = "isAdmin";
            isAdmin.ReadOnly = true;
            isAdmin.Visible = false;
            // 
            // country
            // 
            country.DataPropertyName = "Country";
            country.HeaderText = "Country";
            country.MinimumWidth = 8;
            country.Name = "country";
            country.ReadOnly = true;
            country.Visible = false;
            // 
            // terminateDate
            // 
            terminateDate.DataPropertyName = "DateDisengaged";
            terminateDate.HeaderText = "Terminate Date";
            terminateDate.MinimumWidth = 8;
            terminateDate.Name = "terminateDate";
            terminateDate.ReadOnly = true;
            terminateDate.Visible = false;
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
            // StoreId
            // 
            StoreId.DataPropertyName = "StoreId";
            StoreId.HeaderText = "StoreId";
            StoreId.MinimumWidth = 8;
            StoreId.Name = "StoreId";
            StoreId.ReadOnly = true;
            StoreId.Visible = false;
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
            // chkTerminateUser
            // 
            chkTerminateUser.AutoSize = true;
            chkTerminateUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkTerminateUser.Location = new Point(991, 462);
            chkTerminateUser.Name = "chkTerminateUser";
            chkTerminateUser.Size = new Size(172, 29);
            chkTerminateUser.TabIndex = 138;
            chkTerminateUser.Text = "Terminate User?";
            chkTerminateUser.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(1289, 451);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(40, 40);
            btnReset.SizeMode = PictureBoxSizeMode.Zoom;
            btnReset.TabIndex = 137;
            btnReset.TabStop = false;
            btnReset.Click += btnReset_Click;
            // 
            // ImgSave
            // 
            ImgSave.Image = (Image)resources.GetObject("ImgSave.Image");
            ImgSave.Location = new Point(1243, 451);
            ImgSave.Name = "ImgSave";
            ImgSave.Size = new Size(40, 40);
            ImgSave.SizeMode = PictureBoxSizeMode.Zoom;
            ImgSave.TabIndex = 136;
            ImgSave.TabStop = false;
            ImgSave.Click += ImgSave_Click;
            // 
            // lblTerminateDate
            // 
            lblTerminateDate.AutoSize = true;
            lblTerminateDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTerminateDate.Location = new Point(935, 376);
            lblTerminateDate.Name = "lblTerminateDate";
            lblTerminateDate.Size = new Size(156, 25);
            lblTerminateDate.TabIndex = 133;
            lblTerminateDate.Text = "Termination Date";
            // 
            // dtpTermDate
            // 
            dtpTermDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTermDate.Format = DateTimePickerFormat.Short;
            dtpTermDate.Location = new Point(917, 394);
            dtpTermDate.Name = "dtpTermDate";
            dtpTermDate.Size = new Size(434, 39);
            dtpTermDate.TabIndex = 134;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountry.Location = new Point(25, 385);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(80, 25);
            lblCountry.TabIndex = 141;
            lblCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountry.Location = new Point(5, 401);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(434, 39);
            txtCountry.TabIndex = 142;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(918, 109);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 131;
            label4.Text = "Employment Date";
            // 
            // dtpEmpDate
            // 
            dtpEmpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEmpDate.Format = DateTimePickerFormat.Short;
            dtpEmpDate.Location = new Point(900, 127);
            dtpEmpDate.Name = "dtpEmpDate";
            dtpEmpDate.Size = new Size(434, 39);
            dtpEmpDate.TabIndex = 132;
            // 
            // grbIsAdmin
            // 
            grbIsAdmin.Controls.Add(rdBtnIsAdminTrue);
            grbIsAdmin.Controls.Add(rdBtnIsAdminFalse);
            grbIsAdmin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbIsAdmin.Location = new Point(905, 321);
            grbIsAdmin.Name = "grbIsAdmin";
            grbIsAdmin.Size = new Size(433, 50);
            grbIsAdmin.TabIndex = 130;
            grbIsAdmin.TabStop = false;
            grbIsAdmin.Text = "Is Admin";
            // 
            // rdBtnIsAdminTrue
            // 
            rdBtnIsAdminTrue.AutoSize = true;
            rdBtnIsAdminTrue.Location = new Point(107, 17);
            rdBtnIsAdminTrue.Name = "rdBtnIsAdminTrue";
            rdBtnIsAdminTrue.Size = new Size(74, 29);
            rdBtnIsAdminTrue.TabIndex = 87;
            rdBtnIsAdminTrue.TabStop = true;
            rdBtnIsAdminTrue.Text = "True";
            rdBtnIsAdminTrue.UseVisualStyleBackColor = true;
            // 
            // rdBtnIsAdminFalse
            // 
            rdBtnIsAdminFalse.AutoSize = true;
            rdBtnIsAdminFalse.Location = new Point(196, 17);
            rdBtnIsAdminFalse.Name = "rdBtnIsAdminFalse";
            rdBtnIsAdminFalse.Size = new Size(77, 29);
            rdBtnIsAdminFalse.TabIndex = 79;
            rdBtnIsAdminFalse.TabStop = true;
            rdBtnIsAdminFalse.Text = "False";
            rdBtnIsAdminFalse.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 315);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 128;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(5, 331);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(434, 39);
            txtEmail.TabIndex = 129;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(476, 315);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 126;
            label1.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(456, 331);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(434, 39);
            txtPassword.TabIndex = 127;
            // 
            // rdBtnMale
            // 
            rdBtnMale.AutoSize = true;
            rdBtnMale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdBtnMale.Location = new Point(1006, 256);
            rdBtnMale.Name = "rdBtnMale";
            rdBtnMale.Size = new Size(78, 29);
            rdBtnMale.TabIndex = 124;
            rdBtnMale.TabStop = true;
            rdBtnMale.Text = "Male";
            rdBtnMale.UseVisualStyleBackColor = true;
            // 
            // grbGender
            // 
            grbGender.Controls.Add(rdBtnFemale);
            grbGender.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbGender.Location = new Point(896, 241);
            grbGender.Name = "grbGender";
            grbGender.Size = new Size(433, 50);
            grbGender.TabIndex = 125;
            grbGender.TabStop = false;
            grbGender.Text = "Gender";
            // 
            // rdBtnFemale
            // 
            rdBtnFemale.AutoSize = true;
            rdBtnFemale.Location = new Point(205, 17);
            rdBtnFemale.Name = "rdBtnFemale";
            rdBtnFemale.Size = new Size(96, 29);
            rdBtnFemale.TabIndex = 79;
            rdBtnFemale.TabStop = true;
            rdBtnFemale.Text = "Female";
            rdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(476, 241);
            label14.Name = "label14";
            label14.Size = new Size(72, 25);
            label14.TabIndex = 123;
            label14.Text = "County";
            // 
            // txtCounty
            // 
            txtCounty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCounty.Location = new Point(456, 256);
            txtCounty.Name = "txtCounty";
            txtCounty.Size = new Size(434, 39);
            txtCounty.TabIndex = 122;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(917, 177);
            label15.Name = "label15";
            label15.Size = new Size(44, 25);
            label15.TabIndex = 121;
            label15.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(900, 192);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(434, 39);
            txtCity.TabIndex = 120;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(25, 114);
            label16.Name = "label16";
            label16.Size = new Size(65, 25);
            label16.TabIndex = 119;
            label16.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(5, 129);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(434, 39);
            txtPhone.TabIndex = 118;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(25, 240);
            label10.Name = "label10";
            label10.Size = new Size(96, 25);
            label10.TabIndex = 116;
            label10.Text = "Post Code";
            // 
            // txtPostCode
            // 
            txtPostCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPostCode.Location = new Point(5, 256);
            txtPostCode.Name = "txtPostCode";
            txtPostCode.Size = new Size(434, 39);
            txtPostCode.TabIndex = 117;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(476, 109);
            label13.Name = "label13";
            label13.Size = new Size(119, 25);
            label13.TabIndex = 104;
            label13.Text = "Date of Birth";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(476, 176);
            label11.Name = "label11";
            label11.Size = new Size(62, 25);
            label11.TabIndex = 114;
            label11.Text = "Street";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(456, 127);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(434, 39);
            dtpDateOfBirth.TabIndex = 105;
            // 
            // txtStreet
            // 
            txtStreet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStreet.Location = new Point(456, 192);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(434, 39);
            txtStreet.TabIndex = 115;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(25, 176);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 112;
            label8.Text = "House No";
            // 
            // txtHouseNo
            // 
            txtHouseNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHouseNo.Location = new Point(5, 192);
            txtHouseNo.Name = "txtHouseNo";
            txtHouseNo.Size = new Size(434, 39);
            txtHouseNo.TabIndex = 113;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(920, 46);
            label9.Name = "label9";
            label9.Size = new Size(99, 25);
            label9.TabIndex = 110;
            label9.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(900, 62);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(434, 39);
            txtLastName.TabIndex = 111;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(476, 46);
            label7.Name = "label7";
            label7.Size = new Size(125, 25);
            label7.TabIndex = 108;
            label7.Text = "Middle Name";
            // 
            // txtMidName
            // 
            txtMidName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMidName.Location = new Point(456, 62);
            txtMidName.Name = "txtMidName";
            txtMidName.Size = new Size(434, 39);
            txtMidName.TabIndex = 109;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstname.Location = new Point(25, 46);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(102, 25);
            lblFirstname.TabIndex = 106;
            lblFirstname.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(5, 62);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(434, 39);
            txtFirstName.TabIndex = 107;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 877);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateUserForm";
            Load += CreateUserForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgSave).EndInit();
            grbIsAdmin.ResumeLayout(false);
            grbIsAdmin.PerformLayout();
            grbGender.ResumeLayout(false);
            grbGender.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button btnClose;
        private ComboBox cmbBoxStores;
        private Panel panel3;
        private DataGridView dataGridEmployee;
        private CheckBox chkTerminateUser;
        private PictureBox btnReset;
        private PictureBox ImgSave;
        private Label lblTerminateDate;
        private DateTimePicker dtpTermDate;
        private Label label2;
        private Label lblCountry;
        private TextBox txtCountry;
        private Label label4;
        private DateTimePicker dtpEmpDate;
        private GroupBox grbIsAdmin;
        private RadioButton rdBtnIsAdminTrue;
        private RadioButton rdBtnIsAdminFalse;
        private Label label3;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtPassword;
        private RadioButton rdBtnMale;
        private GroupBox grbGender;
        private RadioButton rdBtnFemale;
        private Label label14;
        private TextBox txtCounty;
        private Label label15;
        private TextBox txtCity;
        private Label label16;
        private TextBox txtPhone;
        private Label label10;
        private TextBox txtPostCode;
        private Label label13;
        private Label label11;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtStreet;
        private Label label8;
        private TextBox txtHouseNo;
        private Label label9;
        private TextBox txtLastName;
        private Label label7;
        private TextBox txtMidName;
        private Label lblFirstname;
        private TextBox txtFirstName;
        private Label lbltitle;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn midName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn dob;
        private DataGridViewTextBoxColumn employedDate;
        private DataGridViewTextBoxColumn houseNo;
        private DataGridViewTextBoxColumn street;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn postCode;
        private DataGridViewTextBoxColumn county;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn isAdmin;
        private DataGridViewTextBoxColumn country;
        private DataGridViewTextBoxColumn terminateDate;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StoreId;
        private DataGridViewImageColumn Delete;
    }
}