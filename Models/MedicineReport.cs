using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Models
{
    public class MedicineReportItem
    {
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
        public DateTime? ExpirationDate { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; } = string.Empty;
    }

    public class StockSummary
    {
        public int TotalMedicines { get; set; }
        public int TotalMedicineBatch { get; set; }
        public int ExpiringCount { get; set; }
        public int LowStockCount { get; set; }
    }

}
