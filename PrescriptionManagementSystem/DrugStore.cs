// ***********************************************************************
// Assembly         : PrescriptionManagementSystem
// Author           : ogaga.ivhurie
// Created          : 03-05-2024
//
// Last Modified By : ogaga.ivhurie
// Last Modified On : 03-26-2024
// ***********************************************************************
// <copyright file="DrugStore.cs" company="PrescriptionManagementSystem">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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
    /// Class DrugStoreForm.
    /// Implements the <see cref="Form" />
    /// </summary>
    /// <seealso cref="Form" />
    public partial class DrugStoreForm : Form
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
        /// Initializes a new instance of the <see cref="DrugStoreForm"/> class.
        /// </summary>
        public DrugStoreForm()
        {
            InitializeComponent();
            ConnectDB();
            GetDrugStoreData();
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
        /// Gets the drug store data.
        /// </summary>
        private void GetDrugStoreData()
        {
            DataSet custDs = new DataSet();
            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;


            try
            {
                string sqlQuery = "SELECT * FROM PharmaDrugs";

                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
                sqlConn.Open();
                dataTable = new DataTable("PharmaDrugs");
                sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                sqlDataAdapter.Fill(dataTable);
                dataGridDrugSet.AutoGenerateColumns = false;

                dataGridDrugSet.DataSource = dataTable;


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
        /// Handles the Load event of the DrugStoreForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DrugStoreForm_Load(object sender, EventArgs e)
        {

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
        /// Handles the TextChanged event of the txtSearchDrugStore control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtSearchDrugStore_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new();
            bindingSource.DataSource = dataGridDrugSet.DataSource;
            bindingSource.Filter = "Name like '%" + txtSearchDrugStore.Text + "%'";
            dataGridDrugSet.DataSource = bindingSource.DataSource;
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
    }
}
