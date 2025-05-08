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
        public int MedicineId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Navigation properties
        public virtual Bill Bill { get; set; } = null!;
        public virtual Medicine Medicine { get; set; } = null!;
    }
}
