using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace pharmacy_sys.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public required string Code { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int StaffId { get; set; }
        public string? Note { get; set; }
        public decimal GrandAmount { get; set; } = 0;
        public decimal VAT { get; set; } = 0;
        public decimal TotalPrice { get; set; } = 0;

        public string? StaffName => Staff?.FullName;
        // Navigation properties

        public virtual User Staff { get; set; } = null!;
        public virtual ObservableCollectionListSource<BillDetail> BillDetails { get; set; } = new();
    }
}
