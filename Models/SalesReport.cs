using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Models
{
    public class SalesReport
    {
        public DateTime Date { get; set; }
        public decimal TotalRevenue { get; set; }
        public int TotalBills { get; set; }
        public int TotalQuantitySold { get; set; }
    }
}
