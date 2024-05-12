// ***********************************************************************
// Assembly         : PrescriptionManagementSystem
// Author           : ogaga.ivhurie
// Created          : 04-12-2024
//
// Last Modified By : ogaga.ivhurie
// Last Modified On : 05-12-2024
// ***********************************************************************
// <copyright file="AppConfig.cs" company="PrescriptionManagementSystem">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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
    /// <summary>
    /// Class AppConfig.
    /// </summary>
    public static class AppConfig
    {
        /// <summary>
        /// The SQL connection
        /// </summary>
        public static SqlConnection sqlConn;
        /// <summary>
        /// The SQL command
        /// </summary>
        static SqlCommand sqlCmd;
        /// <summary>
        /// The SQLDR
        /// </summary>
        static SqlDataReader sqldr;
        /// <summary>
        /// The logged in user name
        /// </summary>
        public static string loggedInUserName = "";
        /// <summary>
        /// The logged in user store
        /// </summary>
        public static string loggedInUserStore = "";
        /// <summary>
        /// The customer form source
        /// </summary>
        public static string customerFormSource = "";
        /// <summary>
        /// The logged in user identifier
        /// </summary>
        public static int loggedInUserId;
        /// <summary>
        /// The logged in store identifier
        /// </summary>
        public static int loggedInStoreId;
        /// <summary>
        /// The maximum selling qty
        /// </summary>
        public static int maxSellingQty=10;
        /// <summary>
        /// The logged in user is admin
        /// </summary>
        public static bool loggedInUserIsAdmin;

        /// <summary>
        /// This variable is used to check id there are minimum stsock
        /// </summary>
        public static bool isMinimumStockAvailable = false;
        /// <summary>
        /// The customer identifier
        /// </summary>
        public static int customerId;
        /// <summary>
        /// The customer name
        /// </summary>
        public static string customerName;
        /// <summary>
        /// The minimun stock level
        /// </summary>
        public static int minimunStockLevel=0;
        /// <summary>
        /// The stores
        /// </summary>
        public static List<Store> stores = new List<Store>();
        /// <summary>
        /// The store
        /// </summary>
        public static Store store;
        /// <summary>
        /// The stock typess
        /// </summary>
        public static List<StockType> stockTypess = new List<StockType>();
        /// <summary>
        /// The stock type
        /// </summary>
        public static StockType stockType;
        /// <summary>
        /// The binding source
        /// </summary>
        public static BindingSource bindingSource;
        /// <summary>
        /// The stock type binding source
        /// </summary>
        public static BindingSource stockTypeBindingSource;
        /// <summary>
        /// The system data
        /// </summary>
        public static SystemData systemData;
        /// <summary>
        /// Gets or sets the sales item dt os.
        /// </summary>
        /// <value>The sales item dt os.</value>
        public static List<SaleItemDTO> SalesItemDTOs { get; set; }

        /// <summary>
        /// Initializes static members of the <see cref="AppConfig"/> class.
        /// </summary>
        static AppConfig()
        {
            sqlConn = new SqlConnection();
            sqlCmd = new SqlCommand();
            //rdr = new SqlDataReader(sqlConn);

        }
        /// <summary>
        /// Gets the database connection.
        /// </summary>
        public static void getDBConnection()
        {
            string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PharmaZeal; User id=pharma_user; password=test123@; MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30; ";
            sqlConn = new SqlConnection(connectionStr);
        }

        /// <summary>
        /// Gets the store details.
        /// </summary>
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


        /// <summary>
        /// Gets the stock types.
        /// </summary>
        public static void getStockTypes()
        {
            DataSet custDs = new DataSet();
            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;


            try
            {
                string sqlQuery = "SELECT * FROM StockType WHERE IsDeleted != 1";

                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
                sqlConn.Open();
                
                using (var cmd = new SqlCommand(sqlQuery, sqlConn))
                {
                    var reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        stockType = new StockType
                        {
                            Id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                        };
                        stockTypess.Add(stockType);


                    }
                }

                stockTypeBindingSource = new BindingSource();
                stockTypeBindingSource.DataSource = stockTypess;
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

        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);
            return regex.IsMatch(emailAddress);
        }

        /// <summary>
        /// Gets the systema data.
        /// </summary>
        public static void getSystemaData()
        {
            try
            {
                
                string sqlQuery = "SELECT * FROM SystemTable";

                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
                sqlConn.Open();
                //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
                //MessageBox.Show("Connected to DB", "PharnaZeal");
                sqlCmd = new SqlCommand(sqlQuery, sqlConn);

                var reader = sqlCmd.ExecuteReader();

                systemData = new SystemData();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        systemData.Id = reader.GetInt32(0);
                        systemData.CompanyName = reader["CompanyName"].ToString();
                        systemData.CompanyAddress = reader["CompanyAddress"].ToString();
                        systemData.CompanyEmail = reader["CompanyEmail"].ToString();
                        systemData.CompanyPhone = reader["CompanyPhone"].ToString();
                        systemData.MaxSaleQty = (int)reader["MaxSaleQty"];
                        systemData.MinStockLevel = (int)reader["MinStockLevel"];
                    }
                    AppConfig.maxSellingQty = systemData.MaxSaleQty;
                    AppConfig.minimunStockLevel = systemData.MinStockLevel;
                }
               

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured: {ex.Message}", "PharmaZeal");
            }
            finally
            {
                sqlConn?.Close();
            }
        }


        public static void checkForMinimumStock()
        {
            try
            {

                string sqlQuery = "SELECT COUNT(ID) FROM Stock WHERE Quantity < @allowedMinimumStock";

                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
                sqlConn.Open();
                sqlCmd = new SqlCommand(sqlQuery, sqlConn);
                sqlCmd.Parameters.AddWithValue("@allowedMinimumStock", AppConfig.minimunStockLevel);

                var reader = (int)sqlCmd.ExecuteScalar();

                isMinimumStockAvailable = reader > 0 ? true : false;
                

                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured: {ex.Message}", "PharmaZeal");
            }
            finally
            {
                sqlConn?.Close();
            }
        }
        /// <summary>
        /// Gets the drugs data.
        /// </summary>
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
