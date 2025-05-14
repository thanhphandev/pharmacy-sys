using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Repositories.POSRepositories
{
    public class BillRepository : IBillRepository
    {
        public void CreateBill(Bill bill)
        {
            using var context = new PharmacyDbContext();
            context.Bills.Add(bill);
            context.SaveChanges();
        }

        public void DeleteBill(int id)
        {
            using var context = new PharmacyDbContext();
            var bill = context.Bills.Find(id);
            if (bill == null)
            {
                throw new ArgumentException("Không tìm thấy hóa đơn có ID này.");
            }
            context.Bills.Remove(bill);
            context.SaveChanges();
        }

        public List<Bill> GetAllBills()
        {
            using var context = new PharmacyDbContext();
            return context.Bills.Include(b => b.Staff).ToList();
        }

        public Bill? GetBillWithDetails(int billId)
        {
            using var context = new PharmacyDbContext();
            return context.Bills
                .Include(b => b.BillDetails)
                .ThenInclude(d => d.Medicine)
                .Include(b => b.Staff)
                .FirstOrDefault(b => b.Id == billId);
        }


        public List<Bill> SearchBillByCode(string code)
        {
            using var context = new PharmacyDbContext();
            return context.Bills
                .Include(b => b.Staff)
                .Where(b => b.Code.Contains(code))
                .ToList();
        }

        public void UpdateBill(int id, List<BillDetail> updatedDetails)
        {
            using var context = new PharmacyDbContext();
            var bill = context.Bills
                              .Include(b => b.BillDetails)
                              .FirstOrDefault(b => b.Id == id);

            if (bill == null)
            {
                throw new ArgumentException("Không tìm thấy hóa đơn có ID này.");
            }
            decimal totalAmount = 0;
            foreach (var detail in updatedDetails)
            {
                totalAmount += detail.Quantity * detail.Price;
            }
            bill.TotalPrice = totalAmount + (totalAmount * 0.08m);
            context.BillDetails.RemoveRange(bill.BillDetails);

            context.BillDetails.AddRange(updatedDetails);

            context.SaveChanges();
        }

        public List<Bill> GetSalesReport(DateTime startDate, DateTime endDate)
        {
            using var context = new PharmacyDbContext();
            return context.Bills
                .Where(b => b.CreatedAt >= startDate && b.CreatedAt <= endDate)
                .Include(b => b.BillDetails)
                .ThenInclude(d => d.Medicine)
                .Include(b => b.Staff)
                .ToList();
        }

    }
}
