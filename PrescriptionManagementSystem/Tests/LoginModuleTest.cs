using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NUnit.Framework;
using PrescriptionManagementSystem.Data.DTOs;
using PrescriptionManagementSystem.Data.Models;

namespace PrescriptionManagementSystem.Tests
{
    //[TestFixture]
    public class LoginModuleTest
    {
        //[Test]
        public void checkUserAccount_valid()
        {
            string email = "ivhurie01@yahooco.uk";
            LoginUser loginUser = new LoginUser();
            loginUser.Email = email;
            loginUser.Password = "";
            UserDTO userDTO = new UserDTO();
            LoginForm loginForm = new LoginForm();
            loginForm.CheckUsersAccount(email);
        }
    }
}
