using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    /// <summary>
    ///  Represents users of teh application/employees
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }
        public string Gender { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DateEmployed { get; set; }
        public DateTime DateDisengaged { get; set; }
        public string HouseNo { get; set; }
        public string StreetName { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }
        public string SecurityStamp { get; set; }
        public int StoreId { get; set; }
        public int StatusId { get; set; } 
    }
}
