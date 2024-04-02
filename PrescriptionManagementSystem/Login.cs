using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.VisualBasic.ApplicationServices;
using PrescriptionManagementSystem.Data.DTOs;
using PrescriptionManagementSystem.Data.Models;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace PrescriptionManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection sqlConn;
        SqlCommand sqlCmd;
        SqlDataReader rdr;
        bool editRecord = false;
        int customerId = 0;
        public LoginForm()
        {
            InitializeComponent();
            
            sqlConn = AppConfig.sqlConn;
            cmbBoxStores.DataSource = AppConfig.bindingSource;
            cmbBoxStores.DisplayMember = "Name";
            cmbBoxStores.ValueMember = "Id";
            
            //getStoreDetails();
            //ConnectDB();
        }
        private void ConnectDB()
        {
            string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PharmaZeal; Integrated Security=True; ";
            sqlConn = new SqlConnection(connectionStr);
        }

        private void pbSignout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //public (bool, string, string, string, int) CheckUsersAccount(string userEmail)
        public UserDTO CheckUsersAccount(string userEmail)
        {
            DataSet custDs = new DataSet();
            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;
            bool userExist = false;
            string paswdHash = "";
            string saltKey = "";
            string storeName = "";
            int loggedInUserId = 0;
            UserDTO userDTO = null;
            try
            {
                //conn = new SqlConnection(connectionStr);
                //cmd = new SqlCommand("SELECT * FROM Customer");
                string sqlQuery = "SELECT u.*, s.Name AS StoreName FROM UserAccount u " +
                    "JOIN Stores s ON u.StoreId=s.Id " +
                    "WHERE  u.Email=@email and u.IsDeleted != 1 and StoreId=@storeId";
                Store store = (Store)cmbBoxStores.SelectedItem;
                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
                sqlConn.Open();
                //MessageBox.Show("Connected to DB", "PharnaZeal");
                //sqlCmd = new SqlCommand("SELECT * FROM Customer", sqlConn);
                using (var cmd = new SqlCommand(sqlQuery, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@email", userEmail);
                    cmd.Parameters.AddWithValue("@storeId", store.Id);

                    var reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        return userDTO; // (userExist, paswdHash, saltKey, storeName, loggedInUserId);
                    }
                    while (reader.Read())
                    {
                        //MessageBox.Show(reader.GetString(0));
                        //MessageBox.Show(reader["PasswordHash"].ToString());
                        userDTO = new UserDTO()
                        {
                            Email = reader["Email"].ToString(),
                            IsAdmin = (bool)reader["IsAdmin"],
                            PasswordHash = reader["PasswordHash"].ToString(),
                            Name = $"{reader["FirstName"]} {reader["LastName"]}",
                            Store = reader["StoreName"].ToString(),
                            Id = (int)reader["Id"],
                            SaltKey = reader["SecurityStamp"].ToString(),
                            StoreId = (int)reader["StoreId"],
                        };
                        userExist = true;
                        paswdHash = reader["PasswordHash"].ToString();
                        saltKey = reader["SecurityStamp"].ToString();
                        storeName = reader["StoreName"].ToString();
                        loggedInUserId = (int)reader["Id"];


                    }
                }
                return userDTO;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PharmaZeal");
                return userDTO; // (userExist, paswdHash, saltKey, storeName, loggedInUserId);
            }
            finally
            {
                sqlConn?.Close();
            }
        }

        public void getStoreDetails()
        {
            DataSet custDs = new DataSet();
            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;
            bool userExist = false;
            string paswdHash = "";
            string saltKey = "";
            List<Store> stores = new List<Store>();
            Store store;
            try
            {
                //conn = new SqlConnection(connectionStr);
                //cmd = new SqlCommand("SELECT * FROM Customer");
                string sqlQuery = "SELECT * FROM Stores WHERE IsDeleted != 1";

                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
                sqlConn.Open();
                //MessageBox.Show("Connected to DB", "PharnaZeal");
                //sqlCmd = new SqlCommand("SELECT * FROM Customer", sqlConn);
                using (var cmd = new SqlCommand(sqlQuery, sqlConn))
                {


                    var reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {

                    }
                    while (reader.Read())
                    {
                        //MessageBox.Show(reader.GetString(0));
                        //MessageBox.Show(reader["PasswordHash"].ToString());

                        store = new Store
                        {
                            Id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                        };
                        stores.Add(store);


                    }
                }

                //var bindingSource = new BindingSource();
                //bindingSource.DataSource = stores;
                //cmbBoxStores.DataSource = bindingSource;
                //cmbBoxStores.DisplayMember = "Name";
                //cmbBoxStores.ValueMember = "Id";
                //return (userExist, paswdHash, saltKey);




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PharmaZeal");
                //return (userExist, paswdHash, saltKey);
            }
            finally
            {
                sqlConn?.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //return;
            
            LoginUser user = new LoginUser();
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;

            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
            {
                MessageBox.Show("Enter all details", "PharmaZeal");
                return;
            }

            if (!AppConfig.ValidateEmail(user.Email))
            {
                MessageBox.Show("Enter valid email address", "PharmaZeal");
                return;
            }

                //mainForm mainFormContainer = new mainForm();
                //mainFormContainer.WindowState = FormWindowState.Maximized;
                //mainFormContainer.Show();
            var (salt, hashed) = HashPassword(new byte[] { }, user.Password);
            UserDTO userDTO = CheckUsersAccount(user.Email);
            if (userDTO != null)
            {
                var byteSalt = Convert.FromBase64String(userDTO.SaltKey);
                var enteredPassword = (HashPassword(byteSalt, user.Password)).Item2;
                // MessageBox.Show(enteredPassword+"/n "+password);
                if (enteredPassword == userDTO.PasswordHash)
                {
                    AppConfig.loggedInUserId = userDTO.Id;
                    AppConfig.loggedInUserName = userDTO.Name;
                    AppConfig.loggedInUserStore = userDTO.Store;
                    AppConfig.loggedInUserIsAdmin = userDTO.IsAdmin;
                    AppConfig.loggedInStoreId = userDTO.StoreId;

                    this.Hide();
                    mainForm mainForm = new mainForm();
                    mainForm.WindowState = FormWindowState.Maximized;
                    mainForm.FormBorderStyle = FormBorderStyle.None;
                    mainForm.Show();
                    return;
                }
                //else
                //{
                //    MessageBox.Show("Invalid User Details", "PharmaZeal");
                //}
            }
            MessageBox.Show("Invalid User Details", "PharmaZeal");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
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

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Store store = (Store)cmbBoxStores.SelectedItem;
            //MessageBox.Show(store.Name, "PharmaZeal");
        }
    }
}
