using Domain.DTOs;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataAccess.Interfaces
{
    public interface IDataConnection
    {
        User CreateUser(User userModel);
        Customer CreateCustomer(Customer customerModel);
        Sale CreateSale(Sale saleModel);
        bool LoginUser(LoginRequestDTO loginRequestDTO);

        UserResponseDTO CheckUsersAccount(LoginRequestDTO loginRequestDTO);
        //(bool, UserResponseDTO) CheckUsersAccount2(LoginRequestDTO loginRequestDTO);



    }
}
