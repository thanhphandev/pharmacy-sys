using pharmacy_sys.Models;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.MedicineRepositories;
using pharmacy_sys.Services.LogServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.MedicineServices
{
    public class MedicineService : IMedicineService
    {
        private readonly IMedicineRepository _medicineRepository;
        private readonly IMedicineBatchRepository _medicineBatchRepository;
        private readonly ILogService _logService;
        public MedicineService(IMedicineRepository medicineRepository, IMedicineBatchRepository medicineBatchRepository, ILogService logService)
        {
            _medicineRepository = medicineRepository;
            _medicineBatchRepository = medicineBatchRepository;
            _logService = logService;
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
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "CREATE",
                targetTable: "MedicineBatches",
                targetId: medicineBatch.Id.ToString(),
                message: $"Đã thêm lô thuốc mới với mã {medicineBatch.Id}."
            );
        }

        public List<BatchUsage> DeductMedicineStock(int medicineId, int quantity)
        {
            var batchUsage = _medicineBatchRepository.DeductMedicineStock(medicineId, quantity);
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "DEDUCT",
                targetTable: "MedicineBatches",
                targetId: medicineId.ToString(),
                message: $"Đã trừ {quantity} đơn vị thuốc từ thuốc có mã thuốc {medicineId}.",
                oldValue: JsonSerializer.Serialize(batchUsage),
                newValue: JsonSerializer.Serialize(batchUsage)
            );
            return batchUsage;
        }

        public void DeductSpecificBatches(List<BatchUsage> usages)
        {
            if (usages == null || usages.Count == 0)
            {
                throw new ArgumentException("Danh sách lô thuốc không hợp lệ.");
            }
            foreach (var usage in usages)
            {
                if (usage.Quantity <= 0)
                {
                    throw new ArgumentException("Số lượng thuốc phải lớn hơn 0.");
                }
            }
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "DEDUCT",
                targetTable: "MedicineBatches",
                targetId: usages.First().BatchId.ToString(),
                message: $"Đã trừ thuốc từ lô thuốc có mã {usages.First().BatchId}.",
                newValue: JsonSerializer.Serialize(usages)
             );
            _medicineBatchRepository.DeductSpecificBatches(usages);
        }

        public void DeleteMedicine(int id)
        {
            if(id < 0)
            {
                throw new ArgumentException("Mã thuốc không được bỏ trống.");
            }
            _medicineRepository.DeleteMedicine(id);
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "DELETE",
                targetTable: "Medicines",
                targetId: id.ToString(),
                message: $"Đã xóa thuốc có mã {id}."
            );
        }

        public void DeleteMedicineBatch(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("Mã lô thuốc không hợp lệ.");
            }
            _medicineBatchRepository.DeleteBatch(id);
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "DELETE",
                targetTable: "MedicineBatches",
                targetId: id.ToString(),
                message: $"Đã xóa lô thuốc có mã {id}."
            );
        }

        public List<MedicineProductModel> FilterMedicineProducts(int? groupId = null, decimal? minPrice = null, decimal? maxPrice = null, string? searchText = null)
        {
            var medicineProducts = _medicineRepository.FilterMedicineProducts(groupId, minPrice, maxPrice, searchText);
            return medicineProducts;
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

        public int GetStockQuantityByMedicineCode(int medicineId)
        {
            if(medicineId <= 0)
            {
                throw new ArgumentException("ID không hợp lệ", nameof(medicineId));
            }
            var stockQuantity = _medicineRepository.GetStockQuantityByMedicineCode(medicineId);
            return stockQuantity;
        }

        public void ReturnMedicineToStock(List<BatchUsage> usages)
        {
            if(usages == null || usages.Count == 0)
            {
                throw new ArgumentException("Danh sách lô thuốc không hợp lệ.");
            }
            foreach (var usage in usages)
            {
                if (usage.Quantity <= 0)
                {
                    throw new ArgumentException("Số lượng thuốc phải lớn hơn 0.");
                }
            }
            _medicineBatchRepository.ReturnMedicineToStock(usages);
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "RESTOCK",
                targetTable: "MedicineBatches",
                targetId: usages.First().BatchId.ToString(),
                message: $"Đã hoàn trả thuốc từ lô thuốc có mã {usages.First().BatchId}.",
                oldValue: JsonSerializer.Serialize(usages),
                newValue: JsonSerializer.Serialize(usages)
            );

        }

        public List<Medicine> SearchMedicineByNameOrCode(string searchText)
        {
            var medicines = _medicineRepository.SearchMedicineByNameOrCode(searchText);
            return medicines;
        }

        public void UpdateMedicine(int id, Medicine medicine)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID không hợp lệ", nameof(id));
            }

            // Validate các thuộc tính của đối tượng medicine
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

            var existingMedicine = _medicineRepository.GetMedicineById(id);
            if (existingMedicine == null)
            {
                throw new ArgumentException("Không tìm thấy thuốc có ID này.");
            }

            if (existingMedicine.Code != medicine.Code)
            {
                var existingMedicineWithSameCode = _medicineRepository.GetMedicineByCode(medicine.Code);
                if (existingMedicineWithSameCode != null)
                {
                    throw new ArgumentException("Mã thuốc này đã tồn tại.");
                }
            }

            var oldLogData = new
            {
                existingMedicine.Id,
                existingMedicine.Name,
                existingMedicine.Code,
                existingMedicine.GroupId,
                existingMedicine.UnitTypeId,
                existingMedicine.Price,
                existingMedicine.Image
            };

            var newLogData = new
            {
                medicine.Id,
                medicine.Name,
                medicine.Code,
                medicine.GroupId,
                medicine.UnitTypeId,
                medicine.Price,
                medicine.Image
            };

            _medicineRepository.UpdateMedicine(id, medicine);

            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "UPDATE",
                targetTable: "Medicines",
                targetId: id.ToString(),
                message: $"Đã cập nhật thuốc có mã {id}.",
                oldValue: JsonSerializer.Serialize(oldLogData),
                newValue: JsonSerializer.Serialize(newLogData)
            );
        }


        public void UpdateMedicineBatch(int id, MedicineBatch medicineBatch)
        {
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

            // Lấy thông tin của lô thuốc cũ
            var existingMedicineBatch = _medicineBatchRepository.GetMedicineBatchById(id);
            if (existingMedicineBatch == null)
            {
                throw new ArgumentException("Không tìm thấy lô thuốc có ID này.");
            }

            // Lọc ra các thuộc tính cần thiết để tránh vòng lặp
            var oldLogData = new
            {
                existingMedicineBatch.Id,
                existingMedicineBatch.Quantity,
                existingMedicineBatch.ExpirationDate,
                existingMedicineBatch.ManufactureDate,
                existingMedicineBatch.SupplierId
            };

            _medicineBatchRepository.UpdateBatch(id, medicineBatch);

            var newLogData = new
            {
                medicineBatch.Id,
                medicineBatch.Quantity,
                medicineBatch.ExpirationDate,
                medicineBatch.ManufactureDate,
                medicineBatch.SupplierId
            };

            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "UPDATE",
                targetTable: "MedicineBatches",
                targetId: id.ToString(),
                message: $"Đã cập nhật lô thuốc có mã {id}.",
                oldValue: JsonSerializer.Serialize(oldLogData),
                newValue: JsonSerializer.Serialize(newLogData)
            );
        }


    }
}

