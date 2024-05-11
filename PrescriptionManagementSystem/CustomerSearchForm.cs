// ***********************************************************************
// Assembly         : PrescriptionManagementSystem
// Author           : ogaga.ivhurie
// Created          : 02-28-2024
//
// Last Modified By : ogaga.ivhurie
// Last Modified On : 05-11-2024
// ***********************************************************************
// <copyright file="CustomerSearchForm.cs" company="PrescriptionManagementSystem">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using PrescriptionManagementSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrescriptionManagementSystem
{
    /// <summary>
    /// Class CustomerSearchForm.
    /// Implements the <see cref="Form" />
    /// </summary>
    /// <seealso cref="Form" />
    public partial class CustomerSearchForm : Form
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
        /// The customer identifier
        /// </summary>
        public int customerId;
        /// <summary>
        /// The sales form
        /// </summary>
        private SalesForm salesForm = null;
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSearchForm"/> class.
        /// </summary>
        public CustomerSearchForm()
        {
            InitializeComponent();
            AppConfig.getDBConnection();
            sqlConn = AppConfig.sqlConn;
            //ConnectDB();
            GetCustomers();
            btnCustSale.Visible = false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSearchForm"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        public CustomerSearchForm(string source)
        {
            AppConfig.customerFormSource = source;
            //MessageBox.Show(source, "PharmaZeal");
            InitializeComponent();
            AppConfig.getDBConnection();
            sqlConn = AppConfig.sqlConn;
            //ConnectDB();
            GetCustomers();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSearchForm"/> class.
        /// </summary>
        /// <param name="callingForm">The calling form.</param>
        public CustomerSearchForm(Form callingForm)
        {
            salesForm = (SalesForm)callingForm;
            InitializeComponent();
            btnCustSale.Visible = true;
            AppConfig.getDBConnection();
            sqlConn = AppConfig.sqlConn;
            GetCustomers();
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
        /// Connects the database.
        /// </summary>
        private void ConnectDB()
        {
            string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PharmaZeal; Integrated Security=True; ";
            sqlConn = new SqlConnection(connectionStr);
        }

        /// <summary>
        /// Gets the customers.
        /// </summary>
        private void GetCustomers()
        {

            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;

            try
            {
                string sqlQuery = "SELECT *, DATEDIFF(hour,DateOfBirth,GETDATE())/8766 AS [Age] FROM Customer";
                string sqlQuery2 = "SELECT FirstName+' '+OtherName+' '+LastName AS [Full Name], HouseNo AS [House No], " +
                    "StreetName AS [Street Name], PostCode AS [Post Code], City, County, Country, " +
                    " DateOfBirth as [Date of Birth], Vulnerable, DATEDIFF(hour,DateOfBirth,GETDATE())/8766 AS [Age] FROM Customer";
                sqlConn.Open();
                //MessageBox.Show("Connected to DB", "PharnaZeal");
                //sqlCmd = new SqlCommand("SELECT * FROM Customer", sqlConn);
                dataTable = new DataTable("Customers");
                sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                sqlDataAdapter.Fill(dataTable);

                dgvCustomer.AutoGenerateColumns = false;

                dgvCustomer.DataSource = dataTable;


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
        /// Gets the customer prescription history.
        /// </summary>
        /// <param name="custId">The customer identifier.</param>
        private void GetCustomerPrescriptionHistory(int custId)
        {

            try
            {
                DataTable dataTable;
                SqlDataAdapter sqlDataAdapter;

                try
                {
                    string sqlQuery = @"SELECT Sales.DateSold, PD.[Name] AS ProductName, PD.Condition, UA.FirstName + ' '+ UA.LastName AS SoldBy 
                                        FROM SalesItem SI INNER JOIN Sales ON Sales.Id = SI.SaleId 
                                        INNER JOIN PharmaDrugs PD ON SI.DrugId= PD.Id
                                        INNER JOIN UserAccount UA ON Sales.UserId = UA.Id
                                        WHERE Sales.CustomerId=@CustomerId";
                    sqlConn.Open();
                    //MessageBox.Show("Connected to DB", "PharnaZeal");
                    //sqlCmd = new SqlCommand("SELECT * FROM Customer", sqlConn);
                    sqlCmd = new SqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@CustomerId", custId);
                    dataTable = new DataTable("Customers");
                    sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                    sqlDataAdapter.Fill(dataTable);

                    dgvPrescriptionHistory.AutoGenerateColumns = false;

                    dgvPrescriptionHistory.DataSource = dataTable;


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
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Handles the TextChanged event of the txtSearchCustomer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            //var bd = (BindingSource)dataGridCustomer.DataSource;
            //var dt = (DataTable)bd.DataSource;
            //dt.DefaultView.RowFilter = string.Format("LibService like '%{0}%'", txtSearchCustomer.Text.Trim().Replace("'", "''"));
            //dataGridCustomer.Refresh();
            BindingSource bindingSource = new();
            bindingSource.DataSource = dgvCustomer.DataSource;
            bindingSource.Filter = "FirstName like '%" + txtSearchCustomer.Text + "%'";
            dgvCustomer.DataSource = bindingSource.DataSource;
        }

        /// <summary>
        /// Handles the DataBindingComplete event of the dataGridCustomer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewBindingCompleteEventArgs"/> instance containing the event data.</param>
        private void dataGridCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var rowCount = dgvCustomer.Rows.Count;
            if (rowCount > 0)
            {
                foreach (DataGridViewRow row in dgvCustomer.Rows)
                {
                    //vulnerable.ToString().Trim()) || vulnerable != DBNull.Value
                    var vulnerable = row.Cells["Vulnerable"].Value;

                    if (!string.IsNullOrEmpty(vulnerable.ToString().Trim()) || vulnerable != DBNull.Value)
                    {
                        if ((bool)vulnerable == true)
                        {
                            //MessageBox.Show(vulnerable.ToString(), "PharmaZeal OnBinding");
                            dgvCustomer.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Red;
                            dgvCustomer.Rows[row.Index].DefaultCellStyle.SelectionBackColor = Color.AntiqueWhite;
                            dgvCustomer.Rows[row.Index].DefaultCellStyle.SelectionForeColor = Color.Red;
                        }
                    }
                    //if (vulnerable == true)
                }
            }
        }

        /// <summary>
        /// Handles the CellContentDoubleClick event of the dataGridCustomer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = dgvCustomer.Rows[e.RowIndex].Index;
            customerId = (int)dgvCustomer.Rows[rowIndex].Cells["Id"].Value;
            AppConfig.customerName = $"{dgvCustomer.Rows[rowIndex].Cells["FirstName"].Value.ToString()} {dgvCustomer.Rows[rowIndex].Cells["LastName"].Value.ToString()} ";
           
            panelPrescriptionHistory.Visible = true;
            //panelHistory.Visible = true;
            this.Height = 926;
            dgvCustomer.Enabled = false;
            dgvCustomer.ReadOnly = true;
            GetCustomerPrescriptionHistory(customerId);
        }

        /// <summary>
        /// Handles the Load event of the CustomerSearchForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CustomerSearchForm_Load(object sender, EventArgs e)
        {
            panelPrescriptionHistory.Visible = false;

            //panelHistory.Visible = false;
            this.Height = 626;
        }

        /// <summary>
        /// Handles the Click event of the btnHideHistory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnHideHistory_Click(object sender, EventArgs e)
        {
            panelPrescriptionHistory.Visible = false;
            dgvCustomer.Enabled = true;
            dgvCustomer.ReadOnly = false;
            AppConfig.customerId = 0;
            this.Height = 626;
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
        /// Handles the Click event of the btnCustSale control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCustSale_Click(object sender, EventArgs e)
        {
            AppConfig.customerId = customerId;
            this.salesForm.CustomerId = $"{AppConfig.customerId.ToString()} {AppConfig.customerName}";

            this.Close();
        }

        /// <summary>
        /// Handles the Paint event of the panel1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
