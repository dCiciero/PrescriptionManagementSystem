using Microsoft.AspNetCore.Cryptography.KeyDerivation;
//using Microsoft.Office.Interop.Excel;
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
    public partial class ChangePasswordForm : Form
    {
        SqlConnection sqlConn;
        SqlCommand sqlCmd;
        SqlDataReader rdr;
        bool editRecord = false;
        int customerId = 0;

        public ChangePasswordForm()
        {
            InitializeComponent();
            AppConfig.getDBConnection();
            sqlConn = AppConfig.sqlConn;
            //ConnectDB();
            checkPassword();
            //GetEmployees();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void ConnectDB()
        {
            string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PharmaZeal; Integrated Security=True; ";
            sqlConn = new SqlConnection(connectionStr);
        }

        private void ImgSave_Click(object sender, EventArgs e)
        {
            checkPassword();
            var (salt, hashedPswd) = HashPassword(new byte[] { }, txtNewPassword.Text);
            string passworhHash = hashedPswd;


            try
            {
                sqlConn.Open();
                var QueryString = "";
                MessageBox.Show("Editing Record", "PharmaZeal");
                QueryString = "UPDATE UserAccount " +
                            " SET PasswordHash=@PasswordHash " +
                            " WHERE Id=@Id";




                using (var cmd = new SqlCommand(QueryString, sqlConn))
                {
                    if (editRecord)
                        cmd.Parameters.AddWithValue("@Id", customerId);

                    cmd.Parameters.AddWithValue("@PasswordHash", passworhHash);



                    int successInsert = cmd.ExecuteNonQuery();
                    if (successInsert > 0)
                    {
                        if (editRecord)
                            MessageBox.Show("Update Successful", "PharmaZeal");


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
        public void ClearFields()
        {
            txtConfirmNewPassword.Text = "";
            txtNewPassword.Text = "";
            txtOldPassword.Text = "";
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

        private void checkPassword()
        {
            DataSet custDs = new DataSet();
            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;
            try
            {
                //conn = new SqlConnection(connectionStr);
                //cmd = new SqlCommand("SELECT * FROM Customer");
                string sqlQuery = "SELECT * FROM UserAccount";
                string sqlQuery2 = "SELECT FirstName+' '+OtherName+' '+LastName AS [Full Name], HouseNo AS [House No], " +
                    "StreetName AS [Street Name], PostCode AS [Post Code], City, County, Country, " +
                    " DateOfBirth as [Date of Birth], Vulnerable FROM Customer";
                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
                sqlConn.Open();
                //MessageBox.Show("Connected to DB", "PharnaZeal");
                //sqlCmd = new SqlCommand("SELECT * FROM Customer", sqlConn);
                dataTable = new DataTable("Users");
                sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                sqlDataAdapter.Fill(dataTable);
                DataRow dr = dataTable.Rows[0];
                //dataGridCust.DataSource = dataTable;
                //dataGridCustomer.VirtualMode = dataGridCustomer.Visible = true; 
                //dataGridCustomer.VirtualMode = true;

                //dataGridCustomer.Update();
                //dataTable = new DataTable("Customers");
                //sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                //sqlDataAdapter.Fill(dataTable);


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

        private void ImgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
