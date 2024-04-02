using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionManagementSystem.Data.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime DateSold { get; set; }
        public Decimal AmountPaid { get; set; }
        public Decimal Tax { get; set; }
        public int UserId { get; set; }
        //public UserAccount userAccount { get; set; }
    }
}
