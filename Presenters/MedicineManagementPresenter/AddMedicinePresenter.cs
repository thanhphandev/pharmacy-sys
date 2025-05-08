using pharmacy_sys.Models;
using pharmacy_sys.Services.CategoryServices;
using pharmacy_sys.Services.MedicineServices;
using pharmacy_sys.Services.SupplierServices;
using pharmacy_sys.Services.UnitTypeServices;
using pharmacy_sys.Views.MedicineForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.MedicineManagementPresenter
{
    public class AddMedicinePresenter
    {
        private readonly IAddMedicineView _addMedicineView;
        private readonly IMedicineService _medicineService;
        private readonly ICategoryService _categoryService;
        private readonly IUnitTypeService _unitTypeService;
        private readonly ISupplierService _supplierService;

        public AddMedicinePresenter
        (
            IAddMedicineView addMedicineView,
            IMedicineService medicineService,
            ICategoryService categoryService,
            IUnitTypeService unitTypeService,
            ISupplierService supplierService
        )
        {
            _addMedicineView = addMedicineView;
            _medicineService = medicineService;
            _categoryService = categoryService;
            _unitTypeService = unitTypeService;
            _supplierService = supplierService;
            _addMedicineView.LoadDataEvent += OnLoadDataEvent;
            _addMedicineView.AddMedicineEvent += OnAddMedicineEvent;
            _addMedicineView.LeaveCodeTextBoxEvent += OnLeaveCodeTextBoxEvent;
            _addMedicineView.UpdateMedicineBatch += OnUpdateMedicineBatchEvent;
        }

        private void OnUpdateMedicineBatchEvent(object? sender, EventArgs e)
        {
            try
            {
                int supplierId = _addMedicineView.SupplierId;
                int quantity = _addMedicineView.Quantity;
                DateTime expirationDate = _addMedicineView.ExpirationDate;
                DateTime manufactureDate = _addMedicineView.ManufactureDate;

                var medicineBatch = new MedicineBatch
                {
                    Quantity = quantity,
                    ExpirationDate = expirationDate,
                    ManufactureDate = manufactureDate,
                    SupplierId = supplierId,
                    MedicineId = _addMedicineView.Id
                };

                _medicineService.UpdateMedicineBatch(_addMedicineView.Id, medicineBatch);
                MessageBox.Show("Cập nhật lô thuốc thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _addMedicineView.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnLeaveCodeTextBoxEvent(object? sender, EventArgs e)
        {
            string code = _addMedicineView.Code.Trim();
            var medicine = _medicineService.GetMedicineByCode(code);
            if (medicine != null)
            {
                AutoFillMedicineFields(medicine);
            }
            
        }

        private void OnLoadDataEvent(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void OnAddMedicineEvent(object? sender, EventArgs e)
        {
            string code = _addMedicineView.Code;
            string medicineName = _addMedicineView.MedicineName;
            decimal price = _addMedicineView.Price;
            string? description = _addMedicineView.Description;
            string? composition = _addMedicineView.Composition;
            string medicineImage = _addMedicineView.MedicineImage;
            int groupId = _addMedicineView.GroupId;
            int unitTypeId = _addMedicineView.UnitTypeId;
            int supplierId = _addMedicineView.SupplierId;
            int quantity = _addMedicineView.Quantity;
            DateTime expirationDate = _addMedicineView.ExpirationDate;
            DateTime manufactureDate = _addMedicineView.ManufactureDate;

            try
            {
                var medicine = new Medicine
                {
                    Code = code,
                    Name = medicineName,
                    Price = price,
                    Description = description,
                    Composition = composition,
                    Image = medicineImage,
                    GroupId = groupId,
                    UnitTypeId = unitTypeId
                };
                var medicineBatch = new MedicineBatch
                {
                    Quantity = quantity,
                    ExpirationDate = expirationDate,
                    ManufactureDate = manufactureDate,
                    MedicineId = 0, // This will be set by the database when the medicine is added
                    SupplierId = supplierId,
                };
                _medicineService.AddMedicine(medicine, medicineBatch);
                _addMedicineView.ClearFields();
                MessageBox.Show("Thêm thuốc thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        void LoadData()
        {         
            var medicineGroups = _categoryService.GetAllCategories();
            var unitTypes = _unitTypeService.GetAllUnitTypes();
            var suppliers = _supplierService.GetAllSuppliers();
            List<string> medicineCodes = _medicineService.GetAllMedicineCodes();
            _addMedicineView.SetAutoCompleteForCodeTextBox(medicineCodes);
            _addMedicineView.LoadMedicineGroups(medicineGroups);
            _addMedicineView.LoadUnitTypes(unitTypes);
            _addMedicineView.LoadSuppliers(suppliers);
        }

        private void AutoFillMedicineFields(Medicine medicine)
        {
            _addMedicineView.Code = medicine.Code;
            _addMedicineView.MedicineName = medicine.Name;
            _addMedicineView.Price = medicine.Price;
            _addMedicineView.Description = medicine.Description;
            _addMedicineView.Composition = medicine.Composition;
            _addMedicineView.GroupId = medicine.GroupId;
            _addMedicineView.UnitTypeId = medicine.UnitTypeId;
            _addMedicineView.MedicineImage = medicine.Image;
        }
    }
}
