// ***********************************************************************
// Assembly         : PrescriptionManagementSystem
// Author           : ogaga.ivhurie
// Created          : 03-18-2024
//
// Last Modified By : ogaga.ivhurie
// Last Modified On : 05-11-2024
// ***********************************************************************
// <copyright file="SystemSetupFrom.cs" company="PrescriptionManagementSystem">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using PrescriptionManagementSystem.Data.Models;

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
    /// <summary>
    /// Class SystemSetupFrom.
    /// Implements the <see cref="Form" />
    /// </summary>
    /// <seealso cref="Form" />
    public partial class SystemSetupFrom : Form
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
        /// The record identifier
        /// </summary>
        int recordId = 0;
        /// <summary>
        /// The system data
        /// </summary>
        SystemData systemData = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemSetupFrom"/> class.
        /// </summary>
        public SystemSetupFrom()
        {
            InitializeComponent();
            AppConfig.getDBConnection();
            sqlConn = AppConfig.sqlConn;
            systemData = AppConfig.systemData;
            //ConnectDB();
            loadData();
            //GetEmployees();
        }

        /// <summary>
        /// Handles the Load event of the ChangePasswordForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }



        //This method is for saving record
        /// <summary>
        /// Handles the Click event of the ImgSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ImgSave_Click(object sender, EventArgs e)
        {
            
            
            if (!ValidateForm()) // This method checks that the form is properly filled
            {
                MessageBox.Show("All from entry must be entered", "PharmaZeal");
                return;
            }

            if (MessageBox.Show("Proceed with modifying data", "PharmaZeal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Operation canceled", "PharmaZeal");
                return;
            }

            try
            {
                sqlConn.Open();
                var QueryString = "";
                MessageBox.Show("Editing Record", "PharmaZeal");
                QueryString = "UPDATE SystemTable " +
                            " SET CompanyName=@CompanyName, CompanyEmail=@CompanyEmail, CompanyAddress=@CompanyAddress, " +
                            " CompanyPhone=@CompanyPhone, MinStockLevel=@minStock, MaxSaleQty=@maxSale" +
                            " WHERE Id=@Id";




                using var cmd = new SqlCommand(QueryString, sqlConn);

                cmd.Parameters.AddWithValue("@Id", recordId);

                cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
                cmd.Parameters.AddWithValue("@CompanyEmail", txtCompanyEmail.Text);
                cmd.Parameters.AddWithValue("@CompanyAddress", txtCompanyAddress.Text);
                cmd.Parameters.AddWithValue("@CompanyPhone", txtCompanyPhone.Text);
                cmd.Parameters.AddWithValue("@minStock", nudStockLevel.Value);
                cmd.Parameters.AddWithValue("@maxSale", nudSaleQty.Value);



                int successInsert = cmd.ExecuteNonQuery();
                if (successInsert > 0)
                {
                    MessageBox.Show("Update Successful", "PharmaZeal");

                    ClearFields();
                    AppConfig.getSystemaData();
                    loadData();
                }

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

        // This method clears the fields after successful save
        /// <summary>
        /// Clears the fields.
        /// </summary>
        public void ClearFields()
        {
            txtCompanyEmail.Text = "";
            txtCompanyAddress.Text = "";
            txtCompanyName.Text = "";
            txtCompanyPhone.Text = "";
            nudSaleQty.Value = 1;
            nudStockLevel.Value = 1;
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
        /// Loads the data.
        /// </summary>
        private void loadData()
        {
            
            try
            {
                recordId = AppConfig.systemData.Id;
                txtCompanyName.Text = AppConfig.systemData.CompanyName;
                txtCompanyAddress.Text = AppConfig.systemData.CompanyAddress;
                txtCompanyEmail.Text = AppConfig.systemData.CompanyEmail;
                txtCompanyPhone.Text = AppConfig.systemData.CompanyPhone;
                nudSaleQty.Value = AppConfig.systemData.MaxSaleQty;
                nudStockLevel.Value = AppConfig.systemData.MinStockLevel;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured: {ex.Message}", "PharmaZeal");
            }
            finally
            {
                sqlConn?.Close();
            }
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
        /// Handles the Click event of the btnClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnLoadData control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            loadData();
        }

        /// <summary>
        /// Handles the Click event of the btnReset control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        /// <summary>
        /// Validates the form.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool ValidateForm()
        {
            if (txtCompanyName.Text.Trim() == "" || txtCompanyAddress.Text.Trim() == "" ||
                    txtCompanyEmail.Text.Trim() == "" || txtCompanyPhone.Text.Trim() == "")
            {
                return false;
            }
            else
                return true;
        }
    }
}
