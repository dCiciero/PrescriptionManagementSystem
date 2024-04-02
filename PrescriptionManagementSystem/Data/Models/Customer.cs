using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionManagementSystem.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string HouseNo { get; set; }
        public string StreetName { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
    }
}
