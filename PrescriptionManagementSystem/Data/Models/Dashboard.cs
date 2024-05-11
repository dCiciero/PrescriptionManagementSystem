using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrescriptionManagementSystem.Data.Db;

namespace PrescriptionManagementSystem.Data.Models
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class Dashboard : DbConnection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberOfDays;

        public int NumberOfCustomers {  get; private set; }
        public int NumberOfSuppliers {  get; private set; }
        public int NumberOfProducts {  get; private set; }
        public int NumberOfMedicalProducts {  get; private set; }
        public int NumberOfNonMedicalProducts {  get; private set; }
        public int NumberOfSales {  get; private set; }
        public int NumberOfOrders {  get; private set; }
        public decimal TotalRevenue {  get; private set; }
        public decimal TotalProfit {  get; private set; }
        public List<KeyValuePair<string, int>> TopProductList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }

        public Dashboard()
        {
            
        }

        //Private Methods
        private void GetNumberOfItems()
        {
            using (var connection=GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    //Get total number of customers
                    command.CommandText = "SELECT COUNT(id) FROM Customer";
                    NumberOfCustomers = (int)command.ExecuteScalar();

                    //Get total number of product
                    command.CommandText = "SELECT COUNT(id) FROM PharmaDrugs";
                    NumberOfProducts = (int)command.ExecuteScalar();

                    //Get total number of suppliers
                    //command.CommandText = "SELECT COUNT(id) FROM Suppliers";
                    //NumberOfSuppliers = (int)command.ExecuteScalar();

                    //Get total number of SalesSuppliers
                    command.CommandText = "SELECT COUNT(ID) FROM dbo.Sales WHERE DateSold BETWEEN @fromDate AND @toDate";
                    command.Parameters.AddWithValue("@fromDate", startDate);
                    command.Parameters.AddWithValue("@toDate", endDate);
                    NumberOfSales = (int)command.ExecuteScalar();
                }
            }
        }

        private void GetSaleAnalysis()
        {
            GrossRevenueList = new();
            TotalProfit = 0;
            TotalRevenue = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT DateSold, SUM(AmountPaid) [Total Sale]
                                            FROM Sales 
                                            WHERE DateSold BETWEEN @fromDate and @toDate
                                            GROUP BY DateSold";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.AddWithValue("@toDate", endDate);
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1]));
                        TotalRevenue += (decimal)reader[1];
                    }
                    TotalProfit += TotalRevenue * 0.2m;
                    reader.Close();

                    //Group by days
                    if (numberOfDays <= 1)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("hh, mm")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                        //foreach (var kvp in resultTable)
                        //{
                        //    GrossRevenueList.Add(new RevenueByDate()
                        //    {
                        //        Date = kvp.Key.ToString("dd MMM"),
                        //        TotalAmount = kvp.Value,
                        //    });
                        //}
                    }
                    //Group by days
                    else if (numberOfDays <= 30)
                    {
                        GrossRevenueList = (from saleList in resultTable
                                            group saleList by saleList.Key.ToString("dd MMM")
                                            into order
                                            select new RevenueByDate
                                            { 
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                        //foreach (var kvp in resultTable)
                        //{
                        //    GrossRevenueList.Add(new RevenueByDate()
                        //    {
                        //        Date = kvp.Key.ToString("dd MMM"),
                        //        TotalAmount = kvp.Value,
                        //    });
                        //}
                    }

                    //Group by weeks
                    else if (numberOfDays <= 92)
                    {
                        GrossRevenueList = (from saleList in resultTable
                                            group saleList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                saleList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                            into sale
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + sale.Key.ToString(),
                                                TotalAmount = sale.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by months
                    else if (numberOfDays <= (365 * 2))
                    {
                        bool isYear = numberOfDays <= 365 ? true : false;
                        GrossRevenueList = (from saleList in resultTable
                                            group saleList by saleList.Key.ToString("MMM yyyy")
                                            into sale
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? sale.Key.Substring(0, sale.Key.IndexOf(" ")) : sale.Key,
                                                TotalAmount = sale.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by years
                    else
                    {
                        GrossRevenueList = (from saleList in resultTable
                                            group saleList by saleList.Key.ToString("yyyy")
                                            into sale
                                            select new RevenueByDate
                                            {
                                                Date = sale.Key, 
                                                TotalAmount = sale.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }

        private void GetProductAnalysis()
        {
            TopProductList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();

            using var connection = GetConnection();
            connection.Open();
            using var command = new SqlCommand();
            SqlDataReader reader;
            command.Connection = connection;

            //Get Top 5 Products
            command.CommandText = @"SELECT TOP 5 P.Name, SUM(SalesItem.QtySold) AS Q 
                                    FROM SalesItem
                                    INNER JOIN PharmaDrugs P ON P.Id = SalesItem.DrugId
                                    INNER JOIN Sales S ON S.Id = SalesItem.SaleId
                                    WHERE DateSold BETWEEN @fromDate AND @toDate
                                    GROUP BY P.Name
                                    ORDER BY Q DESC";

            command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
            command.Parameters.AddWithValue("@toDate", endDate);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                TopProductList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
            }
            reader.Close();

            //Get Low Stock Products
            command.CommandText = @"SELECT TOP 5 Name, Quantity 
                                    FROM Stock
                                    WHERE QUANTITY < @minStockLevel"; // AND IsDiscontinued=@isDiscontinued";
            command.Parameters.AddWithValue("@minStockLevel", AppConfig.minimunStockLevel);
            //command.Parameters.AddWithValue("@isDiscontinued", false);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                UnderstockList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
            }
            reader.Close();

        }


        //Public Methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberOfDays = (endDate - startDate).Days;

                GetNumberOfItems();
                GetProductAnalysis();
                GetSaleAnalysis();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Date not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
            
        }
    }
}
