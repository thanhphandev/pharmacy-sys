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
        void CreateBill(Bill bill);
        List<Bill> GetAllBills();
        List<Bill> SearchBillByCode(string code);
        Bill? GetBillWithDetails(int billId);
        void DeleteBill(int id);
        void UpdateBill(int id, List<BillDetail> billDetail);
        List<Bill> GetSalesReport(DateTime startDate, DateTime endDate);
    }
}
