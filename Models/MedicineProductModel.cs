using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Models
{
    public class MedicineProductModel
    {
        public int Id { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public required string MedicineImage { get; set; }
        public required string UnitTypeName { get; set; }
        public int Quantity { get; set; }
        
    }
}
