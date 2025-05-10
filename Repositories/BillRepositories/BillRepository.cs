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
    }
}
