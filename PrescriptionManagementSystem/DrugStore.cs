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
    public partial class DrugStoreForm : Form
    {
        SqlConnection sqlConn;
        SqlCommand sqlCmd;
        SqlDataReader rdr;
        bool editRecord = false;
        int customerId = 0;
        public DrugStoreForm()
        {
            InitializeComponent();
            ConnectDB();
            GetDrugStoreData();
        }

        private void ConnectDB()
        {
            string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PharmaZeal; Integrated Security=True; ";
            sqlConn = new SqlConnection(connectionStr);
        }
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
        private void DrugStoreForm_Load(object sender, EventArgs e)
        {

        }

        private void ImgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchDrugStore_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new();
            bindingSource.DataSource = dataGridDrugSet.DataSource;
            bindingSource.Filter = "Name like '%" + txtSearchDrugStore.Text + "%'";
            dataGridDrugSet.DataSource = bindingSource.DataSource;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
