using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.POSServices
{
    public interface IPOSService
    {
        Bill PurchaseMedicine(int staffId, List<MedicineProductModel> medicineProducts, decimal totalAmount, decimal totalPrice,string? note);
    }
}
