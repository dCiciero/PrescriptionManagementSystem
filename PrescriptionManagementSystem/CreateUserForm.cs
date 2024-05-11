// ***********************************************************************
// Assembly         : PrescriptionManagementSystem
// Author           : ogaga.ivhurie
// Created          : 03-15-2024
//
// Last Modified By : ogaga.ivhurie
// Last Modified On : 05-11-2024
// ***********************************************************************
// <copyright file="CreateUserForm.cs" company="PrescriptionManagementSystem">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Domain;
using Domain.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using PrescriptionManagementSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrescriptionManagementSystem
{
    /// <summary>
    /// Class CreateUserForm.
    /// Implements the <see cref="Form" />
    /// </summary>
    /// <seealso cref="Form" />
    public partial class CreateUserForm : Form
    {
        /// <summary>
        /// The stores
        /// </summary>
        List<Store> stores = new List<Store>();
        /// <summary>
        /// The SQL connection
        /// </summary>
        SqlConnection sqlConn;
        /// <summary>
        /// The SQL command
        /// </summary>
        SqlCommand sqlCmd;
        /// <summary>
        /// The RDR
        /// </summary>
        SqlDataReader rdr;
        /// <summary>
        /// The edit record
        /// </summary>
        bool editRecord = false;
        /// <summary>
        /// The customer identifier
        /// </summary>
        int customerId = 0;
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserForm"/> class.
        /// </summary>
        public CreateUserForm()
        {
            InitializeComponent();
            sqlConn = AppConfig.sqlConn;
            cmbBoxStores.DataSource = AppConfig.bindingSource;
            cmbBoxStores.DisplayMember = "Name";
            cmbBoxStores.ValueMember = "Id";
            //ConnectDB();
            GetEmployees();
        }

        /// <summary>
        /// Gets the employees.
        /// </summary>
        private void GetEmployees()
        {

            //string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PharmaZeal; Integrated Security=True; ";
            DataSet custDs = new DataSet();
            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;


            try
            {
                //conn = new SqlConnection(connectionStr);
                //cmd = new SqlCommand("SELECT * FROM Customer");
                string sqlQuery = "SELECT * FROM UserAccount WHERE IsDeleted != @isDeleted or isDeleted IS NULL";

                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
                sqlConn.Open();

                sqlCmd = new SqlCommand(sqlQuery, sqlConn);
                sqlCmd.Parameters.AddWithValue("@isDeleted", true);
                dataTable = new DataTable("Customers");
                sqlDataAdapter = new SqlDataAdapter(sqlCmd); //(sqlQuery, sqlConn);
                sqlDataAdapter.Fill(dataTable);

                dataGridEmployee.AutoGenerateColumns = false;

                dataGridEmployee.DataSource = dataTable;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PharmaZeal");
            }
            finally
            {

                sqlConn?.Close();
            }
        }

        /// <summary>
        /// Handles the Click event of the ImgSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ImgSave_Click(object sender, EventArgs e)
        {
            /*if (IsFormValid())
            //{
            //    /*
            //    Location location = (Location)cmbBoxStores.SelectedItem;
            //    User usermodel = new User();
            //    usermodel.FirstName = txtFirstName.Text;
            //    usermodel.LastName = txtLastName.Text;
            //    usermodel.Email = txtEmail.Text;
            //    usermodel.NormalizedEmail = txtEmail.Text.ToUpper();
            //    usermodel.MidName = txtMidName.Text;
            //    usermodel.StreetName = txtStreet.Text;
            //    usermodel.City = txtCity.Text;
            //    usermodel.Country = txtCountry.Text;
            //    usermodel.Phone = txtPhone.Text;
            //    usermodel.Gender = rdBtnMale.Checked ? "Male" : "Female";
            //    usermodel.HouseNo = txtHouseNo.Text;
            //    usermodel.County = txtCounty.Text;
            //    usermodel.PostCode = txtPostCode.Text;
            //    usermodel.BirthDate = Convert.ToDateTime(dtpDateOfBirth.Text);
            //    usermodel.DateEmployed = Convert.ToDateTime(dtpEmpDate.Text);
            //    usermodel.DateDisengaged = Convert.ToDateTime(dtpTermDate.Text);
            //    usermodel.StoreId = location.Id;
            //    usermodel.IsAdmin = rdBtnIsAdminTrue.Checked ? true : false;
            //    var (saltKey, hashedPwd) = HashPassword(new byte[] { }, txtPassword.Text);
            //    usermodel.PasswordHash = hashedPwd;
            //    usermodel.SecurityStamp = Convert.ToBase64String(saltKey);

            //    GlobalConfig.Connection.CreateUser(usermodel);
            //    GetEmployees();

            //    ClearFields();
            //    
            //}
            //else
            */
            
            if (!IsFormValid())
            {
                MessageBox.Show("Enter all details", "PharmaZeal");
                return;
            }
            
            Store store = (Store)cmbBoxStores.SelectedItem;
            string firstName = txtFirstName.Text;
            string otherName = txtMidName.Text;
            string surname = txtLastName.Text;
            string houseNo = txtHouseNo.Text;
            string streetName = txtStreet.Text;
            string postCode = txtPostCode.Text;
            string city = txtCity.Text;
            string email = txtEmail.Text;
            string county = txtCounty.Text;
            string phone = txtPhone.Text;
            DateTime dob = Convert.ToDateTime(dtpDateOfBirth.Text);
            DateTime empDate = Convert.ToDateTime(dtpEmpDate.Text);
            DateTime termDate = Convert.ToDateTime(dtpTermDate.Text);
            string country = lblCountry.Text;
            string gender = rdBtnMale.Checked ? "Male" : "Female";
            int storeId = store.Id;
            bool isAdmin = rdBtnIsAdminTrue.Checked ? true : false;
            var (salt, hashedPswd) = HashPassword(new byte[] { }, txtPassword.Text);
            //string passworhHash = hashedPswd;


            try
            {
                sqlConn.Open();
                var QueryString = "";
                if (editRecord)
                {
                    if (MessageBox.Show("Proceed with modifying record", "PharmaZeal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        MessageBox.Show("Operation canceled", "PharmaZeal");
                        return;
                    }
                    //MessageBox.Show("Editing Record", "PharmaZeal");
                    QueryString = "UPDATE UserAccount " +
                                " SET FirstName = @FirstName, LastName=@LastName, MiddleName=@MiddleName, HouseNo=@HouseNo," +
                                " StreetName=@StreetName, PostCode=@PostCode, City=@City, County=@County, Country=@Country," +
                                " BirthDate=@DateOfBirth, StatusId=@StatusId, DateEmployed=@DateEmployed, DateDisengaged=@DateDisengaged, " +
                                " PasswordHash=@PasswordHash, Email=@Email, NormalizedEmail=@NormalizedEmail, IsAdmin=@IsAdmin, Gender=@Gender, " +
                                " Phone=@phone, SecurityStamp = @securityStamp, StoreId=@storeId WHERE Id=@Id";
                }
                else
                {
                    if (MessageBox.Show("Proceed with creating record", "PharmaZeal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        MessageBox.Show("Operation canceled", "PharmaZeal");
                        return;
                    }
                    //MessageBox.Show("Saving Record", "PharmaZeal");
                    QueryString = "INSERT INTO UserAccount " +
                                "(FirstName, LastName, MiddleName, HouseNo, StreetName, PostCode, City, County, Country,BirthDate," +
                                " StatusId, DateEmployed, DateDisengaged, PasswordHash, Email, NormalizedEmail, IsAdmin, Gender, Phone, " +
                                "SecurityStamp, StoreId)" +
                                "Values (@FirstName, @LastName, @MiddleName, @HouseNo, @StreetName, @PostCode, @City, @County, @Country, " +
                                "@DateOfBirth, @StatusId, @DateEmployed, @DateDisengaged, @PasswordHash, @Email, @NormalizedEmail, @IsAdmin, " +
                                "@Gender, @phone, @securityStamp, @storeId)";
                }


                using (var cmd = new SqlCommand(QueryString, sqlConn))
                {
                    if (editRecord)
                        cmd.Parameters.AddWithValue("@Id", customerId);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", surname);
                    cmd.Parameters.AddWithValue("@MiddleName", otherName);
                    cmd.Parameters.AddWithValue("@HouseNo", houseNo);
                    cmd.Parameters.AddWithValue("@StreetName", streetName);
                    cmd.Parameters.AddWithValue("@PostCode", postCode);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@County", county);
                    cmd.Parameters.AddWithValue("@Country", country);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@NormalizedEmail", email.ToUpper());
                    cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                    cmd.Parameters.AddWithValue("@StatusId", 1);
                    cmd.Parameters.AddWithValue("@DateEmployed", empDate);
                    cmd.Parameters.AddWithValue("@DateDisengaged", termDate);
                    cmd.Parameters.AddWithValue("@PasswordHash", hashedPswd);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@IsAdmin", isAdmin);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@securityStamp", Convert.ToBase64String(salt));
                    cmd.Parameters.AddWithValue("@storeId", storeId);


                    int successInsert = cmd.ExecuteNonQuery();
                    if (successInsert > 0)
                    {
                        if (editRecord)
                            MessageBox.Show("Update Successful", "PharmaZeal");
                        else
                            MessageBox.Show("Insert Successful", "PharmaZeal");

                        GetEmployees();

                        ClearFields();
                    }
                    else
                        MessageBox.Show("Insert Not Successful", "PharmaZeal");
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PharmaZeal");
            }
            finally
            {
                sqlConn.Close();
            }
        }

        /// <summary>
        /// Determines whether [is form valid].
        /// </summary>
        /// <returns><c>true</c> if [is form valid]; otherwise, <c>false</c>.</returns>
        private bool IsFormValid()
        {
            //TODO: Add form validation
            if (txtFirstName.Text.Length==0 || txtLastName.Text.Length==0 || 
                txtEmail.Text.Length==0 || txtPassword.Text.Length==0 || txtPhone.Text.Length==0
                 || txtPassword.Text.Length ==0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Handles the Load event of the CreateUserForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            if (this.editRecord == false)
            {
                HideTerminateDetails();
            }
        }

        /// <summary>
        /// Hides the terminate details.
        /// </summary>
        private void HideTerminateDetails()
        {
            chkTerminateUser.Visible = false;
            chkTerminateUser.Text = "";

            dtpTermDate.Visible = false;
            lblTerminateDate.Visible = false;
        }

        /// <summary>
        /// Shows the terminate details.
        /// </summary>
        private void ShowTerminateDetails()
        {
            lblTerminateDate.Visible = true;
            dtpTermDate.Visible = true;
            chkTerminateUser.Visible = true;
            chkTerminateUser.Text = "Terminate User?";
        }

        /// <summary>
        /// Hashes the password.
        /// </summary>
        /// <param name="salt">The salt.</param>
        /// <param name="password">The password.</param>
        /// <returns>System.ValueTuple&lt;System.Byte[], System.String&gt;.</returns>
        private static (byte[], string) HashPassword(byte[] salt, string password)
        {
            // generate a 128-bit salt using a cryptographically strong random sequence of nonzero values
            if (salt.Length == 0)
            {
                salt = new byte[128 / 8];
                using (var rngCsp = new RNGCryptoServiceProvider())
                {
                    rngCsp.GetNonZeroBytes(salt);
                }
            }

            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            return (salt, hashed);
        }

        /// <summary>
        /// Handles the Click event of the ImgClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ImgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnReset control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (editRecord == true)
            {
                editRecord = false;
                HideTerminateDetails();

            }
            ClearFields();
        }

        /// <summary>
        /// Clears the fields.
        /// </summary>
        public void ClearFields()
        {
            txtFirstName.Text = "";
            txtMidName.Text = "";
            txtLastName.Text = "";
            txtHouseNo.Text = "";
            txtStreet.Text = "";
            txtPostCode.Text = "";
            txtCity.Text = "";
            txtCounty.Text = "";
            txtPassword.Text = "";
            txtCountry.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            dtpDateOfBirth.ResetText();
            dtpEmpDate.ResetText();
            dtpTermDate.ResetText();
            rdBtnMale.Checked = false;
            rdBtnFemale.Checked = false;
            rdBtnIsAdminTrue.Checked = false;
            rdBtnIsAdminFalse.Checked = false;
        }

        /// <summary>
        /// Handles the CellDoubleClick event of the dataGridEmployee control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                editRecord = true;
                //ShowTerminateDetails();

                var rowIndex = dataGridEmployee.Rows[e.RowIndex].Index;
                customerId = (int)dataGridEmployee.Rows[rowIndex].Cells["Id"].Value;
                //MessageBox.Show("ID is: "+customerId.ToString(), "PharmaZeal");
                //MessageBox.Show(rowIndex.ToString(), "PharmaZeal");
                txtFirstName.Text = dataGridEmployee.Rows[rowIndex].Cells["firstName"].Value.ToString();
                txtMidName.Text = dataGridEmployee.Rows[rowIndex].Cells["midName"].Value.ToString();
                txtLastName.Text = dataGridEmployee.Rows[rowIndex].Cells["lastName"].Value.ToString();
                dtpDateOfBirth.Value = Convert.ToDateTime(dataGridEmployee.Rows[rowIndex].Cells["dob"].Value.ToString());
                dtpEmpDate.Value = Convert.ToDateTime(dataGridEmployee.Rows[rowIndex].Cells["employedDate"].Value.ToString());
                dtpTermDate.Value = Convert.ToDateTime(dataGridEmployee.Rows[rowIndex].Cells["terminateDate"].Value.ToString());
                txtHouseNo.Text = dataGridEmployee.Rows[rowIndex].Cells["houseNo"].Value.ToString();
                txtStreet.Text = dataGridEmployee.Rows[rowIndex].Cells["street"].Value.ToString();
                txtPostCode.Text = dataGridEmployee.Rows[rowIndex].Cells["postCode"].Value.ToString();
                txtCity.Text = dataGridEmployee.Rows[rowIndex].Cells["city"].Value.ToString();
                txtCounty.Text = dataGridEmployee.Rows[rowIndex].Cells["county"].Value.ToString();
                lblCountry.Text = dataGridEmployee.Rows[rowIndex].Cells["country"].Value.ToString();
                txtPhone.Text = dataGridEmployee.Rows[rowIndex].Cells["phone"].Value.ToString();
                txtEmail.Text = dataGridEmployee.Rows[rowIndex].Cells["email"].Value.ToString();
                var gender = dataGridEmployee.Rows[rowIndex].Cells["gender"].Value.ToString().Trim();
                var isAdmin = dataGridEmployee.Rows[rowIndex].Cells["isAdmin"].Value;
                rdBtnFemale.Checked = gender == "Female" ? true : false;
                rdBtnMale.Checked = gender == "Male" ? true : false;
                cmbBoxStores.SelectedValue = Convert.ToInt32(dataGridEmployee.Rows[rowIndex].Cells["StoreId"].Value);


                if (!string.IsNullOrEmpty(isAdmin.ToString().Trim()) || isAdmin != DBNull.Value)
                {
                    if ((bool)dataGridEmployee.Rows[rowIndex].Cells["isAdmin"].Value == true)
                    {
                        rdBtnIsAdminTrue.Checked = true;
                        rdBtnIsAdminFalse.Checked = false;
                    }
                    else
                    {
                        rdBtnIsAdminFalse.Checked = true;
                        rdBtnIsAdminTrue.Checked = false;
                    }
                }
                else
                {
                    rdBtnIsAdminTrue.Checked = false;
                    rdBtnIsAdminFalse.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PharmaZeal");
            }
        }

        /// <summary>
        /// Handles the CellContentClick event of the dataGridEmployee control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            customerId = Convert.ToInt32(dataGridEmployee.Rows[rowIndex].Cells["Id"].Value);
            if (dataGridEmployee.Columns[e.ColumnIndex].Name == "Delete")
            {
                //MessageBox.Show(dataGridEmployee.Rows[rowIndex].Cells[0].Value.ToString());
                if (MessageBox.Show($"Confirm delete of this record.", "PharmaZeal", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //MessageBox.Show("Delete Successful", "PharmaZeal");
                    try
                    {
                        var QueryString = "";
                        QueryString = "UPDATE FROM UserAccount SET IsDeleted = @isDeleted " +
                                    " WHERE Id=@Id";


                        if (sqlConn.State == ConnectionState.Open)
                            sqlConn.Close();

                        sqlConn.Open();
                        using (var cmd = new SqlCommand(QueryString, sqlConn))
                        {

                            cmd.Parameters.AddWithValue("@Id", customerId);
                            cmd.Parameters.AddWithValue("@isDeleted", true);



                            int successInsert = cmd.ExecuteNonQuery();
                            if (successInsert > 0)
                            {
                                MessageBox.Show("Delete Successful", "PharmaZeal", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                GetEmployees();

                                //ClearFields();
                            }
                            else
                                MessageBox.Show("Delete Not Successful", "PharmaZeal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "PharmaZeal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Paint event of the panel2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
