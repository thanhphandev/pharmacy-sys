using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Models
{
    public class MedicineBatch
    {
        public int Id { get; set; }
        public required int Quantity { get; set; }
        public required DateTime ExpirationDate { get; set; }
        public required DateTime ManufactureDate { get; set; }
        public required int SupplierId { get; set; }
        public required int MedicineId { get; set; }

        // Navigation properties
        public virtual Medicine Medicine { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;

        public string SupplierName => Supplier?.Name ?? "No Supplier";
    }
}
