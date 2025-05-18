using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Models
{
    public class BillPrintDto
    {
        public string Code { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string StaffName { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public string VAT { get; set; } = string.Empty;
        public string GrandAmount { get; set; } = string.Empty;
        public string TotalPrice { get; set; } = string.Empty;
    }

    public class BillDetailPrintDto
    {
        public string MedicineName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string UnitType { get; set; } = string.Empty;
        public string UnitPrice { get; set; } = string.Empty;
        public string Total { get; set; } = string.Empty;
    }
}
