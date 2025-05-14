using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Repositories.MedicineRepositories
{
    public interface IMedicineBatchRepository
    {
        void AddMedicineBatch(MedicineBatch medicineBatch);
        List<MedicineBatch> GetMedicBatchesByMedicineId(int id);
        void UpdateBatch(int id, MedicineBatch medicineBatch);
        void DeleteBatch(int id);
        MedicineBatch GetMedicineBatchById(int id);
        List<BatchUsage> DeductMedicineStock(int medicineId, int quantity);
        void ReturnMedicineToStock(List<BatchUsage> usages);
        void DeductSpecificBatches(List<BatchUsage> usages);
    }
}
