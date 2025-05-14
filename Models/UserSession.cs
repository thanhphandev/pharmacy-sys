using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Models
{
    public static class UserSession
    {
        public static int Id { get; set; } = -1;
        public static string FullName { get; set; } = string.Empty;
        public static string Email { get; set; } = string.Empty;
        public static string Phone { get; set; } = string.Empty;
        public static UserRole Role { get; set; } = UserRole.Staff;
        public static bool IsLoggedIn { get; set; } = false;
        public static void ClearSession()
        {
            Id = -1;
            FullName = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            Role = UserRole.Staff;
            IsLoggedIn = false;
        }
    }
}
