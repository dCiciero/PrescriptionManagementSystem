using Domain.DataAccess.Interfaces;
using Domain.DTOs;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataAccess
{
    public class TextFileConnector : IDataConnection
    {
       

        // TODO - To implement the CreateCustomer method
        /// <summary>
        /// This saves the customer's details to text file
        /// </summary>
        /// <param name="customerModel"> The inputed information</param>
        /// <returns> The saved information including the Id</returns>
        public Customer CreateCustomer(Customer customerModel)
        {
            customerModel.Id = 1;

            return customerModel;
        }

        public Sale CreateSale(Sale saleModel)
        {
            throw new NotImplementedException();
        }

        public User CreateUser(User userModel)
        {
            throw new NotImplementedException();
        }

        public bool LoginUser(LoginRequestDTO loginRequestDTO)
        {
            throw new NotImplementedException();
        }

        public UserResponseDTO CheckUsersAccount(LoginRequestDTO loginRequestDTO)
        {
            throw new NotImplementedException();
        }

        //(bool, UserResponseDTO) IDataConnection.CheckUsersAccount(LoginRequestDTO loginRequestDTO)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
