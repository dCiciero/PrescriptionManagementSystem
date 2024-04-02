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
    public partial class SalesChart : Form
    {
        SqlConnection sqlConn;
        SqlCommand sqlCmd;
        SqlDataReader rdr;
        SqlTransaction sqlTransaction;
        public SalesChart()
        {
            InitializeComponent();
            sqlConn = AppConfig.sqlConn;

        }

        private void SalesChart_Load(object sender, EventArgs e)
        {
            //SaleChart.Series["Sale"].Points.AddXY("Alomo", 4300);
            //SaleChart.Series["Sale"].Points.AddXY("Jameson", 23300);
            //SaleChart.Series["Sale"].Points.AddXY("Hennessey", 140300);

            //SaleChart.Series["Sale"].Points.Add(4300);
            //SaleChart.Series["Sale"].Points[0].Color = Color.SteelBlue;
            //SaleChart.Series["Sale"].Points[0].AxisLabel = "OgCicero";
            //SaleChart.Series["Sale"].Points[0].Label = "Winner";
            //SaleChart.Series["Sale"].Points[0].LegendText = "Og_Winner";

            //SaleChart.Series["Sale"].Points.Add(3200);
            //SaleChart.Series["Sale"].Points[1].Color = Color.Brown;
            //SaleChart.Series["Sale"].Points[1].AxisLabel = "Jatin";

            //DrawPiechart();
        }

        private void DrawPiechart()
        {
            DataTable dataTable;
            SqlDataAdapter sqlDataAdapter;

            try
            {
                string sqlQuery = "SELECT DATEPART(dd, DateSold) DateSold, AmountPaid " +
                    "FROM Sales"; // WHERE p.InStoke = @InStoke

                //string sqlQuery = "SELECT p.[Name],p.[Condition], p.IdCheck, p.Id AS DrugId, s.UnitCost, s.Quantity, s.Id AS StockId  " +
                //    "FROM PharmaDrugs p  JOIN Stock s ON p.Id =  s.DrugId WHERE p.InStoke=1";


                sqlCmd = new SqlCommand(sqlQuery, sqlConn);
                //sqlCmd.Parameters.AddWithValue("@InStoke", AppConfig.loggedInStoreId);

                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                dataTable = new DataTable("Drugs");
                sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                //sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                sqlDataAdapter.Fill(dataTable);

               

                //ProgressChart.DataSource = dataTable;
                //ProgressChart.Series["Progress"].XValueMember = "DateSold";
                //ProgressChart.Series["Progress"].YValueMembers = "AmountPaid";
                //ProgressChart.Series["Progress"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                //ProgressChart.Series["Progress"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;


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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
