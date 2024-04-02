//using Microsoft.Office.Interop.Excel;
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
    public partial class StockManagementForm : Form
    {
        SqlConnection sqlConn;
        SqlCommand sqlCmd;
        SqlDataReader rdr;
        SqlTransaction sqlTransaction;
        public StockManagementForm()
        {
            InitializeComponent();
            sqlConn = AppConfig.sqlConn;
            GetDrugsData();

        }

        private void ImgClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GetDrugsData();
        }
        private void ConnectDB()
        {
            string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PharmaZeal; Integrated Security=True; ";
            sqlConn = new SqlConnection(connectionStr);
        }

        private void GetDrugsData()
        {

            DataSet custDs = new DataSet();
            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;

            try
            {
                string sqlQuery = "SELECT * FROM Stock";
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

                dataGridDrugs.AutoGenerateColumns = false;

                dataGridDrugs.DataSource = dataTable;


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

        private void StockManagementForm_Load(object sender, EventArgs e)
        {
            panelBulkEntry.Visible = false;
            panelSingleEntry.Visible = false;
            btnGetFile.Visible = false;
            //MessageBox.Show(chkBoxStoke.Checked.ToString(), "PharmaZeal");
            panelSingleEntry.Dock = DockStyle.Fill;
            panelBulkEntry.Dock = DockStyle.Fill;
        }

        private void txtSearchDrug_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource bindingSource = new();
                bindingSource.DataSource = dataGridDrugs.DataSource;
                bindingSource.Filter = "Name like '%" + txtDrugName.Text + "%'";
                dataGridDrugs.DataSource = bindingSource.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, contact your administrator", "PharmaZeal");
            }
        }



        private void dataGridDrugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            if (dataGridDrugs.Columns[e.ColumnIndex].Name == "Delete")
            {
                MessageBox.Show(dataGridDrugs.Rows[rowIndex].Cells[0].Value.ToString());
                if (MessageBox.Show("Confirm Delete", "PharmaZeal", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Delete Successful", "PharmaZeal");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImgSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed with transaction", "PharmaZeal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Operation canceled", "PharmaZeal");
                return;
            }
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
            try
            {
                sqlConn.Open();
                sqlTransaction = sqlConn.BeginTransaction();
                var QueryString = "";
                MessageBox.Show("Saving Record", "PharmaZeal");

                QueryString = "INSERT INTO PharmaDrugs " +
                            "(Name, Condition, IdCheck, InStoke, InTunstall, InFenton, InHanley, InLongton)" +
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
                            "(Name, Quantity, Expiry, UnitCost, ReorderPoint, MinStockLevel, DrugId)" +
                            "Values (@Name, @Quantity, @Expiry, @UnitCost, @ReorderPoint, @MinStockLevel, @DrugId)" +
                            "SELECT CAST(scope_identity() AS int)";



                    using var cmd = new SqlCommand(QueryString, sqlConn, sqlTransaction);

                    cmd.Parameters.AddWithValue("@Name", drugName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Expiry", expiryDate);
                    cmd.Parameters.AddWithValue("@UnitCost", unitCost);
                    cmd.Parameters.AddWithValue("@ReorderPoint", reorderLevel);
                    cmd.Parameters.AddWithValue("@MinStockLevel", minStockLevel);
                    cmd.Parameters.AddWithValue("@DrugId", drugId);



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

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

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

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string con = "Provider-Microsoft.ACE.OLEDB.12.0; Data Source={0};Extended Properties='Excel 8.0; HDR={1}'";
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
                dataGridDrugs.DataSource = dataTable;
            }
        }

        private void rdBtnSingleEntry_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnSingleEntry.Checked)
            {
                panelSingleEntry.Visible = true;
                panelBulkEntry.Visible = false;
                btnGetFile.Visible = false;
            }
        }

        private void rdBtnBulkEntry_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnBulkEntry.Checked)
            {
                panelSingleEntry.Visible = false;
                panelBulkEntry.Visible = true;
                btnGetFile.Visible = true;
            }
        }
    }
}
