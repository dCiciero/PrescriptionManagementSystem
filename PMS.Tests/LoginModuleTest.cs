using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.DTOs;
using Xunit;
namespace PMS.Tests
{
    public class LoginModuleTest
    {
        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        public void Add2NumbersShouldPass(double x, double y, double expected)
        {
            //Arrange
            

            //Act
            double actual = GlobalConfig.Add2Numbers(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EmailAndPasswordShouldBeEntered()
        {
            //Arrange
            LoginRequestDTO loginRequestDTO = new LoginRequestDTO();
            loginRequestDTO.Email = "ivhurie01@yahoo.co.uk";
            loginRequestDTO.Password = "password";
            string exoectedEmail = loginRequestDTO.Email;

            //Act
            bool email = loginRequestDTO.Email.Length == 0;

            //Assert
            Assert.True(loginRequestDTO.Email.Length != 0);
            Assert.True(loginRequestDTO.Password.Length != 0);
        }

        [Fact]
        public void PasswordLengthShouldBeGreaterThan10Chars()
        {
            //Arrange
            LoginRequestDTO loginRequestDTO = new LoginRequestDTO();
            loginRequestDTO.Email = "ivhurie01@yahoo.co.uk";
            loginRequestDTO.Password = "password1234";
            string exoectedEmail = loginRequestDTO.Email;

            //Act
           

            //Assert
            
            Assert.True(loginRequestDTO.Password.Length > 10);
        }
    }
}
