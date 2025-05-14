using pharmacy_sys.Models;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.POSRepositories;
using pharmacy_sys.Services.LogServices;
using pharmacy_sys.Services.MedicineServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.BillServices
{
    public class BillService : IBillService
    {
        private readonly IBillRepository _billRepository;
        private readonly IMedicineService _medicineService;
        private readonly ILogService _logService;

        public BillService(IBillRepository billRepository, IMedicineService medicineService, ILogService logService)
        {
            _billRepository = billRepository;
            _medicineService = medicineService;
            _logService = logService;
        }

        public void DeleteBill(int id)
        {
            if(id <= 0)
                throw new ArgumentException("Mã hóa đơn không hợp lệ.");
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "DELETE",
                targetTable: "Bills",
                targetId: id.ToString(),
                message: $"Đã xóa hóa đơn có mã {id}."
            );
            _billRepository.DeleteBill(id);
        }

        public List<Bill> GetAllBills()
        {
            var bills = _billRepository.GetAllBills();
            return bills;
        }

        public Bill? GetBillWithDetails(int id)
        {
            if(id <= 0)
                throw new ArgumentException("Mã hóa đơn không hợp lệ.");

            var bill = _billRepository.GetBillWithDetails(id);

            return bill;
        }

        public List<Bill> GetSalesReport(DateTime startDate, DateTime endDate)
        {
            var bills = _billRepository.GetSalesReport(startDate, endDate);
            return bills;
        }

        public List<Bill> SearchBills(string searchText)
        {
            var bills = _billRepository.SearchBillByCode(searchText);
            return bills;
        }

        public void UpdateBill(int id, List<BillDetail> newDetails)
        {
            if (id <= 0)
                throw new ArgumentException("Mã hóa đơn không hợp lệ.");
            if (newDetails == null || newDetails.Count == 0)
                throw new ArgumentException("Chi tiết hóa đơn không thể trống.");

            var oldBill = _billRepository.GetBillWithDetails(id);
            if (oldBill == null)
                throw new ArgumentException("Không tìm thấy hóa đơn.");

            foreach (var oldDetail in oldBill.BillDetails)
            {
                if (!string.IsNullOrWhiteSpace(oldDetail.BatchUsageJson))
                {
                    var usages = JsonSerializer.Deserialize<List<BatchUsage>>(oldDetail.BatchUsageJson)
                                 ?? new List<BatchUsage>();
                    _medicineService.ReturnMedicineToStock(usages);
                }
            }

            // 2. Trừ kho và ghi lại BatchUsageJson
            foreach (var detail in newDetails)
            {
                if (detail.Quantity <= 0)
                    throw new ArgumentException($"Số lượng thuốc không hợp lệ: {detail.MedicineName}");

                int stock = _medicineService.GetStockQuantityByMedicineCode(detail.MedicineId);
                if (stock < detail.Quantity)
                    throw new ArgumentException($"Số lượng thuốc {detail.MedicineName} không đủ trong kho.");

                var usages = _medicineService.DeductMedicineStock(detail.MedicineId, detail.Quantity);
                detail.BatchUsageJson = JsonSerializer.Serialize(usages);
            }

            _billRepository.UpdateBill(id, newDetails);
            var oldLogData = oldBill.BillDetails.Select(d => new
            {
                d.MedicineId,
                d.Quantity,
                d.Price,
                d.BatchUsageJson
            });

            var newLogData = newDetails.Select(d => new
            {
                d.MedicineId,
                d.Quantity,
                d.Price,
                d.BatchUsageJson
            });

            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "UPDATE",
                targetTable: "Bills",
                targetId: id.ToString(),
                oldValue: JsonSerializer.Serialize(oldLogData),
                newValue: JsonSerializer.Serialize(newLogData),
                message: $"Đã cập nhật hóa đơn có mã {id}."
            );

        }


    }
}
