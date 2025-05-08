using Microsoft.EntityFrameworkCore;
using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Repositories.MedicineRepositories
{
    public class MedicineBatchRepository : IMedicineBatchRepository
    {
        public void AddMedicineBatch(MedicineBatch medicineBatch)
        {
            using var context = new PharmacyDbContext();
            context.MedicineBatches.Add(medicineBatch);
            context.SaveChanges();
        }

        public void DeleteBatch(int id)
        {
            using var context = new PharmacyDbContext();
            var medicineBatch = context.MedicineBatches.FirstOrDefault(m => m.Id == id);
            if (medicineBatch == null)
            {
                throw new ArgumentException("Mã lô thuốc không tồn tại.");
            }
            context.MedicineBatches.Remove(medicineBatch);
            context.SaveChanges();
        }

        public List<MedicineBatch> GetMedicBatchesByMedicineId(int id)
        {
            using var context = new PharmacyDbContext();
            var medicineBatches = context.MedicineBatches
                .Include(m => m.Supplier)
                .Where(m => m.MedicineId == id)
                .ToList();
            return medicineBatches;
        }

        public MedicineBatch GetMedicineBatchById(int id)
        {
            using var context = new PharmacyDbContext();
            var medicineBatch = context.MedicineBatches
                .FirstOrDefault(m => m.Id == id);
            if (medicineBatch == null)
            {
                throw new ArgumentException("Không tìm thấy lô này.");
            }
            return medicineBatch;
        }

        public void UpdateBatch(int id, MedicineBatch medicineBatch)
        {
            using var context = new PharmacyDbContext();
            var existingBatch = context.MedicineBatches.FirstOrDefault(m => m.Id == id);
            if (existingBatch == null)
            {
                throw new ArgumentException("Mã lô thuốc không tồn tại.");
            }
            //Note: not permitted to update MedicineId
            existingBatch.Quantity = medicineBatch.Quantity;
            existingBatch.ExpirationDate = medicineBatch.ExpirationDate;
            existingBatch.ManufactureDate = medicineBatch.ManufactureDate;
            existingBatch.SupplierId = medicineBatch.SupplierId;
            context.SaveChanges();
        }
    }
}
