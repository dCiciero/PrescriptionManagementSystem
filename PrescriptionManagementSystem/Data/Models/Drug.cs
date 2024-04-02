using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionManagementSystem.Data.Models
{
    public class Drug
    {
        //public int Id { get; set; }
        public string? Name { get; set; }
        public string? Condition { get; set; }
        public bool IdCheck { get; set; }
        public bool InStoke { get; set; }
        public bool InTunstall { get; set; }
        public bool InFenton { get; set; }
        public bool InHanley { get; set; }
        public bool InLongton { get; set; }
    }
}
