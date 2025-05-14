using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Common
{
    public class DataValidator
    {
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            phoneNumber = phoneNumber.Trim();

            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^(03|05|07|08|09)\d{8}$");
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            email = email.Trim();

            if (email.Length > 320) // theo chuẩn RFC: max email length = 320 ký tự
                return false;

            return System.Text.RegularExpressions.Regex.IsMatch(
                email,
                @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
                System.Text.RegularExpressions.RegexOptions.IgnoreCase
            );
        }


    }
}
