using Dapper;
using Domain.DataAccess.Interfaces;
using Domain.DTOs;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace Domain.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        private const string dbName = "PharmaZeal";
        // TODO - To implement the CreateCustomer method
        /// <summary>
        /// This saves the customer's details to the database
        /// </summary>
        /// <param name="customerModel"> The inputed information</param>
        /// <returns> The saved information including the Id</returns>
        public Customer CreateCustomer(Customer customerModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnectionString(dbName)))
            {
                var p = new DynamicParameters();
                p.Add("@firstName", customerModel.FirstName);
                p.Add("@lastName", customerModel.LastName);
                p.Add("@otherName", customerModel.OtherName);
                p.Add("@dob", customerModel.DateOfBirth);
                p.Add("@gender", customerModel.Gender);
                p.Add("@Mobile", customerModel.Mobile);
                p.Add("@Email", customerModel.Email);
                p.Add("@HouseNo", customerModel.HouseNo);
                p.Add("@StreetName", customerModel.StreetName);
                p.Add("@PostCode", customerModel.PostCode);
                p.Add("@City", customerModel.City);
                p.Add("@County", customerModel.County);
                p.Add("@Country", customerModel.Country);
                p.Add("@IsVulnerable", customerModel.IsVulnerable);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCreateCustomer", p, commandType: CommandType.StoredProcedure);

                customerModel.Id = p.Get<int>("@Id");
            }
            

            return customerModel;
        }

        public Sale CreateSale(Sale saleModel)
        {
            throw new NotImplementedException();
        }

        public User CreateUser(User userModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnectionString(dbName)))
            {
                var p = new DynamicParameters();
                p.Add("@firstName", userModel.FirstName);
                p.Add("@lastName", userModel.LastName);
                p.Add("@otherName", userModel.MidName);
                p.Add("@dob", userModel.BirthDate);
                p.Add("@gender", userModel.Gender);
                p.Add("@Mobile", userModel.Phone);
                p.Add("@Email", userModel.Email);
                p.Add("@HouseNo", userModel.HouseNo);
                p.Add("@StreetName", userModel.StreetName);
                p.Add("@PostCode", userModel.PostCode);
                p.Add("@City", userModel.City);
                p.Add("@County", userModel.County);
                p.Add("@Country", userModel.Country);
                p.Add("@PasswordHash", userModel.PasswordHash);
                p.Add("@NormalizedEmail", userModel.NormalizedEmail);
                p.Add("@DateEmployed", userModel.DateEmployed);
                p.Add("@DateDisengaged", userModel.DateDisengaged);
                p.Add("@StatusId", 1);
                p.Add("@Gender", userModel.Gender);
                p.Add("@IsAdmin", userModel.IsAdmin);
                p.Add("@StoreId", userModel.StoreId);
                p.Add("@securityStamp", userModel.SecurityStamp);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spCreateUser", p, commandType: CommandType.StoredProcedure);

                userModel.Id = p.Get<int>("@Id");
            }
            return userModel;
        }

        public bool LoginUser(LoginRequestDTO loginRequestDTO)
        {
            return true;
        }

        public UserResponseDTO CheckUsersAccount(LoginRequestDTO loginRequestDTO)
        {
            
            UserResponseDTO userResponseDTO = null;
            //IDbConnection sqlConn = null;
            try
            {
                
                using (IDbConnection sqlConn = new SqlConnection(GlobalConfig.GetConnectionString(dbName)))
                {
                    var dp = new DynamicParameters();
                    dp.Add("@email", loginRequestDTO.Email);
                    dp.Add("@storeId", loginRequestDTO.StoreId);

                    userResponseDTO = sqlConn.Query<UserResponseDTO>("dbo.spGetUserByEmail", dp, commandType: CommandType.StoredProcedure).ToList()[0];

                    return userResponseDTO;
                    //if (validateUser(userResponseDTO, loginRequestDTO.Password))
                    //{
                    //    return (true, userResponseDTO);
                    //}
                    //else
                    //{
                    //    return (false, new UserResponseDTO());
                    //}
                    
                }
                

            }
            catch (Exception ex)
            {
                return new UserResponseDTO(); // (userExist, paswdHash, saltKey, storeName, loggedInUserId);
            }
            finally
            {
                
            }
        }

        private bool validateUser(UserResponseDTO userResponseDTO, string password)
        {
            if (userResponseDTO != null)
            {
                var byteSalt = Convert.FromBase64String(userResponseDTO.SaltKey);
                var enteredPassword = (HashPassword(byteSalt, password)).Item2;
                if (enteredPassword == userResponseDTO.PasswordHash)
                {
                    return true;
                }
            }
            return false;
        }

        private static (byte[], string) HashPassword(byte[] salt, string password)
        {
            // generate a 128-bit salt using a cryptographically strong random sequence of nonzero values
            if (salt.Length == 0)
            {
                salt = new byte[128 / 8];
                using (var rngCsp = new RNGCryptoServiceProvider())
                {
                    rngCsp.GetNonZeroBytes(salt);
                }
            }

            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            return (salt, hashed);
        }


       
        public void ValidateLoginrequestDTO(LoginRequestDTO loginRequestDTO)
        {
            if (loginRequestDTO.Email.Length == 0)
            {
                throw new ArgumentException("Email cannot be empty", "Email");
            }

            if (loginRequestDTO.Password.Length == 0)
            {
                throw new ArgumentException("Password cannot be empty", "Password");
            }

            //if (loginRequestDTO.Password.Length <= 10)
            //{
            //    throw new ArgumentException("Password should be greater than 10 characters", "Password");
            //}
        }
    }
}
