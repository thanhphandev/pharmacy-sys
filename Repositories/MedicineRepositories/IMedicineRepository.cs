using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Repositories.MedicineRepositories
{
    public interface IMedicineRepository
    {
        public void AddMedicine(Medicine medicine);
        Medicine? GetMedicineByCode(string code);
        Medicine? GetMedicineById(int id);
        List<string> GetAllMedicineCodes();
        List<Medicine> GetAllMedicines();
        List<Medicine> SearchMedicineByNameOrCode(string searchText);
        List<Medicine> GetMedicinesByGroupId(int groupId);
        void DeleteMedicine(int id);
        void UpdateMedicine(int id, Medicine medicine);
        public List<MedicineProductModel> FilterMedicineProducts(
            int? groupId = null,
            decimal? minPrice = null,
            decimal? maxPrice = null,
            string? searchText = null);

    }
}
