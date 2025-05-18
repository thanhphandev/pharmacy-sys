using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.BillServices
{
    public interface IBillService
    {
        List<Bill> GetAllBills();
        List<Bill> SearchBills(string searchText);
        Bill GetBillWithDetails(int billId);
        void DeleteBill(int id);
        void UpdateBill(int id, List<BillDetail> billDetail, string note, DateTime createdAt);
        List<Bill> GetSalesReport(DateTime startDate, DateTime endDate);
    }
}
