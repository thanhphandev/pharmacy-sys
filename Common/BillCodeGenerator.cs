using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Common
{
    public static class BillCodeGenerator
    {
        private static Random _random = new Random();

        public static string Generate()
        {
            string prefix = "HD";
            string datePart = DateTime.Now.ToString("yyyyMMdd");
            string randomPart = RandomString(5);

            return $"{prefix}{datePart}{randomPart}";
        }

        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                                        .Select(s => s[_random.Next(s.Length)])
                                        .ToArray());
        }
    }

}
