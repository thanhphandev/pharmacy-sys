using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Models
{
    public class PriceRange
    {
        public string Name { get; set; } = "";
        public decimal? Min { get; set; }
        public decimal? Max { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
