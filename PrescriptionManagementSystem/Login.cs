// ***********************************************************************
// Assembly         : PrescriptionManagementSystem
// Author           : ogaga.ivhurie
// Created          : 02-22-2024
//
// Last Modified By : ogaga.ivhurie
// Last Modified On : 05-03-2024
// ***********************************************************************
// <copyright file="Login.cs" company="PrescriptionManagementSystem">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Domain;
using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.VisualBasic.ApplicationServices;
using PrescriptionManagementSystem.Data.DTOs;
using PrescriptionManagementSystem.Data.Models;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace PrescriptionManagementSystem
{
    /// <summary>
    /// Class LoginForm.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginForm : Form
    {
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
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
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
        /// <summary>
        /// Connects the database.
        /// </summary>
        private void ConnectDB()
        {
            string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PharmaZeal; Integrated Security=True; ";
            sqlConn = new SqlConnection(connectionStr);
        }

        /// <summary>
        /// Handles the Click event of the pbSignout control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pbSignout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This function retireves the users details based on the email if it exist and returns a UserDTO Object
        /// <summary>
        /// Checks the users account.
        /// </summary>
        /// <param name="userEmail">The user email.</param>
        /// <returns>UserResponseDTO.</returns>
        public UserResponseDTO CheckUsersAccount(string userEmail)
        {
            DataSet custDs = new DataSet();
            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;
            UserResponseDTO userResponseDTO = null;
            try
            {
                //This queries the User Account table and the Store table to get the store the user belongs to
                string sqlQuery = "SELECT u.*, s.Name AS StoreName FROM UserAccount u " +
                    "JOIN Stores s ON u.StoreId=s.Id " +
                    "WHERE  u.Email=@email and u.IsDeleted != 1 and StoreId=@storeId";
                Store store = (Store)cmbBoxStores.SelectedItem;
                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
                sqlConn.Open();
                
                using (var cmd = new SqlCommand(sqlQuery, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@email", userEmail);
                    cmd.Parameters.AddWithValue("@storeId", store.Id);

                    var reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        return userResponseDTO;
                    }
                    while (reader.Read())
                    {
                        //MessageBox.Show(reader.GetString(0));
                        //MessageBox.Show(reader["PasswordHash"].ToString());
                        userResponseDTO = new()
                        {
                            Email = reader["Email"].ToString(),
                            IsAdmin = (bool)reader["IsAdmin"],
                            PasswordHash = reader["PasswordHash"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            StoreName = reader["StoreName"].ToString(),
                            Id = (int)reader["Id"],
                            SaltKey = reader["SecurityStamp"].ToString(),
                            StoreId = (int)reader["StoreId"],
                        };
                        


                    }
                }
                return userResponseDTO;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PharmaZeal");
                return userResponseDTO; // (userExist, paswdHash, saltKey, storeName, loggedInUserId);
            }
            finally
            {
                sqlConn?.Close();
            }
        }

        /// <summary>
        /// Gets the store details.
        /// </summary>
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

        /// <summary>
        /// Handles the Click event of the btnLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLogin_Click(object sender, EventArgs e)
        {





            LoginUser userRequest = new LoginUser();
            userRequest.Email = txtEmail.Text;
            userRequest.Password = txtPassword.Text;
             var isFormValid = validateFormEntry(userRequest);
            if (!isFormValid)
            {
                MessageBox.Show("Enter all details", "PharmaZeal");
                return;
            }
/*            else
            {

                if (!AppConfig.ValidateEmail(userRequest.Email))
                {
                    MessageBox.Show("Enter valid email address", "PharmaZeal");
                    return;
                }
                Store store = (Store)cmbBoxStores.SelectedItem;


                LoginRequestDTO userRequestDTO = new LoginRequestDTO();
                userRequestDTO.Email = txtEmail.Text;
                userRequestDTO.Password = txtPassword.Text;
                userRequestDTO.StoreId = store.Id;

                bool isUserValid;
                UserResponseDTO userResponseDTO = new();

                userResponseDTO = GlobalConfig.Connection.CheckUsersAccount(userRequestDTO);
                if (userResponseDTO.Email != null)
                {
                    isUserValid = validateUser(userResponseDTO, userRequest);
                    if (!isUserValid)
                    {
                        MessageBox.Show("Invalid User Details", "PharmaZeal");
                        return;
                    }
                    else
                    {
                        AppConfig.loggedInUserId = userResponseDTO.Id;
                        AppConfig.loggedInUserName = userResponseDTO.FullName;
                        AppConfig.loggedInUserStore = userResponseDTO.StoreName;
                        AppConfig.loggedInUserIsAdmin = userResponseDTO.IsAdmin;
                        AppConfig.loggedInStoreId = userResponseDTO.StoreId;

                        this.Hide();
                        mainForm mainForm = new mainForm();
                        mainForm.WindowState = FormWindowState.Maximized;
                        mainForm.FormBorderStyle = FormBorderStyle.None;
                        mainForm.Show();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User Details", "PharmaZeal");
                    return;
                }
                //(isUserValid, userResponseDTO) = GlobalConfig.Connection.CheckUsersAccount(userRequestDTO);

            }*/

            //if (string.IsNullOrEmpty(userRequest.Email) || string.IsNullOrEmpty(userRequest.Password))
            //{
            //    MessageBox.Show("Enter all details", "PharmaZeal");
            //    return;
            //}





            //var (salt, hashed) = HashPassword(new byte[] { }, user.Password);

            //UserDTO userDTO = CheckUsersAccount(userRequest.Email);
            UserResponseDTO userResponseDTO = CheckUsersAccount(userRequest.Email);
            var isUserValidated = validateUser(userResponseDTO, userRequest);
            if (isUserValidated)
            {
                this.Hide();
                mainForm mainForm = new mainForm();
                mainForm.WindowState = FormWindowState.Maximized;
                mainForm.FormBorderStyle = FormBorderStyle.None;
                mainForm.Show();
                return;
            }
            else
            {
                MessageBox.Show("Invalid User Details", "PharmaZeal");
                return;
            }

            if (userResponseDTO != null)
            {
                var byteSalt = Convert.FromBase64String(userResponseDTO.SaltKey);
                var enteredPassword = (HashPassword(byteSalt, userRequest.Password)).Item2;
                // MessageBox.Show(enteredPassword+"/n "+password);
                if (enteredPassword == userResponseDTO.PasswordHash)
                {
                    AppConfig.loggedInUserId = userResponseDTO.Id;
                    AppConfig.loggedInUserName = userResponseDTO.FullName;
                    AppConfig.loggedInUserStore = userResponseDTO.StoreName;
                    AppConfig.loggedInUserIsAdmin = userResponseDTO.IsAdmin;
                    AppConfig.loggedInStoreId = userResponseDTO.StoreId;

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

        /// <summary>
        /// Validates the user.
        /// </summary>
        /// <param name="userDTO">The user dto.</param>
        /// <param name="userRequest">The user request.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool validateUser(UserResponseDTO userDTO, LoginUser userRequest)
        {
            if (userDTO != null)
            {
                var byteSalt = Convert.FromBase64String(userDTO.SaltKey);
                var enteredPassword = (HashPassword(byteSalt, userRequest.Password)).Item2;
                if (enteredPassword == userDTO.PasswordHash)
                {
                    AppConfig.loggedInUserId = userDTO.Id;
                    AppConfig.loggedInUserName = userDTO.FullName;
                    AppConfig.loggedInUserStore = userDTO.StoreName;
                    AppConfig.loggedInUserIsAdmin = userDTO.IsAdmin;
                    AppConfig.loggedInStoreId = userDTO.StoreId;
                    

                    
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Validates the form entry.
        /// </summary>
        /// <param name="userRequest">The user request.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool validateFormEntry(LoginUser userRequest)
        {
            if (userRequest.Email.Length==0 || userRequest.Password.Length==0)
            {
                return false;
            }
            else
            {

                return true;
            }
        }
        /// <summary>
        /// Handles the Click event of the btnReset control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //HomeForm homeForm = new HomeForm();
            //homeForm.Show();
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
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
        /// Handles the Click event of the lblPassword control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbBoxStores control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbBoxStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Store store = (Store)cmbBoxStores.SelectedItem;
            //MessageBox.Show(store.Name, "PharmaZeal");
        }
    }
}
