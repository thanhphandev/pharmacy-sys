using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace pharmacy_sys.Models
{
    public class UnitType
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        // Navigation property
        public virtual ObservableCollectionListSource<Medicine> Medicines { get; set; } = new();
    }
}
