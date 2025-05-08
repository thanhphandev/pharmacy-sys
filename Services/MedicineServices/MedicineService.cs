using pharmacy_sys.Models;
using pharmacy_sys.Repositories.MedicineRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.MedicineServices
{
    public class MedicineService : IMedicineService
    {
        private readonly IMedicineRepository _medicineRepository;
        private readonly IMedicineBatchRepository _medicineBatchRepository;
        public MedicineService(IMedicineRepository medicineRepository, IMedicineBatchRepository medicineBatchRepository)
        {
            _medicineRepository = medicineRepository;
            _medicineBatchRepository = medicineBatchRepository;
        }

        public void AddMedicine(Medicine medicine, MedicineBatch medicineBatch)
        {
            // validate
            if (string.IsNullOrEmpty(medicine.Code) || string.IsNullOrEmpty(medicine.Name))
            {
                throw new ArgumentException("Mã thuốc và tên thuốc không được bỏ trống.");
            }
            if (medicineBatch.Quantity <= 0)
            {
                throw new ArgumentException("Số lượng thuốc phải lớn hơn 0.");
            }
            if (medicineBatch.ExpirationDate <= DateTime.Now)
            {
                throw new ArgumentException("Ngày hết hạn thuốc phải lớn hơn ngày hiện tại.");
            }
            if (medicineBatch.ManufactureDate >= DateTime.Now)
            {
                throw new ArgumentException("Ngày sản xuất thuốc phải nhỏ hơn ngày hiện tại.");
            }
            if (medicineBatch.SupplierId <= 0)
            {
                throw new ArgumentException("Nhà cung cấp không hợp lệ.");
            }
            if (medicine.GroupId <= 0)
            {
                throw new ArgumentException("Nhóm thuốc không hợp lệ.");
            }
            if (medicine.UnitTypeId <= 0)
            {
                throw new ArgumentException("Đơn vị tính không hợp lệ.");
            }
            if(medicine.Price <= 0)
            {
                throw new ArgumentException("Giá thuốc phải lớn hơn 0.");
            }
            if(string.IsNullOrEmpty(medicine.Image))
            {
                throw new ArgumentException("Hình ảnh thuốc không được bỏ trống.");
            }
            

            var existingMedicine = _medicineRepository.GetMedicineByCode(medicine.Code);
            if(existingMedicine != null)
            {
                // Nếu thuốc đã tồn tại, dùng Id hiện có
                medicineBatch.MedicineId = existingMedicine.Id;
            }
            else
            {
                // Nếu chưa có, thêm mới thuốc
                _medicineRepository.AddMedicine(medicine);
                medicineBatch.MedicineId = medicine.Id;
            }
            _medicineBatchRepository.AddMedicineBatch(medicineBatch);
        }

        public void DeleteMedicine(int id)
        {
            if(id < 0)
            {
                throw new ArgumentException("Mã thuốc không được bỏ trống.");
            }
            _medicineRepository.DeleteMedicine(id);
        }

        public void DeleteMedicineBatch(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("Mã lô thuốc không hợp lệ.");
            }
            _medicineBatchRepository.DeleteBatch(id);
        }

        public List<string> GetAllMedicineCodes()
        {
            List<string> medicineCodes = _medicineRepository.GetAllMedicineCodes();
            return medicineCodes;
        }

        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> medicines = _medicineRepository.GetAllMedicines();
            return medicines;
        }

        public MedicineBatch GetMedicineBatchById(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("ID không hợp lệ", nameof(id));
            }
            MedicineBatch medicineBatch = _medicineBatchRepository.GetMedicineBatchById(id);
            return medicineBatch;
        }

        public List<MedicineBatch> GetMedicineBatchesById(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("ID không hợp lệ", nameof(id));
            }

            var medicineBatches = _medicineBatchRepository.GetMedicBatchesByMedicineId(id);
            return medicineBatches;
        }

        public Medicine? GetMedicineByCode(string code)
        {
            var medicine = _medicineRepository.GetMedicineByCode(code);
            return medicine;
        }

        public Medicine GetMedicineById(int id)
        {
            var medicine = _medicineRepository.GetMedicineById(id);
            if (medicine == null)
            {
                throw new ArgumentException("Không tìm thấy thông tin đơn vị thuốc này!.");
            }
            return medicine;
        }

        public List<Medicine> GetMedicinesByGroupId(int groupId)
        {
            var medicines = _medicineRepository.GetMedicinesByGroupId(groupId);
            return medicines;
        }

        public List<Medicine> SearchMedicineByNameOrCode(string searchText)
        {
            var medicines = _medicineRepository.SearchMedicineByNameOrCode(searchText);
            return medicines;
        }

        public void UpdateMedicine(int id, Medicine medicine)
        {
            if(id <= 0)
            {
                throw new ArgumentException("ID không hợp lệ", nameof(id));
            }
            // validate
            if (string.IsNullOrEmpty(medicine.Code) || string.IsNullOrEmpty(medicine.Name))
            {
                throw new ArgumentException("Mã thuốc và tên thuốc không được bỏ trống.");
            }
            
            if (medicine.GroupId <= 0)
            {
                throw new ArgumentException("Nhóm thuốc không hợp lệ.");
            }
            if (medicine.UnitTypeId <= 0)
            {
                throw new ArgumentException("Đơn vị tính không hợp lệ.");
            }
            if (medicine.Price <= 0)
            {
                throw new ArgumentException("Giá thuốc phải lớn hơn 0.");
            }
            if (string.IsNullOrEmpty(medicine.Image))
            {
                throw new ArgumentException("Hình ảnh thuốc không được bỏ trống.");
            }
            _medicineRepository.UpdateMedicine(id, medicine);
        }

        public void UpdateMedicineBatch(int id, MedicineBatch medicineBatch)
        {
            if(medicineBatch.Quantity <= 0)
            {
                throw new ArgumentException("Số lượng thuốc phải lớn hơn 0.");
            }
            if (medicineBatch.ExpirationDate <= DateTime.Now)
            {
                throw new ArgumentException("Ngày hết hạn thuốc phải lớn hơn ngày hiện tại.");
            }
            if (medicineBatch.ManufactureDate >= DateTime.Now)
            {
                throw new ArgumentException("Ngày sản xuất thuốc phải nhỏ hơn ngày hiện tại.");
            }
            if (medicineBatch.SupplierId <= 0)
            {
                throw new ArgumentException("Nhà cung cấp không hợp lệ.");
            }

            _medicineBatchRepository.UpdateBatch(id, medicineBatch);
        }
    }
}
