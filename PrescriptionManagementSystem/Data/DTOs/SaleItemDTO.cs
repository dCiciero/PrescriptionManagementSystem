using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionManagementSystem.Data.DTOs
{
    public class SaleItemDTO
    {
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal Price { get; set; }
        public int SaleId { get; set; }
        public int DrugId { get; set; }
    }
}
