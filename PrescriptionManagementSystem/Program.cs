using System.Data.SqlClient;
using System.Data;
using PrescriptionManagementSystem.Data.Models;

namespace PrescriptionManagementSystem
{
    internal static class Program
    {
        private static SqlConnection sqlConn;
        private static SqlCommand sqlCmd;
        private static SqlDataReader rdr;
        public static List<Store> stores = new List<Store>();
        public static Store store;
        public static BindingSource bindingSource;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]        
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
           
            
            EmployeeMgmtForm empMgmtForm = new EmployeeMgmtForm();
            DataTable dt = new DataTable();
            //mainForm mainForm = new mainForm();
            //mainForm.WindowState = FormWindowState.Maximized;
            //empMgmtForm.WindowState = FormWindowState.Maximized;
            //mainForm.FormBorderStyle = FormBorderStyle.None;
            AppConfig.getDBConnection();
            AppConfig.getStoreDetails();
            LoginForm frmLogin = new LoginForm();
            //getStoreDetails();
            SalesChart salesChart = new SalesChart();
            DashboardForm dashboardForm = new DashboardForm();
            Application.Run(dashboardForm);
            //Application.Run(new WebScraper());
        }

        
    }
}