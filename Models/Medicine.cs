using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public required string? Description { get; set; }
        public required string? Composition { get; set; }
        public required string Image { get; set; }
        public int GroupId { get; set; }
        public int UnitTypeId { get; set; }

        // Navigation properties
        public virtual UnitType UnitType { get; set; } = null!;
        public virtual MedicineGroup Group { get; set; } = null!;
        public virtual ObservableCollectionListSource<MedicineBatch> MedicineBatches { get; set; } = new();
        public string CategoryName => Group?.Name ?? "No Category";
        public string UnitTypeName => UnitType?.Name ?? "No UnitType";
    }
}
