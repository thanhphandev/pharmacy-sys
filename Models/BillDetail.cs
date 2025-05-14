using Microsoft.EntityFrameworkCore.ChangeTracking;
using pharmacy_sys.Common;
using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Models
{
    public class BillDetail
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public string? BatchUsageJson { get; set; }
        public int MedicineId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount => Quantity * Price;
        public string? MedicineCode => Medicine?.Code;
        public string? MedicineName => Medicine?.Name;
        public string PriceFormatted => CurrencyFormatter.FormatVietnameseCurrency(Price);
        public string AmountFormatted => CurrencyFormatter.FormatVietnameseCurrency(Amount);

        // Navigation properties
        public virtual Bill Bill { get; set; } = null!;
        public virtual Medicine Medicine { get; set; } = null!;
    }
}


