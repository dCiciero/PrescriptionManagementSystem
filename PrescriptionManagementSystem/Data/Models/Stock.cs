using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionManagementSystem.Data.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public DateTime Expiry { get; set; }
    }
}
