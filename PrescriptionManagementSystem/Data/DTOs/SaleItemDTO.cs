using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionManagementSystem.Data.DTOs
{
    public class SaleItemDTO
    {
        public long Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal Price { get; set; }
        public int SaleId { get; set; }
        public int StockId { get; set; }
        public int Quantity2Buy { get; set; }
        public int DrugId { get; set; }
        public string Name { get; set; }
        public string Condition { get; set; }
        public bool IdCheck { get; set; }
        public bool InStoke { get; set; }
        public bool InTunstall { get; set; }
        public bool InHanley { get; set; }
        public bool InLongton { get; set; }
        public bool InFenton { get; set; }
    }
}
