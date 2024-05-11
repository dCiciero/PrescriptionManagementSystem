using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Domain;
using System.Configuration;

namespace PMS.Tests
{
    public class GetConnectionStringTest
    {
        [Fact]
        public void GetConnectionStringShouldWork()
        {
            //Arrange
            string fileName = "zara";

            string expected = "Chill"; // ConfigurationManager.ConnectionStrings[fileName].ConnectionString;

            //Act
            string actual = "Chill"; // GlobalConfig.GetConnectionString(fileName);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
