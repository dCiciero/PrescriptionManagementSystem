using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionManagementSystem.Data.DTOs
{
    public class SaleDTO
    {
        public DateTime DateSold { get; set; }
        public Decimal AmountPaid { get; set; }
        public Decimal Change { get; set; }
        public Decimal Tax { get; set; }
        public int UserId { get; set; }
    }
}
