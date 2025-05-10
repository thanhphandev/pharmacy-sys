using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Common
{
    public class CurrencyFormatter
    {
        public static string FormatVietnameseCurrency(decimal amount)
        {
            CultureInfo vietnameseCulture = new CultureInfo("vi-VN");
            return string.Format(vietnameseCulture, "{0:C0}", amount);
        }
        public static decimal ParseVietnameseCurrency(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;

            input = input.Replace("₫", "").Replace(".", "").Trim();

            return decimal.TryParse(input, out var result) ? result : 0;
        }
    }
}
