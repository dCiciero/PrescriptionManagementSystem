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
    public partial class CreateUserForm : Form
    {
        SqlConnection sqlConn;
        SqlCommand sqlCmd;
        SqlDataReader rdr;
        bool editRecord = false;
        int customerId = 0;
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

        private void ImgSave_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Editing Record", "PharmaZeal");
                    QueryString = "UPDATE UserAccount " +
                                " SET FirstName = @FirstName, LastName=@LastName, MiddleName=@MiddleName, HouseNo=@HouseNo," +
                                " StreetName=@StreetName, PostCode=@PostCode, City=@City, County=@County, Country=@Country," +
                                " BirthDate=@DateOfBirth, StatusId=@StatusId, DateEmployed=@DateEmployed, DateDisengaged=@DateDisengaged, " +
                                " PasswordHash=@PasswordHash, Email=@Email, NormalizedEmail=@NormalizedEmail, IsAdmin=@IsAdmin, Gender=@Gender, " +
                                " Phone=@phone, SecurityStamp = @securityStamp, StoreId=@storeId WHERE Id=@Id";
                }
                else
                {
                    MessageBox.Show("Saving Record", "PharmaZeal");
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


        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            if (this.editRecord == false)
            {
                HideTerminateDetails();
            }
        }

        private void HideTerminateDetails()
        {
            chkTerminateUser.Visible = false;
            chkTerminateUser.Text = "";

            dtpTermDate.Visible = false;
            lblTerminateDate.Visible = false;
        }

        private void ShowTerminateDetails()
        {
            lblTerminateDate.Visible = true;
            dtpTermDate.Visible = true;
            chkTerminateUser.Visible = true;
            chkTerminateUser.Text = "Terminate User?";
        }

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

        private void ImgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (editRecord == true)
            {
                editRecord = false;
                HideTerminateDetails();

            }
            ClearFields();
        }

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
                            MessageBox.Show("Delete Successful", "PharmaZeal");


                            GetEmployees();

                            //ClearFields();
                        }
                        else
                            MessageBox.Show("Delete Not Successful", "PharmaZeal");
                    };
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
