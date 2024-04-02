using PrescriptionManagementSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrescriptionManagementSystem
{
    public static class AppConfig
    {
        public static SqlConnection sqlConn;
        static SqlCommand sqlCmd;
        static SqlDataReader rdr;
        public static string loggedInUserName = "";
        public static string loggedInUserStore = "";
        public static string customerFormSource = "";
        public static int loggedInUserId;
        public static int loggedInStoreId;
        public static bool loggedInUserIsAdmin;
        public static int customerId;
        public static int minimunStockLevel;
        public static List<Store> stores = new List<Store>();
        public static Store store;
        public static BindingSource bindingSource;

        static AppConfig()
        {
            sqlConn = new SqlConnection();
            sqlCmd = new SqlCommand();
            //rdr = new SqlDataReader(sqlConn);

        }
        public static void getDBConnection()
        {
            string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PharmaZeal; Integrated Security=True; ";
            sqlConn = new SqlConnection(connectionStr);
        }

        public static void getStoreDetails()
        {
            DataSet custDs = new DataSet();
            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;


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

                bindingSource = new BindingSource();
                bindingSource.DataSource = stores;
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

        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);
            return regex.IsMatch(emailAddress);
        }
    }
}
