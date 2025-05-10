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

        public void DeductMedicineStock(int medicineId, int quantity)
        {
            using var context = new PharmacyDbContext();

            var batches = context.MedicineBatches
                .Where(b => b.MedicineId == medicineId && b.Quantity > 0)
                .OrderBy(b => b.ExpirationDate) // FEFO
                .ToList();

            int remaining = quantity;

            foreach (var batch in batches)
            {
                if (remaining <= 0) break;

                if (batch.Quantity >= remaining)
                {
                    batch.Quantity -= remaining;
                    remaining = 0;
                }
                else
                {
                    remaining -= batch.Quantity;
                    batch.Quantity = 0;
                }
            }

            if (remaining > 0)
            {
                throw new InvalidOperationException("Không đủ thuốc trong kho để xử lý giao dịch.");
            }

            context.SaveChanges();
        }

    }
}
