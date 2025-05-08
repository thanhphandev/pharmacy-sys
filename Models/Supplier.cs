using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace pharmacy_sys.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public string? Address { get; set; }
        // Navigation property

        public virtual ObservableCollectionListSource<MedicineBatch> MedicineBatches { get; set; } = new();
    }
}
