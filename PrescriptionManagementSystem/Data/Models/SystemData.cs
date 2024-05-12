using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionManagementSystem.Data.Models
{
    public class SystemData
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyPhone { get; set;}
        public string? CompanyAddress { get; set; }
        public int MinStockLevel { get; set; } = 1;
        public int MaxSaleQty { get; set; } = 1;
    }
}
