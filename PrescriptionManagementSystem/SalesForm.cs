// ***********************************************************************
// Assembly         : PrescriptionManagementSystem
// Author           : ogaga.ivhurie
// Created          : 04-09-2024
//
// Last Modified By : ogaga.ivhurie
// Last Modified On : 05-04-2024
// ***********************************************************************
// <copyright file="SalesForm.cs" company="PrescriptionManagementSystem">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using PrescriptionManagementSystem.Data.DTOs;
using PrescriptionManagementSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PrescriptionManagementSystem
{
    /// <summary>
    /// Class SalesForm.
    /// Implements the <see cref="Form" />
    /// </summary>
    /// <seealso cref="Form" />
    public partial class SalesForm : Form
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
        /// The list items
        /// </summary>
        string listItems = "";
        /// <summary>
        /// The total
        /// </summary>
        decimal total = 0;
        //string customerId;
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesForm"/> class.
        /// </summary>
        public SalesForm()
        {
            InitializeComponent();
            AppConfig.getDBConnection();
            sqlConn = AppConfig.sqlConn;
            GetDrugsData();
            lblCustomerId.Text = "";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesForm"/> class.
        /// </summary>
        /// <param name="custId">The customer identifier.</param>
        public SalesForm(string custId)
        {
            InitializeComponent();
            sqlConn = AppConfig.sqlConn;


        }

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>The customer identifier.</value>
        public string CustomerId
        {
            get { return lblCustomerId.Text; }
            set { lblCustomerId.Text = value; }
        }

        /// <summary>
        /// Handles the Load event of the SalesForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SalesForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        /// <summary>
        /// Forms the load.
        /// </summary>
        public void FormLoad()
        {
            dataGridDrugs.ScrollBars = ScrollBars.Both;
            dataGridDrugs.Columns["DrugName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridDrugs.Columns["Condition"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridDrugs.Columns["UnitCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridDrugs.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridDrugs.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            listItems = "{0, -5} | {1, -30} | {2, -7} | {3, -7}";
            lstBoxReceipt.Items.Add("--------------------------------------------------------");
            lstBoxReceipt.Items.Add(string.Format(listItems, "Qty", "Drug", "Unit Cost", "Price"));
            lstBoxReceipt.Items.Add("--------------------------------------------------------");


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
            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;

            try
            {
                string sqlQuery = "SELECT p.Id AS DrugId, p.[Name],p.[Condition], p.IdCheck, p.InStoke, p.InHanley, " +
                    "p.InFenton, p.InTunstall, p.InLongton, s.UnitCost, s.Quantity, s.Id AS StockId " +
                    "FROM PharmaDrugs p  JOIN Stock s ON p.Id =  s.DrugId"; // WHERE p.InStoke = @InStoke

                //string sqlQuery = "SELECT p.[Name],p.[Condition], p.IdCheck, p.Id AS DrugId, s.UnitCost, s.Quantity, s.Id AS StockId  " +
                //    "FROM PharmaDrugs p  JOIN Stock s ON p.Id =  s.DrugId WHERE p.InStoke=1";


                //sqlCmd = new SqlCommand(sqlQuery, sqlConn);
                //sqlCmd.Parameters.AddWithValue("@InStoke", AppConfig.loggedInStoreId);

                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                dataTable = new DataTable("Drugs");
                //sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                sqlDataAdapter.Fill(dataTable);

                dataGridDrugs.AutoGenerateColumns = false;

                dataGridDrugs.DataSource = dataTable;



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
        /// Handles the TextChanged event of the txtSearchDrug control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtSearchDrug_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new();
            bindingSource.DataSource = dataGridDrugs.DataSource;
            bindingSource.Filter = "Name like '%" + txtSearchDrug.Text + "%'";
            dataGridDrugs.DataSource = bindingSource.DataSource;
            //lblCustomerId.Text = txtSearchDrug.Text;
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
        /// Handles the DataBindingComplete event of the dataGridDrugs control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewBindingCompleteEventArgs"/> instance containing the event data.</param>
        private void dataGridDrugs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var rowCount = dataGridDrugs.Rows.Count;
            if (rowCount > 0)
            {
                //MessageBox.Show(rowCount.ToString(), "PharmaZeal");
                foreach (DataGridViewRow rowItem in dataGridDrugs.Rows)
                {
                    //dataGridDrugs.Rows[rowItem.Index].HeaderCell.Value = (rowItem.Index + 1).ToString();
                    //MessageBox.Show($"Yes: {rowItem.Cells["Stoke"].Value.ToString()}");
                    if ((bool)rowItem.Cells[$"{AppConfig.loggedInUserStore}"].Value == false)
                    {
                        dataGridDrugs.Rows[rowItem.Index].DefaultCellStyle.ForeColor = Color.Red;
                        dataGridDrugs.Rows[rowItem.Index].DefaultCellStyle.SelectionBackColor = Color.AntiqueWhite;
                        dataGridDrugs.Rows[rowItem.Index].DefaultCellStyle.SelectionForeColor = Color.Red;
                        //MessageBox.Show("Yes");
                        //dataGridDrugs.Rows[rowItem.Index].DefaultCellStyle.ForeColor = Color.Red;
                        //dataGridDrugs.Rows[rowItem.Index].DefaultCellStyle.BackColor = Color.Gainsboro;
                        //dataGridDrugs.Rows[rowItem.Index].DefaultCellStyle.SelectionBackColor = Color.AntiqueWhite;
                        //dataGridDrugs.Rows[rowItem.Index].DefaultCellStyle.SelectionForeColor = Color.Red;
                    }

                    //rowItem.Cells["Quantity"].ReadOnly = false;
                    //rowItem.Cells["Quantity"].Value = "0.00";
                    //dataGridCustomer.Rows[rowItem.Index].Cells["sn"].Value = (rowItem.Index + 1).ToString();
                }
            }
        }

        /// <summary>
        /// Handles the CellValueChanged event of the dataGridDrugs control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridDrugs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            //MessageBox.Show(e.RowIndex.ToString(), "PharmaZeal Cell Change");
            try
            {
                if (e.RowIndex > -1)
                {
                    //MessageBox.Show(e.RowIndex.ToString(), "PharmaZeal Cell Change");
                    var rowItem = dataGridDrugs.Rows[e.RowIndex];
                    if (e.ColumnIndex == 10) // Checking if the column is the right one (Quantity)
                    {
                        //This prevents the sale of item not available in current store
                        if ((bool)rowItem.Cells[$"{AppConfig.loggedInUserStore}"].Value == false)
                        {

                            rowItem.Cells["Quantity"].Value = "";

                            dataGridDrugs.CancelEdit();
                            MessageBox.Show("This item is not available in this store", "PharmaZeal");
                            return;
                        }
                        if (!string.IsNullOrEmpty(rowItem.Cells["Quantity"].Value?.ToString().Trim()))
                        {
                            int qty2Buy;
                            int qtyAvailable;
                            bool isNumeric;
                            isNumeric = int.TryParse(rowItem.Cells["Quantity"].Value?.ToString().Trim(), out qty2Buy);
                            int.TryParse(rowItem.Cells["AvailableQty"].Value?.ToString(), out qtyAvailable);

                            if (qty2Buy > AppConfig.maxSellingQty)
                            {
                                MessageBox.Show($"Maximum allowable quantity to sell is {AppConfig.maxSellingQty}", "PharmaZeal");
                                rowItem.Cells["Quantity"].Value = "";
                                rowItem.Cells["Quantity"].Selected = true;
                                return;
                            }

                            if (qtyAvailable < qty2Buy)
                            {
                                MessageBox.Show("Quantity to buy exceed available stock quantity", "PharmaZeal");
                                rowItem.Cells["Quantity"].Value = "";
                                rowItem.Cells["Quantity"].Selected = true;
                                return;
                            }
                            if (!isNumeric)
                            {
                                MessageBox.Show("Enter integer value", "PharmaZeal");
                                rowItem.Cells["Quantity"].Value = "0";
                                rowItem.Cells["Quantity"].Selected = true;
                                return;
                            }
                            var currentVaaue = qty2Buy;

                            var currentPrice = rowItem.Cells["Price"].Value?.ToString() != null ? rowItem.Cells["Price"].Value : "0";

                            if (qty2Buy == 0)
                            {
                                //rowItem.Cells["Price"].Value = qty2Buy * Convert.ToDecimal(rowItem.Cells["UnitCOst"].Value?.ToString().Trim());
                                total -= Convert.ToDecimal(rowItem.Cells["Price"].Value?.ToString());
                                txtTotalPayable.Text = total.ToString();
                                rowItem.Cells["Price"].Value = "";
                                return;
                            }


                            rowItem.Cells["Price"].Value = qty2Buy * Convert.ToDecimal(rowItem.Cells["UnitCOst"].Value?.ToString().Trim());
                            rowItem.Cells["chkAddToList"].ReadOnly = false;
                            total += Convert.ToDecimal(rowItem.Cells["Price"].Value?.ToString());
                            txtTotalPayable.Text = total.ToString();

                            //MessageBox.Show($"Lost Focus: {qtyAvailable}", "PharmaZeal",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (rowItem.Cells["Price"].Value?.ToString() != null)
                            {
                                total -= Convert.ToDecimal(rowItem.Cells["Price"].Value?.ToString());
                                txtTotalPayable.Text = total.ToString();
                                rowItem.Cells["Price"].Value = "";
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "PharmaZeal");
            }




        }



        /// <summary>
        /// Handles the CellClick event of the dataGridDrugs control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridDrugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString(), "PharmaZeal Cell Change");
            //var rowItem = dataGridDrugs.Rows[e.RowIndex];

            ////rowItem.HeaderCell.Value.ToString();
            ////if (e.ColumnIndex[])

            //if (e.ColumnIndex == 5)
            //{
            //    DataGridViewCheckBoxCell chkchecking = rowItem.Cells["chkAddToList"] as DataGridViewCheckBoxCell;
            //    MessageBox.Show(Convert.ToBoolean(chkchecking.Value).ToString(), "PharmaZeal Cell Change");
            //}
            //if ((CheckBox)rowItem.Cells["chkAddToList"].Value == true)
            //{
            //}
        }

        /// <summary>
        /// Handles the CellContentClick event of the dataGridDrugs control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridDrugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 12)
            {
                var rowItem = dataGridDrugs.Rows[e.RowIndex];
                //if (rowItem.Cells["Quantity"].Value == DBNull.Value || (string.IsNullOrEmpty(rowItem.Cells["Quantity"].Value.ToString().Trim())) || rowItem.Cells["Quantity"].Value.ToString().Trim()==null)
                if (string.IsNullOrEmpty(rowItem.Cells["Quantity"].Value?.ToString().Trim()) || rowItem.Cells["Quantity"].Value?.ToString() == "0")
                {
                    MessageBox.Show("Enter Quantity", "PharmaZeal");
                    dataGridDrugs.CancelEdit();
                    return;
                }

                //rowItem.Cells["chkAddToList"]
                DataGridViewCheckBoxCell chkchecking = rowItem.Cells["chkAddToList"] as DataGridViewCheckBoxCell;
                dataGridDrugs.EndEdit();
                //MessageBox.Show(Convert.ToBoolean(chkchecking.Value).ToString(), "PharmaZeal Cell Change");
                var drugName = rowItem.Cells["drugName"].Value.ToString().Trim().Length < 30 ? rowItem.Cells["drugName"].Value.ToString().Trim() : rowItem.Cells["drugName"].Value.ToString().Trim().Substring(0, 30);
                var price = rowItem.Cells["Price"].Value.ToString().Trim();
                var quantity = rowItem.Cells["Quantity"].Value.ToString().Trim();
                var unitCost = rowItem.Cells["UnitCost"].Value.ToString().Trim();
                var item = string.Format(listItems, quantity, drugName, unitCost, price); // $"{quantity} {drugName} -------- {unitCost} ------- {price}";
                ListViewItem lvi = new();
                lvi.Text = quantity;
                lvi.SubItems.Add(drugName);
                lvi.SubItems.Add(unitCost);
                if (Convert.ToBoolean(chkchecking.Value) == true)
                {
                    //lstBoxReceipt.Items.Add(item);
                    lstBoxReceipt.Items.Add(item);
                    //lstViewReceipt.Items.Add(lvi);
                }
                else
                {
                    lstBoxReceipt.Items.Remove(item);
                    //lstViewReceipt.Items.Remove(lvi);

                }

            }
        }

        /// <summary>
        /// Handles the CellStateChanged event of the dataGridDrugs control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellStateChangedEventArgs"/> instance containing the event data.</param>
        private void dataGridDrugs_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

            //MessageBox.Show(e.Cell.ColumnIndex.ToString());
            //if (e.Cell.ColumnIndex == 5)
            //{
            //    var rowItem = dataGridDrugs.Rows[e.Cell.RowIndex];
            //    MessageBox.Show(rowItem.ToString());
            //    return;
            //    //var rowItem = dataGridDrugs.Columns[e.Cell.RowIndex];
            //    //rowItem.Cells["chkAddToList"]
            //    DataGridViewCheckBoxCell chkchecking = rowItem.Cells["chkAddToList"] as DataGridViewCheckBoxCell;
            //    if (Convert.ToBoolean(chkchecking.Value) == true)
            //    {
            //        lstBoxReceipt.Items.Add("ABCDEF");
            //    }

            //    MessageBox.Show(Convert.ToBoolean(chkchecking.Value).ToString(), "PharmaZeal Cell Change");
            //}
        }

        /// <summary>
        /// Handles the CellLeave event of the dataGridDrugs control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridDrugs_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show($"Lost Focus: {e.ColumnIndex}", "PharmaZeal");
            //var rowItem = dataGridDrugs.Rows[e.RowIndex];
            if (e.ColumnIndex == 3)
            {
                //var sumTotal = Convert.ToDecimal(txtTotalPayable.Text);
                //rowItem.Cells["Price"].Value = Convert.ToDecimal(rowItem.Cells["Quantity"].Value.ToString().Trim()) * Convert.ToDecimal(rowItem.Cells["UnitCOst"].Value.ToString().Trim());
                //rowItem.Cells["chkAddToList"].ReadOnly = false;

                //var qty2Buy = Convert.ToInt32(rowItem.Cells["Quantity"].Value.ToString().Trim());
                //var qtyAvailable = Convert.ToInt32(rowItem.Cells["AvailableQty"].Value);
                //if (qtyAvailable < qty2Buy)
                //{
                //    MessageBox.Show("Quantity to buy exceed available stock quantity", "PharmaZeal");
                //    return;
                //}
                //MessageBox.Show($"Lost Focus: {qtyAvailable}", "PharmaZeal");

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
        /// Handles the Click event of the btnGenerateReceipt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            var saleDate = DateTime.UtcNow;
            var saleAmount = txtTotalPayable.Text;
            var tax = txtTotalPayable.Text;
            var userId = AppConfig.loggedInUserId;
            var customerId = AppConfig.customerId;
            var rowItem = dataGridDrugs.Rows.Count;

            if (Convert.ToDecimal(saleAmount) == 0.00M)
            {
                MessageBox.Show("Enter quantity of drugs to buy", "PharmaZeal");
                return;
            }

            if (MessageBox.Show("Proceed with transaction", "PharmaZeal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Operation canceled", "PharmaZeal");
                return;
            }




            List<string> items = new List<string>();
            List<SaleItemDTO> saleItemDTOs = new List<SaleItemDTO>();
            SaleItemDTO saleItemDTO;
            //MessageBox.Show($"{rowItem}", "PharmaZeal");


            SaveSales(saleDate, Convert.ToDecimal(saleAmount), 0.00M, AppConfig.loggedInUserId, AppConfig.customerId); ;

        }

        /// <summary>
        /// Handles the CellDoubleClick event of the dataGridDrugs control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridDrugs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var rowItem = dataGridDrugs.Rows[e.RowIndex];
            //var checkId = rowItem.Cells["IdCheck"].Value?.ToString();
            //if (Convert.ToBoolean(checkId) == true)
            //{
            //    MessageBox.Show($"This drugs requires Id check", "PharmaZeal");
            //}
        }

        /// <summary>
        /// Saves the sales.
        /// </summary>
        /// <param name="salesDate">The sales date.</param>
        /// <param name="amount">The amount.</param>
        /// <param name="tax">The tax.</param>
        /// <param name="usedId">The used identifier.</param>
        /// <param name="customerId">The customer identifier.</param>
        private void SaveSales(DateTime salesDate, decimal amount, decimal tax, int usedId, int? customerId)
        {
            try
            {
                sqlConn.Open();
                sqlTransaction = sqlConn.BeginTransaction();
                var QueryString = "";
                customerId = customerId == 0 ? null : customerId;
                MessageBox.Show("Saving Record", "PharmaZeal");
                QueryString = "INSERT INTO Sales " +
                            "(DateSold, AmountPaid, Tax_percentage, UserId, CustomerId)" +
                            "Values (@DateSold, @Amount, @Tax, @UserId, @CustomerId)" +
                            "SELECT CAST(scope_identity() AS int)";



                using var cmd = new SqlCommand(QueryString, sqlConn, sqlTransaction);

                cmd.Parameters.AddWithValue("@DateSold", salesDate);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Tax", tax);
                cmd.Parameters.AddWithValue("@UserId", usedId);
                cmd.Parameters.AddWithValue("@CustomerId", (object)customerId ?? DBNull.Value);



                int newSaleId = Convert.ToInt32(cmd.ExecuteScalar());
                //int successInsert = cmd.ExecuteNonQuery();

                if (newSaleId > 0)
                {

                    var status = SaveSalesItems(newSaleId);
                    if (status == 0)
                    {
                        sqlTransaction.Rollback();
                        MessageBox.Show("Record not saved", "PharmaZeal");
                    }
                    else
                    {
                        sqlTransaction.Commit();
                        MessageBox.Show("Process Completed", "PharmaZeal");
                        GetDrugsData();
                        txtAmountPaid.Text = "0.00";
                        txtTotalPayable.Text = "0.00";
                        lstBoxReceipt.Items.Clear();
                        lblBalance.Text = "0.00";
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
        /// Saves the sales items.
        /// </summary>
        /// <param name="saleId">The sale identifier.</param>
        /// <returns>System.Int32.</returns>
        private int SaveSalesItems(int saleId)
        {
            try
            {
                List<string> items = new List<string>();
                List<SaleItemDTO> saleItemDTOs = new List<SaleItemDTO>();
                SaleItemDTO saleItemDTO;
                string sqlQuery = "";
                bool isAddToListChecked = false;

                foreach (DataGridViewRow gridRow in dataGridDrugs.Rows)
                {

                    if (Convert.ToBoolean(gridRow.Cells["chkAddToList"].Value?.ToString()) == true)
                    {
                        isAddToListChecked = true;
                        var qty2Buy = Convert.ToInt32(gridRow.Cells["Quantity"].Value.ToString().Trim());
                        var qtyAvailable = Convert.ToInt32(gridRow.Cells["AvailableQty"].Value);
                        items.Add(gridRow.Cells["DrugName"].Value?.ToString());
                        sqlQuery = "INSERT INTO SalesItem (QtySold, UnitCost, TotalAmount, SaleId, DrugId)" +
                            " VALUES (@Qty, @UnitCost, @Amount, @SaleId, @DrugId)";
                        using var cmd = new SqlCommand(sqlQuery, sqlConn, sqlTransaction);

                        cmd.Parameters.AddWithValue("@Qty", qty2Buy);
                        cmd.Parameters.AddWithValue("@UnitCost", Convert.ToDecimal(gridRow.Cells["UnitCost"].Value));
                        cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(gridRow.Cells["Price"].Value));
                        cmd.Parameters.AddWithValue("@SaleId", saleId);
                        cmd.Parameters.AddWithValue("@DrugId", Convert.ToInt32(gridRow.Cells["DrugId"].Value));

                        int res = cmd.ExecuteNonQuery();

                        sqlQuery = "UPDATE Stock SET Quantity=@Quantity WHERE Id=@Id";
                        using var cmd2 = new SqlCommand(sqlQuery, sqlConn, sqlTransaction);
                        cmd2.Parameters.AddWithValue("@Id", Convert.ToInt32(gridRow.Cells["StockId"].Value));
                        cmd2.Parameters.AddWithValue("@Quantity", (qtyAvailable - qty2Buy));

                        int res2 = cmd2.ExecuteNonQuery();

                        //saleItemDTO = new SaleItemDTO
                        //{
                        //    Quantity = Convert.ToInt32(gridRow.Cells["Quantity"].Value),
                        //    UnitCost = Convert.ToDecimal(gridRow.Cells["UnitCost"].Value),
                        //    Price = Convert.ToDecimal(gridRow.Cells["Price"].Value),
                        //    SaleId = saleId,
                        //    DrugId = Convert.ToInt32(gridRow.Cells["Id"].Value),
                        //};

                    }
                }
                if (!isAddToListChecked)
                {
                    MessageBox.Show("Select drugs before proceeding", "PharmaZeal");
                    return 0;
                }
                else
                    return 1;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnReceipt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            dataGridDrugs.Refresh();
        }

        /// <summary>
        /// Handles the TextChanged event of the textBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (txtTotalPayable.Text == "0.00")
            {
                MessageBox.Show("No item has been selected", "PharmaZeal");
                txtAmountPaid.Text = "0.00";
                return;
            }
            if (txtAmountPaid.Text != "" || !string.IsNullOrEmpty(txtAmountPaid.Text))
            {
                var amountPayable = Convert.ToDouble(txtTotalPayable.Text.Trim());
                var paidAmount = amountPayable - Convert.ToDouble(txtAmountPaid.Text.Trim());
                lblBalance.Text = paidAmount.ToString();
            }
            else
            {
                lblBalance.Text = "0.00";
            }

        }

        /// <summary>
        /// Handles the Click event of the btnSearchCustomer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            //this.Hide();
            lblCustomerId.Text = "Searching customer";
            //CustomerSearchForm customerSearchForm = new CustomerSearchForm("sales");
            CustomerSearchForm customerSearchForm = new CustomerSearchForm(this);
            customerSearchForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
            //this.UpdateCustomerId("Felas");
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

