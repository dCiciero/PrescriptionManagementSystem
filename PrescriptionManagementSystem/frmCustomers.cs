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

namespace PrescriptionManagementSystem
{
    public partial class frmCustomers : Form
    {
        SqlConnection sqlConn;
        SqlCommand sqlCmd;
        SqlDataReader rdr;
        bool editRecord = false;
        int customerId = 0;
        public frmCustomers()
        {
            InitializeComponent();
            AppConfig.getDBConnection();
            sqlConn = AppConfig.sqlConn;
            ImgClose.Visible = false;
            //ConnectDB();
            GetCustomers();
        }

        private void ConnectDB()
        {
            string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PharmaZeal; Integrated Security=True; ";
            sqlConn = new SqlConnection(connectionStr);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirm Save");
        }

        private void ImgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            //GetCustomers();
        }

        private void GetCustomers()
        {

            //string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PharmaZeal; Integrated Security=True; ";
            DataSet custDs = new DataSet();
            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;


            try
            {
                //conn = new SqlConnection(connectionStr);
                //cmd = new SqlCommand("SELECT * FROM Customer");
                string sqlQuery = "SELECT * FROM Customer WHERE IsDeleted != 1 or IsDeleted IS NULL";
                string sqlQuery2 = "SELECT FirstName+' '+OtherName+' '+LastName AS [Full Name], HouseNo AS [House No], " +
                    "StreetName AS [Street Name], PostCode AS [Post Code], City, County, Country, " +
                    " DateOfBirth as [Date of Birth], Vulnerable FROM Customer";
                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
                sqlConn.Open();
                //MessageBox.Show("Connected to DB", "PharnaZeal");
                //sqlCmd = new SqlCommand("SELECT * FROM Customer", sqlConn);
                dataTable = new DataTable("Customers");
                sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                sqlDataAdapter.Fill(dataTable);
                //dataGridCust.DataSource = dataTable;
                //dataGridCustomer.VirtualMode = dataGridCustomer.Visible = true; 
                //dataGridCustomer.VirtualMode = true;
                dataGridCustomer.AutoGenerateColumns = false;
                //dataGridCustomer.Update();
                //dataTable = new DataTable("Customers");
                //sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                //sqlDataAdapter.Fill(dataTable);
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

        private void ImgSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string otherName = txtOtherName.Text;
            string surname = txtSurname.Text;
            string houseNo = txtHouseNo.Text;
            string streetName = txtStreet.Text;
            string postCode = txtPostCode.Text;
            string city = txtCIty.Text;
            string county = txtCounty.Text;
            string phone = txtPhone.Text;
            DateTime dob = Convert.ToDateTime(dtpDateOfBirth.Text);
            string country = "United Kingdom";
            bool vulnerable = rdBtnYes.Checked ? true : false;


            try
            {
                sqlConn.Open();
                var QueryString = "";
                if (editRecord)
                {
                    MessageBox.Show("Editing Record", "PharmaZeal");
                    QueryString = "UPDATE Customer " +
                                " SET FirstName = @FirstName, LastName=@LastName, OtherName=@OtherName, HouseNo=@HouseNo," +
                                " StreetName=@StreetName, PostCode=@PostCode, City=@City, County=@County, Country=@Country," +
                                " DateOfBirth=@DateOfBirth, Vulnerable=@Vulnerable WHERE Id=@Id";
                }
                else
                {
                    MessageBox.Show("Saving Record", "PharmaZeal");
                    QueryString = "INSERT INTO Customer " +
                                "(FirstName, LastName, OtherName, HouseNo, StreetName, PostCode, City, County, Country, DateOfBirth, Vulnerable)" +
                                "Values (@FirstName, @LastName, @OtherName, @HouseNo, @StreetName, @PostCode, @City, @County, @Country, @DateOfBirth, @Vulnerable)";
                }


                using (var cmd = new SqlCommand(QueryString, sqlConn))
                {
                    if (editRecord)
                        cmd.Parameters.AddWithValue("@Id", customerId);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", surname);
                    cmd.Parameters.AddWithValue("@OtherName", otherName);
                    cmd.Parameters.AddWithValue("@HouseNo", houseNo);
                    cmd.Parameters.AddWithValue("@StreetName", streetName);
                    cmd.Parameters.AddWithValue("@PostCode", postCode);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@County", county);
                    cmd.Parameters.AddWithValue("@Country", country);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                    cmd.Parameters.AddWithValue("@Vulnerable", vulnerable);


                    int successInsert = cmd.ExecuteNonQuery();
                    if (successInsert > 0)
                    {
                        if (editRecord)
                            MessageBox.Show("Update Successful", "PharmaZeal");
                        else
                            MessageBox.Show("Insert Successful", "PharmaZeal");

                        GetCustomers();

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
            txtFirstName.Text = "";
            txtOtherName.Text = "";
            txtSurname.Text = "";
            txtHouseNo.Text = "";
            txtStreet.Text = "";
            txtPostCode.Text = "";
            txtCIty.Text = "";
            txtCounty.Text = "";
            txtPhone.Text = "";
            dtpDateOfBirth.ResetText();
            rdBtnYes.Checked = false;
            rdBtnNo.Checked = false;
        }


        private void dataGridCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editRecord = true;
            var rowIndex = dataGridCustomer.Rows[e.RowIndex].Index;
            customerId = (int)dataGridCustomer.Rows[rowIndex].Cells["Id"].Value;
            //MessageBox.Show("ID is: "+customerId.ToString(), "PharmaZeal");
            //MessageBox.Show(rowIndex.ToString(), "PharmaZeal");
            txtFirstName.Text = dataGridCustomer.Rows[rowIndex].Cells[0].Value.ToString();
            txtOtherName.Text = dataGridCustomer.Rows[rowIndex].Cells[1].Value.ToString();
            txtSurname.Text = dataGridCustomer.Rows[rowIndex].Cells[2].Value.ToString();
            dtpDateOfBirth.Text = dataGridCustomer.Rows[rowIndex].Cells[3].Value.ToString();
            txtHouseNo.Text = dataGridCustomer.Rows[rowIndex].Cells[4].Value.ToString();
            txtStreet.Text = dataGridCustomer.Rows[rowIndex].Cells[5].Value.ToString();
            txtPostCode.Text = dataGridCustomer.Rows[rowIndex].Cells[6].Value.ToString();
            txtCIty.Text = dataGridCustomer.Rows[rowIndex].Cells[7].Value.ToString();
            txtCounty.Text = dataGridCustomer.Rows[rowIndex].Cells[8].Value.ToString();
            txtPhone.Text = "";
            var vulnerable = dataGridCustomer.Rows[rowIndex].Cells[10].Value;
            //MessageBox.Show(dataGridCustomer.Rows[rowIndex].Cells[10].Value.ToString());
            if (!string.IsNullOrEmpty(vulnerable.ToString().Trim()) || vulnerable != DBNull.Value)
            {
                if ((bool)dataGridCustomer.Rows[rowIndex].Cells[10].Value == true)
                {
                    rdBtnYes.Checked = true;
                    rdBtnNo.Checked = false;
                }
                else
                {
                    rdBtnNo.Checked = true;
                    rdBtnYes.Checked = false;
                }
            }
            else
            {
                rdBtnNo.Checked = false;
                rdBtnYes.Checked = false;
            }


            //txtCountry.Text = dataGridCustomer.Rows[rowIndex].Cells[9].Value.ToString();

        }

        private void dataGridCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //var rowCount = dataGridCustomer.Rows.Count;
            //if (rowCount > 0)
            //{
            //    MessageBox.Show(rowCount.ToString(), "PharmaZeal");
            //    foreach (DataGridViewRow rowItem in dataGridCustomer.Rows)
            //    {
            //        dataGridCustomer.Rows[rowItem.Index].HeaderCell.Value = (rowItem.Index + 1).ToString();
            //        rowItem.Cells["rn"].Value = (rowItem.Index + 1).ToString();
            //        //dataGridCustomer.Rows[rowItem.Index].Cells["sn"].Value = (rowItem.Index + 1).ToString();
            //    }
            //}
        }

        private void dataGridCustomer_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //this.dataGridCustomer.Rows[e.RowIndex].Cells["sn"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (editRecord == true)
                editRecord = false;
            ClearFields();
        }

        private void dataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            customerId = Convert.ToInt32(dataGridCustomer.Rows[rowIndex].Cells["Id"].Value);
            if (dataGridCustomer.Columns[e.ColumnIndex].Name == "Delete")
            {

                if (MessageBox.Show($"Confirm delete of this record?", "PharmaZeal", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //MessageBox.Show("Delete Successful", "PharmaZeal");
                    var QueryString = "";
                    QueryString = "UPDATE FROM Customer SET IsDeleted = @isDeleted " +
                                " WHERE Id=@Id";


                    if (sqlConn.State == ConnectionState.Open)
                        sqlConn.Close();

                    sqlConn.Open();
                    using (var cmd = new SqlCommand(QueryString, sqlConn))
                    {

                        cmd.Parameters.AddWithValue("@Id", customerId);
                        cmd.Parameters.AddWithValue("@isDeleted", true);



                        int successInsert = cmd.ExecuteNonQuery();
                        if (successInsert > 0)
                        {
                            MessageBox.Show("Delete Successful", "PharmaZeal");


                            GetCustomers();

                            //ClearFields();
                        }
                        else
                            MessageBox.Show("Delete Not Successful", "PharmaZeal");
                    };
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
