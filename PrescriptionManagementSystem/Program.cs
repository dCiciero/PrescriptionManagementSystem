// ***********************************************************************
// Assembly         : PrescriptionManagementSystem
// Author           : ogaga.ivhurie
// Created          : 02-22-2024
//
// Last Modified By : ogaga.ivhurie
// Last Modified On : 05-11-2024
// ***********************************************************************
// <copyright file="Program.cs" company="PrescriptionManagementSystem">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Data.SqlClient;
using System.Data;
using PrescriptionManagementSystem.Data.Models;
using Microsoft.Extensions.Configuration;

namespace PrescriptionManagementSystem
{
    /// <summary>
    /// Class Program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The SQL connection
        /// </summary>
        private static SqlConnection sqlConn;
        /// <summary>
        /// The SQL command
        /// </summary>
        private static SqlCommand sqlCmd;
        /// <summary>
        /// The RDR
        /// </summary>
        private static SqlDataReader rdr;
        /// <summary>
        /// The stores
        /// </summary>
        public static List<Store> stores = new List<Store>();
        /// <summary>
        /// The store
        /// </summary>
        public static Store store;
        /// <summary>
        /// The binding source
        /// </summary>
        public static BindingSource bindingSource;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]        
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();

            AppSetting appSetting = new AppSetting();
            DataTable dt = new DataTable();

            
            AppConfig.getDBConnection();
            AppConfig.getStoreDetails();
            AppConfig.getStockTypes();
            AppConfig.getSystemaData();

            //Initialize DB Connection for Library
            Domain.GlobalConfig.InitializeConnections(Domain.DatabaseType.Sql);


            LoginForm frmLogin = new LoginForm();
            Application.Run(frmLogin);
        }

        
    }
}