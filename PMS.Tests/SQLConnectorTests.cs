using Domain.DataAccess;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PMS.Tests
{
    public class SQLConnectorTests
    {
        [Fact]
        public void ValidateLoginrequestDTOShouldPass()
        {
            //Arrange
            LoginRequestDTO loginRequestDTO = new LoginRequestDTO();
            loginRequestDTO.Email = "ivhurie01@yahoo.co.uk";
            loginRequestDTO.Password = "password";
            string exoectedEmail = loginRequestDTO.Email;

            //Act
            SQLConnector sQLConnector = new SQLConnector();
            //sQLConnector.ValidateLoginrequestDTO(loginRequestDTO);


            //Assert

            //Assert.True(loginRequestDTO.Password.Length > 10);
            Assert.Throws<ArgumentException>("Email", () => sQLConnector.ValidateLoginrequestDTO(loginRequestDTO));
            Assert.Throws<ArgumentException>("Password", () => sQLConnector.ValidateLoginrequestDTO(loginRequestDTO));
            //Assert.Throws<ArgumentException>("Password", () => sQLConnector.ValidateLoginrequestDTO(loginRequestDTO));
        }
    }
}
