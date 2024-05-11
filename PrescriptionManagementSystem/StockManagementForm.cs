// ***********************************************************************
// Assembly         : PrescriptionManagementSystem
// Author           : ogaga.ivhurie
// Created          : 02-29-2024
//
// Last Modified By : ogaga.ivhurie
// Last Modified On : 05-11-2024
// ***********************************************************************
// <copyright file="StockManagementForm.cs" company="PrescriptionManagementSystem">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Domain.Models;
using PrescriptionManagementSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrescriptionManagementSystem
{
    /// <summary>
    /// Class StockManagementForm.
    /// Implements the <see cref="Form" />
    /// </summary>
    /// <seealso cref="Form" />
    public partial class StockManagementForm : Form
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
        /// The SQL transaction
        /// </summary>
        SqlTransaction sqlTransaction;
        /// <summary>
        /// The stock identifier
        /// </summary>
        int stockId = 0;
        /// <summary>
        /// Initializes a new instance of the <see cref="StockManagementForm"/> class.
        /// </summary>
        public StockManagementForm()
        {
            InitializeComponent();
            sqlConn = AppConfig.sqlConn;
            GetDrugsData();

        }

        /// <summary>
        /// Handles the Click event of the ImgClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ImgClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GetDrugsData();
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
        /// Gets the drugs data.
        /// </summary>
        private void GetDrugsData()
        {

            DataSet custDs = new DataSet();
            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;

            try
            {
                string sqlQuery = "SELECT * FROM Stock WHERE IsDeleted != 1";
                //string sqlQuery2 = "SELECT FirstName+' '+OtherName+' '+LastName AS [Full Name], HouseNo AS [House No], " +
                //    "StreetName AS [Street Name], PostCode AS [Post Code], City, County, Country, " +
                //    " DateOfBirth as [Date of Birth], Vulnerable FROM Customer";
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }
                //MessageBox.Show("Connected to DB", "PharnaZeal");
                //sqlCmd = new SqlCommand("SELECT * FROM Customer", sqlConn);
                dataTable = new DataTable("Drugs");
                sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                sqlDataAdapter.Fill(dataTable);

                drvDrugs.AutoGenerateColumns = false;

                drvDrugs.DataSource = dataTable;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in getting data {ex.Message}", "PharmaZeal");
            }
            finally
            {
                sqlConn?.Close();
            }
        }

        /// <summary>
        /// Handles the Load event of the StockManagementForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void StockManagementForm_Load(object sender, EventArgs e)
        {
            panelBulkEntry.Visible = false;
            panelSingleEntry.Visible = false;
            btnGetFile.Visible = false;
            //MessageBox.Show(chkBoxStoke.Checked.ToString(), "PharmaZeal");
            panelSingleEntry.Dock = DockStyle.Fill;
            panelBulkEntry.Dock = DockStyle.Fill;
            cmbStockType.DataSource = AppConfig.stockTypeBindingSource;
            cmbStockType.DisplayMember = "Name";
            cmbStockType.ValueMember = "Id";
            rdBtnSingleEntry.Select();
        }

        /// <summary>
        /// Handles the TextChanged event of the txtSearchDrug control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void txtSearchDrug_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource bindingSource = new();
                bindingSource.DataSource = drvDrugs.DataSource;
                bindingSource.Filter = "Name like '%" + txtDrugName.Text + "%'";
                drvDrugs.DataSource = bindingSource.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, contact your administrator", "PharmaZeal");
            }
        }



        /// <summary>
        /// Handles the CellClick event of the dataGridDrugs control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs" /> instance containing the event data.</param>
        private void dataGridDrugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            stockId = Convert.ToInt32(drvDrugs.Rows[rowIndex].Cells["Id"].Value);
            if (drvDrugs.Columns[e.ColumnIndex].Name == "Delete")
            {
                //MessageBox.Show(drvDrugs.Rows[rowIndex].Cells[0].Value.ToString());
                if (MessageBox.Show("Confirm Delete", "PharmaZeal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    // TODO - Implement pending task on Stockmanagemnt screen
                    try
                    {
                        var QueryString = "";
                        QueryString = "UPDATE PharmaDrugs SET IsDeleted = @isDeleted " +
                                    " WHERE Id=@Id";


                        if (sqlConn.State == ConnectionState.Open)
                            sqlConn.Close();

                        sqlConn.Open();
                        sqlTransaction = sqlConn.BeginTransaction();
                        using var cmd = new SqlCommand(QueryString, sqlConn, sqlTransaction);
                        cmd.Parameters.AddWithValue("@Id", stockId);
                        cmd.Parameters.AddWithValue("@isDeleted", true);

                        int successInsert = cmd.ExecuteNonQuery();
                        if (successInsert > 0)
                        {
                            QueryString = "UPDATE Stock SET IsDeleted = @isDeleted " +
                                        " WHERE DrugId=@Id";

                            //if (sqlConn.State == ConnectionState.Open)
                            //    sqlConn.Close();

                            //sqlConn.Open();
                            //sqlTransaction = sqlConn.BeginTransaction();
                            using var cmd2 = new SqlCommand(QueryString, sqlConn, sqlTransaction);

                            cmd2.Parameters.AddWithValue("@Id", stockId);
                            cmd2.Parameters.AddWithValue("@isDeleted", true);
                            if (cmd2.ExecuteNonQuery() > 0)
                            {
                                sqlTransaction.Commit();
                                MessageBox.Show("Delete Successful", "PharmaZeal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GetDrugsData();
                                return;
                            }
                            else
                            {
                                sqlTransaction.Rollback();
                                MessageBox.Show("Delete Not Successful", "PharmaZeal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            sqlTransaction.Rollback();
                            MessageBox.Show("Delete Not Successful", "PharmaZeal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                            
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();
                        MessageBox.Show($"Error Deleting Record {ex.Message}","PharmaZeal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the ImgSave control.
        /// It to save the stock data to database
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ImgSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed with transaction", "PharmaZeal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Operation canceled", "PharmaZeal");
                return;
            }
            StockType stockType = (StockType)cmbStockType.SelectedItem;
            var drugName = txtDrugName.Text;
            var condition = txtCondition.Text;
            var quantity = txtQuantity.Text;
            var unitCost = txtUnitCost.Text;
            DateTime expiryDate = Convert.ToDateTime(dtpExpiryDate.Text);
            var reorderLevel = txtReorderQty.Text;
            var minStockLevel = txtMinStockLevel.Text;
            var stoke = chkBoxStoke.Checked;
            var tunstall = chkBoxTunstall.Checked;
            var hanley = chkBoxHanley.Checked;
            var fenton = chkBoxFenton.Checked;
            var longton = chkBoxLongton.Checked;
            var checkId = chkBoxCheckId.Checked;
            var stockTypeId = stockType.Id;
            try
            {
                sqlConn.Open();
                sqlTransaction = sqlConn.BeginTransaction(); // A transaction is initiated here because we are saving into 2 tables (PharmaDrugs and Stock)
                var QueryString = "";
                MessageBox.Show("Saving Record", "PharmaZeal");

                QueryString = "INSERT INTO PharmaDrugs " +
                            "(Name, Condition, IdCheck, InStoke, InTunstall, InFenton, InHanley, InLongton) " +
                            "Values (@Name, @Condition, @IdCheck, @InStoke, @InTunstall, @InFenton, @InHanley, @InLongton)" +
                            "SELECT CAST(scope_identity() AS int)";

                using var cmd2 = new SqlCommand(QueryString, sqlConn, sqlTransaction);
                cmd2.Parameters.AddWithValue("@Name", drugName);
                cmd2.Parameters.AddWithValue("@Condition", condition);
                cmd2.Parameters.AddWithValue("@IdCheck", checkId);
                cmd2.Parameters.AddWithValue("@InStoke", stoke);
                cmd2.Parameters.AddWithValue("@InTunstall", tunstall);
                cmd2.Parameters.AddWithValue("@InFenton", fenton);
                cmd2.Parameters.AddWithValue("@InHanley", hanley);
                cmd2.Parameters.AddWithValue("@InLongton", longton);


                var drugId = (Int32)cmd2.ExecuteScalar();

                if (drugId > 0)
                {
                    QueryString = "INSERT INTO Stock " +
                            "(Name, Quantity, Expiry, UnitCost, ReorderPoint, MinStockLevel, DrugId, StockTypeId)" +
                            "Values (@Name, @Quantity, @Expiry, @UnitCost, @ReorderPoint, @MinStockLevel, @DrugId, @StockTypeId)" +
                            "SELECT CAST(scope_identity() AS int)";



                    using var cmd = new SqlCommand(QueryString, sqlConn, sqlTransaction);

                    cmd.Parameters.AddWithValue("@Name", drugName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Expiry", expiryDate);
                    cmd.Parameters.AddWithValue("@UnitCost", unitCost);
                    cmd.Parameters.AddWithValue("@ReorderPoint", reorderLevel);
                    cmd.Parameters.AddWithValue("@MinStockLevel", minStockLevel);
                    cmd.Parameters.AddWithValue("@DrugId", drugId);
                    cmd.Parameters.AddWithValue("@StockTypeId", stockTypeId);



                    int stockId = Convert.ToInt32(cmd.ExecuteScalar());
                    if (stockId > 0)
                    {
                        sqlTransaction.Commit();
                        MessageBox.Show("Record saved successfully", "PharmaZeal");
                        ResetControls();
                        GetDrugsData();
                    }
                    else
                    {
                        MessageBox.Show("Record not saved", "PharmaZeal");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error carrying out operation/n {ex.Message}", "PharmaZeal");
                sqlTransaction.Rollback();
            }
            finally
            {
                sqlConn.Close();
                sqlTransaction.Dispose();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnReset control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        /// <summary>
        /// Resets the controls.
        /// </summary>
        private void ResetControls()
        {
            txtDrugName.Text = "";
            txtQuantity.Text = "0";
            dtpExpiryDate.ResetText();
            txtUnitCost.Text = "0";
            txtReorderQty.Text = "0";
            txtMinStockLevel.Text = "0";
            txtCondition.Text = "";
            chkBoxFenton.Checked = false;
            chkBoxHanley.Checked = false;
            chkBoxStoke.Checked = false;
            chkBoxLongton.Checked = false;
            chkBoxTunstall.Checked = false;
            chkBoxCheckId.Checked = false;
        }

        /// <summary>
        /// Handles the Click event of the btnGetFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnGetFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0};Extended Properties='Excel 8.0; HDR={1}'";
                    con = string.Format(con, filePath, "yes");
                    OleDbConnection excelCon = new OleDbConnection(con);
                    excelCon.Open();
                    System.Data.DataTable dtExcel = excelCon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    string excelSheet = dtExcel.Rows[0]["TABLE_NAME"].ToString();
                    OleDbCommand com = new OleDbCommand($"SELECT * FROM {excelSheet}", excelCon);
                    OleDbDataAdapter oda = new OleDbDataAdapter(com);
                    DataTable dataTable = new DataTable();
                    oda.Fill(dataTable);
                    excelCon.Close();
                    drvDrugs.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error uploading document: {ex.Message}", "PharmaZeal");
                MessageBox.Show($"Error uploading document: Contact your admin", "PharmaZeal");
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the rdBtnSingleEntry control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdBtnSingleEntry_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnSingleEntry.Checked)
            {
                panelSingleEntry.Visible = true;
                panelBulkEntry.Visible = false;
                btnGetFile.Visible = false;
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the rdBtnBulkEntry control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdBtnBulkEntry_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnBulkEntry.Checked)
            {
                panelSingleEntry.Visible = false;
                panelBulkEntry.Visible = true;
                btnGetFile.Visible = true;
            }
        }

        /// <summary>
        /// Handles the CellContentClick event of the dgvDrugsBulkEntry control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dgvDrugsBulkEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
