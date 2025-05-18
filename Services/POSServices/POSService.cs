using pharmacy_sys.Common;
using pharmacy_sys.Models;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.POSRepositories;
using pharmacy_sys.Services.LogServices;
using pharmacy_sys.Services.MedicineServices;
using pharmacy_sys.Services.PrintInvoiceServices;
using pharmacy_sys.Views.ReportForm;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.POSServices
{
    public class POSService : IPOSService
    {
        private readonly IBillRepository _billRepository;
        private readonly IMedicineService _medicineService;
        private readonly ILogService _logService;

        public POSService(IBillRepository billRepository, IMedicineService medicineService, ILogService logService)
        {
            _billRepository = billRepository;
            _medicineService = medicineService;
            _logService = logService;
        }

        public Bill PurchaseMedicine(int staffId, List<MedicineProductModel> medicineProducts, decimal totalAmount, decimal totalPrice, string? note)
        {
            if (medicineProducts == null || medicineProducts.Count <= 0)
                throw new ArgumentException("Danh sách thuốc không được rỗng.");

            string code = BillCodeGenerator.Generate();
            var bill = new Bill
            {
                StaffId = staffId,
                Code = code,
                Note = note,
                VAT = 0.08m, // 8% VAT,
                GrandAmount = totalAmount,
                CreatedAt = DateTime.Now,
                TotalPrice = totalPrice,
                BillDetails = new()
            };

            foreach (var product in medicineProducts)
            {
                if (product.Quantity <= 0)
                    throw new ArgumentException($"Số lượng thuốc {product.Name} không hợp lệ.");

                int stock = _medicineService.GetStockQuantityByMedicineCode(product.Id);
                if (stock < product.Quantity)
                    throw new ArgumentException($"Số lượng thuốc {product.Name} không đủ trong kho.");

                var usages = _medicineService.DeductMedicineStock(product.Id, product.Quantity);

                var billDetail = new BillDetail
                {
                    MedicineId = product.Id,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    BatchUsageJson = JsonSerializer.Serialize(usages)
                };

                bill.BillDetails.Add(billDetail);
            }

            _billRepository.CreateBill(bill);
            _logService.CreateLogAction(               
                staffId: UserSession.Id,
                action: "CREATE",
                targetTable: "Bills",
                targetId: bill.Id.ToString(),
                message: $"Đã tạo hóa đơn mới với mã {bill.Code} với tổng giá trị {CurrencyFormatter.FormatVietnameseCurrency(totalPrice)}."
            );
            return bill;
        }
    }
}
