using pharmacy_sys.Models;
using pharmacy_sys.Repositories.POSRepositories;
using pharmacy_sys.Services.MedicineServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.POSServices
{
    public class POSService : IPOSService
    {
        private readonly IBillRepository _billRepository;
        private readonly IMedicineService _medicineService;

        public POSService(IBillRepository billRepository, IMedicineService medicineService)
        {
            _billRepository = billRepository;
            _medicineService = medicineService;
        }
        public void PurchaseMedicine(int staffId, List<MedicineProductModel> medicineProducts, string? customerName)
        {
            if (medicineProducts == null || !medicineProducts.Any())
                throw new ArgumentException("Danh sách thuốc không được rỗng.");

            var bill = new Bill
            {
                StaffId = staffId,
                CustomerName = customerName ?? "",
                CreatedAt = DateTime.Now,
                BillDetails = new()
            };

            foreach (var product in medicineProducts)
            {
                _medicineService.DeductMedicineStock(product.Id, product.Quantity);
                bill.BillDetails.Add(new BillDetail
                {
                    MedicineId = product.Id,
                    Quantity = product.Quantity,
                    Price = product.Price
                });
            }

            _billRepository.CreateBill(bill);

        }

    }
}
