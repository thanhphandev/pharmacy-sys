using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string FullName { get; set; }
        public required string Phone { get; set; }
        public UserRole Role { get; set; } = UserRole.Staff;

    }
}
