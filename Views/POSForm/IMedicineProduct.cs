using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.POSForm
{
    public interface IMedicineProduct
    {
        int Id { get; set; }
        string Code { get; set; }
        string MedicineName { get; set; }
        decimal Price { get; set; }
        string MedicineImage { get; set; }
        string UnitTypeName { get; set; }
        int Quantity { get; set; }
        event EventHandler AddToCartClicked;

    }
}
