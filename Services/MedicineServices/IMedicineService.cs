using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.MedicineServices
{
    public interface IMedicineService
    {
        public void AddMedicine(Medicine medicine, MedicineBatch medicineBatch);
        List<string> GetAllMedicineCodes();
        Medicine? GetMedicineByCode(string code);
        List<Medicine> GetAllMedicines();
        List<Medicine> SearchMedicineByNameOrCode(string searchText);
        List<Medicine> GetMedicinesByGroupId(int groupId);
        void DeleteMedicine(int id);
        List<MedicineBatch> GetMedicineBatchesById(int id);
        Medicine GetMedicineById(int id);
        void UpdateMedicine(int id, Medicine medicine);
        void UpdateMedicineBatch(int id, MedicineBatch medicineBatch);
        void DeleteMedicineBatch(int id);
        MedicineBatch GetMedicineBatchById(int id);
    }
}
