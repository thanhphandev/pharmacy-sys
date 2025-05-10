using Microsoft.EntityFrameworkCore;
using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Repositories.MedicineRepositories
{
    public class MedicineRepository : IMedicineRepository
    {
        public void AddMedicine(Medicine medicine)
        {
            using var context = new PharmacyDbContext();
            context.Medicines.Add(medicine);
            context.SaveChanges();
        }

        public void DeleteMedicine(int id)
        {
            using var context = new PharmacyDbContext();
            var medicine = context.Medicines.FirstOrDefault(m => m.Id == id);
            if (medicine == null)
            {
                throw new ArgumentException("Mã thuốc không tồn tại.");
            }
            context.Medicines.Remove(medicine);
            context.SaveChanges();
        }

        public List<MedicineProductModel> FilterMedicineProducts(
            int? groupId = null,
            decimal? minPrice = null,
            decimal? maxPrice = null,
            string? searchText = null)
        {
            using var context = new PharmacyDbContext();

            // Bước 1: Lọc các lô thuốc có số lượng > 0 và gom nhóm
            var batchData = context.MedicineBatches
                .Where(b => b.Quantity > 0)
                .GroupBy(b => b.MedicineId)
                .Select(g => new
                {
                    MedicineId = g.Key,
                    Quantity = g.Sum(b => b.Quantity)
                })
                .ToList(); // thực hiện tại DB

            // Bước 2: Join sang bảng Medicine và lọc tiếp (sử dụng LINQ to Objects)
            var query = batchData
                .Join(context.Medicines.Include(m => m.UnitType).Include(m => m.Group).AsEnumerable(), // tải dữ liệu vào bộ nhớ
                      batch => batch.MedicineId,
                      medicine => medicine.Id,
                      (batch, medicine) => new
                      {
                          Medicine = medicine,
                          Quantity = batch.Quantity
                      });

            // Áp dụng filter trên dữ liệu đã tải
            if (groupId.HasValue)
            {
                query = query.Where(x => x.Medicine.GroupId == groupId.Value);
            }

            if (minPrice.HasValue)
            {
                query = query.Where(x => x.Medicine.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                query = query.Where(x => x.Medicine.Price <= maxPrice.Value);
            }

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string lowered = searchText.ToLower();
                query = query.Where(x =>
                    (x.Medicine.Name?.ToLower().Contains(lowered) ?? false) ||
                    (x.Medicine.Code?.ToLower().Contains(lowered) ?? false));
            }

            return query.Select(x => new MedicineProductModel
            {
                Id = x.Medicine.Id,
                Code = x.Medicine.Code,
                Name = x.Medicine.Name,
                Price = x.Medicine.Price,
                MedicineImage = x.Medicine.Image,
                Quantity = x.Quantity,
                UnitTypeName = x.Medicine.UnitType?.Name
            }).ToList();
        }



        public List<string> GetAllMedicineCodes()
        {
            using var context = new PharmacyDbContext();
            var medicineCodes = context.Medicines.Select(m => m.Code).ToList();
            return medicineCodes;
        }

        public List<Medicine> GetAllMedicines()
        {
            using var context = new PharmacyDbContext();
            var medicines = context.Medicines
                .Include(m => m.Group)
                .Include(m => m.UnitType)
                .ToList();
            return medicines;
        }

        public Medicine? GetMedicineByCode(string code)
        {
            using var context = new PharmacyDbContext();
            var medicine = context.Medicines.FirstOrDefault(m => m.Code == code);
            if (medicine == null)
            {
                return null;
            }
            return medicine;
        }

        public Medicine? GetMedicineById(int id)
        {
            using var context = new PharmacyDbContext();
            var medicine = context.Medicines
                .Include(m => m.Group)
                .Include(m => m.UnitType)
                .FirstOrDefault(m => m.Id == id);
            if (medicine == null)
            {
                return null;
            }
            return medicine;
        }


        public List<Medicine> GetMedicinesByGroupId(int groupId)
        {
            using var context = new PharmacyDbContext();
            var medicines = context.Medicines.Include(m => m.Group)
                .Include(m => m.UnitType)
                .Where(m => m.GroupId == groupId).ToList();
            return medicines;
        }

        public List<Medicine> SearchMedicineByNameOrCode(string searchText)
        {
            using var context = new PharmacyDbContext();

            searchText = searchText?.Trim().ToLower() ?? "";

            var medicines = context.Medicines
                .Include(m => m.Group)
                .Include(m => m.UnitType)
                .Where(m => m.Name.ToLower().Contains(searchText) || m.Code.ToLower().Contains(searchText))
                .ToList();

            return medicines;
        }

        public void UpdateMedicine(int id, Medicine medicine)
        {
            using var context = new PharmacyDbContext();
            var existingMedicine = context.Medicines.FirstOrDefault(m => m.Id == id);
            if (existingMedicine == null)
            {
                throw new ArgumentException("Mã thuốc không tồn tại.");
            }
            existingMedicine.Code = medicine.Code;
            existingMedicine.Name = medicine.Name;
            existingMedicine.Price = medicine.Price;
            existingMedicine.Description = medicine.Description;
            existingMedicine.Composition = medicine.Composition;
            existingMedicine.GroupId = medicine.GroupId;
            existingMedicine.UnitTypeId = medicine.UnitTypeId;
            existingMedicine.Image = medicine.Image;

            context.SaveChanges();

        }
    }
}
