using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Domain;

namespace PMS.Tests
{
    public class GlobalConfigTests
    {
        //[Fact]
        [Theory]
        [InlineData("ivhurie01@yahoo.co.uk", true)]
        [InlineData("cicero4u2nv@gmail.com", true)]
        public void ValidateEmailShoudWork(string x, bool expected)
        {
            //Arrange
            string email = "ivhurie01@yahoo.co.uk";
            //bool expected = true; // "ivhurie01@yahoo.co.uk";

            // Act
            bool actual = GlobalConfig.ValidateEmail(x);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidateEmailShoudFail()
        {
            //Arrange
            string email = "ivhurie01.uk";
            bool expected = false; // "ivhurie01@yahoo.co.uk";

            // Act
            bool actual = GlobalConfig.ValidateEmail(email);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
