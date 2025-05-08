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
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CustomerName { get; set; } = string.Empty;
        public int StaffId { get; set; }
        public string? Note { get; set; }

        // Navigation properties

        public virtual User Staff { get; set; } = null!;
        public virtual ObservableCollectionListSource<BillDetail> BillDetails { get; set; } = new();
    }
}
