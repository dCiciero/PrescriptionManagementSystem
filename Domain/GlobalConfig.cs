using Domain.DataAccess;
using Domain.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                SQLConnector sqlConnector = new SQLConnector();
                Connection = sqlConnector;

            }

            else if (db == DatabaseType.TextFile)
            {
                // TODO - Create text file Connection
                TextFileConnector textFileConnector = new TextFileConnector();
                Connection = textFileConnector;
            }
        }
        
        public static string GetConnectionString(string conStrName)
        {
            var conStr = ConfigurationManager.ConnectionStrings[conStrName].ConnectionString;
            var conStr2 = ConfigurationManager.ConnectionStrings[conStrName];

            return conStr;
        }

        public static double Add2Numbers(double num1, double num2)
        {
            return num1 + num2;
        }

        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);
            return regex.IsMatch(emailAddress);
        }


    }
}
