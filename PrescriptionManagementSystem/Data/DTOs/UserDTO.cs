using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionManagementSystem.Data.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool IsAdmin { get; set; }
        public string Name { get; set; }
        public string Store { get; set; }
        public int StoreId { get; set; }
        public string SaltKey { get; set; }
    }
}
