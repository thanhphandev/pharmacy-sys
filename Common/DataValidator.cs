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

    }
}
