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
using System.Runtime.InteropServices;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using PrescriptionManagementSystem.Data.Models;
using Microsoft.Office.Interop.Excel;

namespace PrescriptionManagementSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {

            //var filePath = @"C:\Users\ogaga.ivhurie\Documents\dev\dotnet-devs\WinDevs\PrescriptionManagementSystem\Drug dataset.xlsx";
            //var filePath = @"C:\Users\ogaga.ivhurie\Documents\dev\dotnet-devs\WinDevs\PrescriptionManagementSystem\ST7.xlsx";
            //MessageBox.Show(Path.GetFileName(filePath), "PahrmaZeal");

            
            //Excel.Application excelApp = new Excel.Application();
            //Excel.Workbook wkBook = excelApp.Workbooks.Open(filePath);
            //Excel._Worksheet wksheet = (_Worksheet)wkBook.Sheets[0];
            //Excel.Range range = wksheet.UsedRange;

            //int rowCount = range.Rows.Count;
            //int columnCount = range.Columns.Count;

            //for (int row = 2; row <= 3; row++)
            //{
            //    Name = range.Cells[row, 1].ToString();
            //    MessageBox.Show(Name, "PharmaZeal");
            //}

            //return;

            string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PharmaZeal; Integrated Security=True; ";
            try
            {
                MessageBox.Show("Contact System Admin", "PharmaZeal");
                return;
                //LoadMasterDataSet(filePath, connectionStr);
                //SaveStockDataSet(filePath, connectionStr);
                //SaveCustomerDataSet(filePath, connectionStr);

            }
            catch (Exception)
            {
                MessageBox.Show("Error Connecting to DB", "PharmaZeal");
            }
            
        }

        private void SaveCustomerDataSet(string filePath, string connectionStr)
        {
            var customerData = LoadCustomersDataFromExcel(filePath);
            if (customerData.Count() == 0)
            {
                MessageBox.Show("No record available", "PharmaZeal");
                return;
            }
            try
            {
                using (var connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    MessageBox.Show("Coonection Succeeded", "Db Connect");
                    //return;
                    foreach (var cust in customerData)
                    {
                        string insertQuery = "INSERT INTO Customer " +
                            "(FirstName, LastName, OtherName, HouseNo, StreetName, PostCode, City, County, Country, DateOfBirth)" +
                            "Values (@FirstName, @LastName, @OtherName, @HouseNo, @StreetName, @PostCode, @City, @County, @Country, @DateOfBirth)";

                        using (var cmd = new SqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", cust.FirstName);
                            cmd.Parameters.AddWithValue("@LastName", cust.LastName);
                            cmd.Parameters.AddWithValue("@OtherName", cust.OtherName);
                            cmd.Parameters.AddWithValue("@HouseNo", cust.HouseNo);
                            cmd.Parameters.AddWithValue("@StreetName", cust.StreetName);
                            cmd.Parameters.AddWithValue("@PostCode", cust.PostCode);
                            cmd.Parameters.AddWithValue("@City", cust.City);
                            cmd.Parameters.AddWithValue("@County", cust.County);
                            cmd.Parameters.AddWithValue("@Country", cust.Country);
                            cmd.Parameters.AddWithValue("@DateOfBirth", cust.DateOfBirth);


                            cmd.ExecuteNonQuery();
                        };

                    }
                    MessageBox.Show("Customer Record uploaded successfully", "PharmaZeal");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "PharmaZeal");
            }
            finally
            {
                //connection.Close()
            }
        }

        private IEnumerable<Customer> LoadCustomersDataFromExcel(string filePath)
        {
            var custs = new List<Customer>();
            try
            {

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                using (var streamval = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(streamval))
                    {
                        var configuration = new ExcelDataSetConfiguration
                        {
                            ConfigureDataTable = _ => new ExcelDataTableConfiguration
                            {
                                UseHeaderRow = false
                            }
                        };
                        var dataSet = reader.AsDataSet(configuration);
                        if (dataSet.Tables.Count > 0)
                        {
                            var dataTable = dataSet.Tables[0];
                            for (int i = 1; i < dataTable.Rows.Count; i++)
                            {
                                var cust = new Customer
                                {
                                    DateOfBirth = (DateTime)dataTable.Rows[i][0],
                                    LastName = dataTable.Rows[i][1].ToString(),
                                    OtherName = dataTable.Rows[i][2].ToString(),
                                    FirstName = dataTable.Rows[i][3].ToString(),
                                    HouseNo = dataTable.Rows[i][4].ToString(),
                                    StreetName = dataTable.Rows[i][5].ToString(),
                                    PostCode = dataTable.Rows[i][6].ToString(),
                                    City = dataTable.Rows[i][7].ToString(),
                                    County = dataTable.Rows[i][8].ToString(),
                                    Country = dataTable.Rows[i][9].ToString(),
                                    
                                };
                                MessageBox.Show(cust.FirstName, "PharmaZeal");
                                custs.Add(cust);
                                
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "PharmaZeal Here");

            }
            return custs;
        }

        public List<Drug> LoadDrugsDataFromExcel(string fileName)
        {
            var drugs = new List<Drug>();
            try
            {


                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                using (var streamval = File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(streamval))
                    {
                        var configuration = new ExcelDataSetConfiguration
                        {
                            ConfigureDataTable = _ => new ExcelDataTableConfiguration
                            {
                                UseHeaderRow = false
                            }
                        };
                        var dataSet = reader.AsDataSet(configuration);
                        if (dataSet.Tables.Count > 0)
                        {
                            var dataTable = dataSet.Tables[0];
                            //MessageBox.Show(dataTable.Rows.Count.ToString());
                            //MessageBox.Show(dataTable.Columns.Count.ToString());
                            //MessageBox.Show(dataTable.Rows[1][1].ToString());
                            for (int i = 1; i < dataTable.Rows.Count; i++)
                            {
                                var drug = new Drug
                                {
                                    Name = dataTable.Rows[i][0].ToString(),
                                    Condition = dataTable.Rows[i][1].ToString(),
                                    IdCheck = dataTable.Rows[i][2].ToString().Trim() == "Y" ? true : false, // (bool)worksheet.Cells[row, 3].Value,
                                    InStoke = dataTable.Rows[i][3].ToString().Trim() == "Y" ? true : false,
                                    InTunstall = dataTable.Rows[i][4].ToString().Trim() == "Y" ? true : false,
                                    InFenton = dataTable.Rows[i][5].ToString().Trim() == "Y" ? true : false,
                                    InHanley = dataTable.Rows[i][6].ToString().Trim() == "Y" ? true : false,
                                    InLongton = dataTable.Rows[i][7].ToString().Trim() == "Y" ? true : false,

                                };
                                //MessageBox.Show(drug.Condition, "PharmaZealAAA");
                                drugs.Add(drug);
                                //for (int j = 0; j < dataTable.Columns.Count; j++)
                                //{
                                //    //MessageBox.Show(dataTable.Rows[i][j].ToString());
                                //    var drug = new Drug
                                //    {
                                //        Name = dataTable.Rows[i][j].ToString(),
                                //        Condition = dataTable.Rows[i][j].ToString(),
                                //        IdCheck = dataTable.Rows[i][j].ToString() == "Y" ? true : false, // (bool)worksheet.Cells[row, 3].Value,
                                //        InStoke = dataTable.Rows[i][j].ToString() == "Y" ? true : false,
                                //        InTunstall = dataTable.Rows[i][j].ToString() == "Y" ? true : false,
                                //        InFenton = dataTable.Rows[i][j].ToString() == "Y" ? true : false,
                                //        InHanley = dataTable.Rows[i][j].ToString() == "Y" ? true : false,
                                //        InLongton = dataTable.Rows[i][j].ToString() == "Y" ? true : false,

                                //    };
                                //    MessageBox.Show(drug.Name, "PharmaZealAAA");
                                //    //drugs.Add(drug);
                                //}
                            }
                        }
                    }
                }
                /*************************************************/

                //var fileName = 
                //Excel.Application excelApp = new Excel.Application();
                //Excel.Workbook wkBook = excelApp.Workbooks.Open(fileName);
                //Excel._Worksheet wksheet = (_Worksheet)wkBook.Sheets[0];
                //Excel.Range range = wksheet.UsedRange;

                //int rowCount = range.Rows.Count;
                //int columnCount = range.Columns.Count;

                //for (int row = 2; row <= 3; row++)
                //{
                //    Name = range.Cells[row, 1].ToString();
                //    MessageBox.Show(Name, "PharmaZeal");
                //}

                //using (var package = new ExcelPackage(new FileInfo(fileName)))
                //{
                //    //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                //    var worksheet = package.Workbook.Worksheets[0];
                //    //MessageBox.Show(worksheet.Dimension.End.Row.ToString(), "PharmaZeal");
                //    //return drugs;
                //for (int row = 2; row <= 3; row++)
                //{
                //var drug = new Drug
                //{
                //    Name = worksheet.Cells[row, 1].Value.ToString(),
                //    Condition = worksheet.Cells[row, 2].Value.ToString(),
                //    IdCheck = worksheet.Cells[row, 3].Value.ToString() == "Y" ? true : false, // (bool)worksheet.Cells[row, 3].Value,
                //    InStoke = worksheet.Cells[row, 4].Value.ToString() == "Y" ? true : false,
                //    InTunstall = worksheet.Cells[row, 5].Value.ToString() == "Y" ? true : false,
                //    InFenton = worksheet.Cells[row, 6].Value.ToString() == "Y" ? true : false,
                //    InHanley = worksheet.Cells[row, 7].Value.ToString() == "Y" ? true : false,
                //    InLongton = worksheet.Cells[row, 8].Value.ToString() == "Y" ? true : false,

                //};
                //MessageBox.Show(drug.Condition, "PharmaZeal");
                ////drugs.Add(drug);


                //}
                //};

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "PharmaZeal");

            }
            return drugs;
        }

        public List<Stock> LoadStocksDataFromExcel(string fileName)
        {
            var stocks = new List<Stock>();
            try
            {

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                using (var streamval = File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(streamval))
                    {
                        var configuration = new ExcelDataSetConfiguration
                        {
                            ConfigureDataTable = _ => new ExcelDataTableConfiguration
                            {
                                UseHeaderRow = false
                            }
                        };
                        var dataSet = reader.AsDataSet(configuration);
                        if (dataSet.Tables.Count > 0)
                        {
                            var dataTable = dataSet.Tables[1];
                            //MessageBox.Show(dataTable.Rows.Count.ToString());
                            //MessageBox.Show(dataTable.Columns.Count.ToString());
                            //MessageBox.Show(dataTable.Rows[1][1].ToString());
                            for (int i = 1; i < dataTable.Rows.Count; i++)
                            {
                                var stock = new Stock
                                {
                                    Name = dataTable.Rows[i][0].ToString(),
                                    Quantity = (double)dataTable.Rows[i][1],
                                    Expiry = (DateTime)dataTable.Rows[i][2]
                                };
                                MessageBox.Show(stock.Name, "PharmaZeal");
                                stocks.Add(stock);
                                //for (int j = 0; j < dataTable.Columns.Count - 1; j++)
                                //{
                                //    MessageBox.Show(dataTable.Rows[i][j].ToString());
                                //    var stock = new Stock
                                //    {
                                //        Name = dataTable.Rows[i][j].ToString(),
                                //        Quantity = (int)dataTable.Rows[i][j],
                                //        Expiry = (DateTime)dataTable.Rows[i][j]
                                //    };
                                //    MessageBox.Show(stock.Name, "PharmaZeal");
                                //    //stocks.Add(stock);

                                //}
                            }
                        }
                    }
                }

                /************************************************************/
                //var fileName = 
                //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                //using (var package = new ExcelPackage(new FileInfo(fileName)))
                //{
                //    var worksheet = package.Workbook.Worksheets[1];
                //    //MessageBox.Show(worksheet.Dimension.End.Row.ToString(), "PharmaZeal");
                //    //return drugs;
                //    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                //    {
                //        var stock = new Stock
                //        {
                //            Name = worksheet.Cells[row, 1].Value.ToString(),
                //            Quantity = (int)worksheet.Cells[row, 2].Value,
                //            Expiry = (DateTime)worksheet.Cells[row, 3].Value
                //        };
                //        MessageBox.Show(stock.Name);
                //        //stocks.Add(stock);
                //    }
                //};

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "PharmaZeal Here");

            }
            return stocks;
        }

        private void LoadMasterDataSet(string filePath, string connectionStr)
        {
            var drugData = LoadDrugsDataFromExcel(filePath);
            if (drugData.Count() == 0)
            {
                MessageBox.Show("No record available", "PharmaZeal");
                return;
            }
            MessageBox.Show("Saving Data to DB", "PharmaZeal");
            //return;
            try
            {
                using (var connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    MessageBox.Show("Coonection Succeeded", "Db Connect");
                    foreach (var drug in drugData)
                    {
                        string insertQuery = "INSERT INTO PharmaDrugs " +
                            "(Name, Condition, IdCheck, InStoke, InTunstall, InFenton, InHanley, InLongton)" +
                            "Values (@Name, @Condition, @IdCheck, @InStoke, @InTunstall, @InFenton, @InHanley, @InLongton)";

                        using (var cmd = new SqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@Name", drug.Name);
                            cmd.Parameters.AddWithValue("@Condition", drug.Condition);
                            cmd.Parameters.AddWithValue("@IdCheck", drug.IdCheck);
                            cmd.Parameters.AddWithValue("@InStoke", drug.InStoke);
                            cmd.Parameters.AddWithValue("@InTunstall", drug.InTunstall);
                            cmd.Parameters.AddWithValue("@InFenton", drug.InFenton);
                            cmd.Parameters.AddWithValue("@InHanley", drug.InHanley);
                            cmd.Parameters.AddWithValue("@InLongton", drug.InLongton);

                            cmd.ExecuteNonQuery();
                        };
                    }
                    MessageBox.Show("Record uploaded successfully", "PharmaZeal");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "PharmaZeal");
            }
            
        }

        private void SaveStockDataSet(string filePath, string connectionStr)
        {
            var stockData = LoadStocksDataFromExcel(filePath);
            if (stockData.Count() == 0)
            {
                MessageBox.Show("No record available", "PharmaZeal");
                return;
            }
            try
            {
                using (var connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    MessageBox.Show("Coonection Succeeded", "Db Connect");
                    //return;
                    foreach (var stock in stockData)
                    {
                        string insertQuery = "INSERT INTO Stock " +
                            "(Name, Quantity, Expiry)" +
                            "Values (@Name, @Quantity, @Expiry)";

                        using (var cmd = new SqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@Name", stock.Name);
                            cmd.Parameters.AddWithValue("@Quantity", stock.Quantity);
                            cmd.Parameters.AddWithValue("@Expiry", stock.Expiry);


                            cmd.ExecuteNonQuery();
                        };
                       
                    }
                    MessageBox.Show("Stock Record uploaded successfully", "PharmaZeal");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "PharmaZeal");
            }
        }


    }
}
