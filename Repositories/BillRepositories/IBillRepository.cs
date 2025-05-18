using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Repositories.POSRepositories
{
    public interface IBillRepository
    {
        Bill CreateBill(Bill bill);
        List<Bill> GetAllBills();
        List<Bill> SearchBillByCode(string code);
        Bill GetBillWithDetails(int billId);
        void DeleteBill(int id);
        void UpdateBill(int id, List<BillDetail> billDetail, string note, DateTime createdAt);
        List<Bill> GetSalesReport(DateTime startDate, DateTime endDate);
    }
}
