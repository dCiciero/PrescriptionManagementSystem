using PrescriptionManagementSystem.Data.DTOs;
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
        static SqlDataReader sqldr;
        public static string loggedInUserName = "";
        public static string loggedInUserStore = "";
        public static string customerFormSource = "";
        public static int loggedInUserId;
        public static int loggedInStoreId;
        public static bool loggedInUserIsAdmin;
        public static int customerId;
        public static string customerName;
        public static int minimunStockLevel;
        public static List<Store> stores = new List<Store>();
        public static Store store;
        public static BindingSource bindingSource;
        public static List<SaleItemDTO> SalesItemDTOs { get; set; }

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

        private static void GetPharmaData()
        {

        }

        public static void GetDrugsData()
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


                sqlCmd = new SqlCommand(sqlQuery, sqlConn);
                //sqlCmd.Parameters.AddWithValue("@InStoke", AppConfig.loggedInStoreId);

                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                
                
                //dataTable = new DataTable("Drugs");
                //sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                //sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                //sqlDataAdapter.Fill(dataTable);
                SalesItemDTOs = new();
                sqldr = sqlCmd.ExecuteReader();
                while (sqldr.Read())
                {
                    SalesItemDTOs.Add(new SaleItemDTO
                    {
                        DrugId = (int)sqldr["DrugId"],
                        StockId = (int)sqldr["StockId"],
                        Quantity = (long)sqldr["Quantity"],
                        Name = sqldr["Name"].ToString(),
                        Condition = sqldr["Condition"].ToString(),
                        UnitCost = (decimal)sqldr["UnitCost"],
                        IdCheck = (bool)sqldr["IdCheck"],
                        InFenton = (bool)sqldr["InFenton"],
                        InHanley = (bool)sqldr["InHanley"],
                        InStoke = (bool)sqldr["InStoke"],
                        InLongton = (bool)sqldr["InLongton"],
                        InTunstall = (bool)sqldr["InTunstall"],

                    });
                }
                //dataGridDrugs.AutoGenerateColumns = false;

                //dataGridDrugs.DataSource = dataTable;


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
    }
}
