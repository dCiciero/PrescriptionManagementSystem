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
    public partial class CustomerSearchForm : Form
    {
        SqlConnection sqlConn;
        SqlCommand sqlCmd;
        SqlDataReader rdr;
        public int customerId;
        public CustomerSearchForm()
        {
            InitializeComponent();
            AppConfig.getDBConnection();
            sqlConn = AppConfig.sqlConn;
            //ConnectDB();
            GetCustomers();
        }
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

        private void ImgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConnectDB()
        {
            string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PharmaZeal; Integrated Security=True; ";
            sqlConn = new SqlConnection(connectionStr);
        }

        private void GetCustomers()
        {

            DataSet custDs = new DataSet();
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

                dataGridCustomer.AutoGenerateColumns = false;

                dataGridCustomer.DataSource = dataTable;


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

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            //var bd = (BindingSource)dataGridCustomer.DataSource;
            //var dt = (DataTable)bd.DataSource;
            //dt.DefaultView.RowFilter = string.Format("LibService like '%{0}%'", txtSearchCustomer.Text.Trim().Replace("'", "''"));
            //dataGridCustomer.Refresh();
            BindingSource bindingSource = new();
            bindingSource.DataSource = dataGridCustomer.DataSource;
            bindingSource.Filter = "FirstName like '%" + txtSearchCustomer.Text + "%'";
            dataGridCustomer.DataSource = bindingSource.DataSource;
        }

        private void dataGridCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var rowCount = dataGridCustomer.Rows.Count;
            if (rowCount > 0)
            {
                foreach (DataGridViewRow row in dataGridCustomer.Rows)
                {
                    //vulnerable.ToString().Trim()) || vulnerable != DBNull.Value
                    var vulnerable = row.Cells["Vulnerable"].Value;

                    if (!string.IsNullOrEmpty(vulnerable.ToString().Trim()) || vulnerable != DBNull.Value)
                    {
                        if ((bool)vulnerable == true)
                        {
                            //MessageBox.Show(vulnerable.ToString(), "PharmaZeal OnBinding");
                            dataGridCustomer.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Red;
                            dataGridCustomer.Rows[row.Index].DefaultCellStyle.SelectionBackColor = Color.AntiqueWhite;
                            dataGridCustomer.Rows[row.Index].DefaultCellStyle.SelectionForeColor = Color.Red;
                        }
                    }
                    //if (vulnerable == true)
                }
            }
        }

        private void dataGridCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = dataGridCustomer.Rows[e.RowIndex].Index;
            customerId = (int)dataGridCustomer.Rows[rowIndex].Cells["Id"].Value;
            //MessageBox.Show(customerId.ToString(), "PharmaZeal");
            //var customerName = dataGridCustomer.Rows[rowIndex].Cells["FirstName"].Value.ToString() + " " + dataGridCustomer.Rows[rowIndex].Cells["OtherName"].Value.ToString() + " " + dataGridCustomer.Rows[rowIndex].Cells["LastName"].Value.ToString();
            //CustomerHistory customerHistory = new CustomerHistory(customerName);
            //this.Hide();
            //customerHistory.ShowDialog();
            panelPrescriptionHistory.Visible = true;
            //panelHistory.Visible = true;
            this.Height = 926;
            dataGridCustomer.Enabled = false;
            dataGridCustomer.ReadOnly = true;
            //dataGridCustomer.ForeColor = Color.Black;
            //dataGridCustomer.ClearSelection();
        }

        private void CustomerSearchForm_Load(object sender, EventArgs e)
        {
            panelPrescriptionHistory.Visible = false;

            //panelHistory.Visible = false;
            this.Height = 626;
        }

        private void btnHideHistory_Click(object sender, EventArgs e)
        {
            panelPrescriptionHistory.Visible = false;
            dataGridCustomer.Enabled = true;
            dataGridCustomer.ReadOnly = false;
            AppConfig.customerId = 0;
            this.Height = 626;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustSale_Click(object sender, EventArgs e)
        {
            this.Close();
            AppConfig.customerId = customerId;
            SalesForm salesForm = new SalesForm(AppConfig.customerId);
            salesForm.FormLoad();
            //salesForm.Invalidate();
            //salesForm.Refresh();
            //salesForm.Close();
            //salesForm.ShowDialog();
        }
    }
}
