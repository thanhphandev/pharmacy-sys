using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClosedXML.Excel;
using pharmacy_sys.Common;
using pharmacy_sys.Models;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.SupplierRepositories;
using pharmacy_sys.Services.LogServices;

namespace pharmacy_sys.Services.SupplierServices
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly ILogService _logService;

        public SupplierService(ISupplierRepository supplierRepository, ILogService logService)
        {
            _supplierRepository = supplierRepository;
            _logService = logService;
        }

        public void AddSupplier(string name, string phone, string address)
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                throw new ArgumentException("Tên và số điện thoại không được để trống");
            }

            var checkPhone = DataValidator.IsValidPhoneNumber(phone);
            if (!checkPhone)
            {
                throw new ArgumentException("Số điện thoại không hợp lệ");
            }

            var supplier = new Supplier
            {
                Name = name,
                Phone = phone,
                Address = address
            };

            int id = _supplierRepository.AddSupplier(supplier);
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "CREATE",
                targetTable: "Suppliers",
                targetId: id.ToString(),
                message: $"Đã thêm nhà cung cấp {supplier.Name}."
            );
        }

        public void DeleteSupplier(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID không hợp lệ", nameof(id));
            }

            if (_supplierRepository.IsSupplierReferenced(id))
            {
                throw new InvalidOperationException($"Không thể xóa nhà cung cấp với ID = {id} vì đang được sử dụng.");
            }


            _supplierRepository.DeleteSupplier(id);
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "DELETE",
                targetTable: "Suppliers",
                targetId: id.ToString(),
                message: $"Đã xóa nhà cung cấp có ID {id}."
            );
        }

        public void ExportToCsv(List<Supplier> suppliers, string filePath)
        {
            using var writer = new StreamWriter(filePath);
            writer.WriteLine("ID,Tên nhà cung cấp,Số điện thoại,Địa chỉ");  
            foreach(var s in suppliers)
            {
                writer.WriteLine($"{s.Id},{s.Name},{s.Phone},{s.Address}");
            }
        }

        public void ExportToExcel(List<Supplier> suppliers, string filePath)
        {
            using var workbook = new XLWorkbook();
            var sheet = workbook.Worksheets.Add("Nhà cung cấp");

            sheet.Cell(1, 1).Value = "ID";
            sheet.Cell(1, 2).Value = "Tên nhà cung cấp";
            sheet.Cell(1, 3).Value = "Số điện thoại";
            sheet.Cell(1, 4).Value = "Địa chỉ";

            for (int i = 0; i < suppliers.Count; i++)
            {
                var supplier = suppliers[i];
                sheet.Cell(i + 2, 1).Value = supplier.Id;
                sheet.Cell(i + 2, 2).Value = supplier.Name;
                sheet.Cell(i + 2, 3).Value = supplier.Phone;
                sheet.Cell(i + 2, 4).Value = supplier.Address;
            }   

            sheet.Columns().AdjustToContents();
            workbook.SaveAs(filePath);
        }

        public List<Supplier> GetAllSuppliers()
        {
            var suppliers = _supplierRepository.GetAllSuppliers();
            
            return suppliers;
        }

        public List<Supplier> ImportFromCsv(string filePath)
        {
            var suppliers = new List<Supplier>();
            var lines = File.ReadAllLines(filePath).Skip(1); // Skip header

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts.Length >= 4)
                {
                    suppliers.Add(new Supplier
                    {
                        Id = 0,
                        Name = parts[1].Trim(),
                        Phone = parts[2].Trim(),
                        Address = parts[3].Trim()
                    });
                }
            }

            return suppliers;
        }

        public List<Supplier> ImportFromExcel(string filePath)
        {
            var suppliers = new List<Supplier>();
            using var workbook = new XLWorkbook(filePath);
            var worksheet = workbook.Worksheets.First();

            var rows = worksheet.RangeUsed()?.RowsUsed().Skip(1); // Skip header
            if (rows == null) return suppliers;

            foreach (var row in rows)
            {
                var supplier = new Supplier
                {
                    Id = 0,
                    Name = row.Cell(2).GetString(),
                    Phone = row.Cell(3).GetString(),
                    Address = row.Cell(4).GetString()
                };
                suppliers.Add(supplier);
            }

            return suppliers;
        }

        public List<Supplier> SearchSuppliers(string searchText)
        {
            var suppliers = _supplierRepository.SearchSupplierByName(searchText);
            if (suppliers == null || suppliers.Count == 0)
            {
                return new List<Supplier>();
            }
            return suppliers;
        }

        public void UpdateSupplier(int id, Supplier supplier)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID không hợp lệ", nameof(id));
            }

            if (supplier == null)
            {
                throw new ArgumentNullException(nameof(supplier), "Nhà cung cấp không được null");
            }
            var supplierToUpdate = _supplierRepository.GetSupplierById(id);
            if (supplierToUpdate == null)
            {
                throw new ArgumentException("Không tìm thấy nhà cung cấp với ID này", nameof(id));
            }
            supplier.Id = supplierToUpdate.Id;
            _supplierRepository.UpdateSupplier(id, supplier);
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "UPDATE",
                targetTable: "Suppliers",
                targetId: id.ToString(),
                message: $"Đã cập nhật nhà cung cấp có ID {id}.",
                oldValue: JsonSerializer.Serialize(supplierToUpdate),
                newValue: JsonSerializer.Serialize(supplier)
            );
        }
    }
}
