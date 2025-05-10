using pharmacy_sys.Models;
using pharmacy_sys.Services.CategoryServices;
using pharmacy_sys.Services.MedicineServices;
using pharmacy_sys.Services.UnitTypeServices;
using pharmacy_sys.Views.MedicineForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.MedicineManagementPresenter
{
    public class MedicineDetailsPresenter
    {
        private readonly IMedicineDetailsView _view;
        private readonly IMedicineService _medicineService;
        private readonly ICategoryService _categoryService;
        private readonly IUnitTypeService _unitTypeService;
        private readonly int _medicineId;

        public MedicineDetailsPresenter
            (int medicineId,
            IMedicineDetailsView view,
            IMedicineService medicineService,
            ICategoryService categoryService,
            IUnitTypeService unitTypeService
            )
        {
            _medicineId = medicineId;
            _view = view;
            _medicineService = medicineService;
            _categoryService = categoryService;
            _unitTypeService = unitTypeService;
            _view.LoadDataEvent += OnLoadDataEvent;
            _view.UpdateMedicineEvent += OnUpdateMedicineEvent;
            _view.DeleteMedicineBatchEvent += OnDeleteMedicineBatchEvent;
            _view.UpdateMedicineBatchEvent += OnUpdateMedicineBatchEvent;
        }

        private void OnUpdateMedicineBatchEvent(object? sender, EventArgs e)
        {
            try
            {
                int selectedBatchId = _view.GetSelectedMedicineBatchId();
                if (selectedBatchId <= 0)
                {
                    MessageBox.Show("Vui lòng chọn một lô thuốc để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var batch = _medicineService.GetMedicineBatchById(selectedBatchId);
                if (batch == null)
                {
                    MessageBox.Show("Không tìm thấy lô thuốc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var editView = new AddMedicineView
                {
                    IsEditMode = true,
                    MedicineBatchId = selectedBatchId,
                };

                editView.LoadDataEvent += (s, e) =>
                {
                    editView.Id = batch.MedicineId;
                    editView.Quantity = batch.Quantity;
                    editView.ManufactureDate = batch.ManufactureDate;
                    editView.ExpirationDate = batch.ExpirationDate;
                    editView.SupplierId = batch.SupplierId;
                    editView.MedicineName = _view.MedicineName;
                    editView.Code = _view.Code;
                    editView.Price = _view.Price;
                    editView.GroupId = _view.GroupId;
                    editView.UnitTypeId = _view.UnitTypeId;
                    editView.Description = _view.Description;
                    editView.Composition = _view.Composition;
                    editView.MedicineImage = _view.MedicineImage;
                };

                editView.ShowDialog();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật lô thuốc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OnDeleteMedicineBatchEvent(object? sender, EventArgs e)
        {
            try
            {
                int selectedBatchId = _view.GetSelectedMedicineBatchId();
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa lô thuốc này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                _medicineService.DeleteMedicineBatch(selectedBatchId);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadData();
            }
        }

        private void OnUpdateMedicineEvent(object? sender, EventArgs e)
        {
            try
            {
                var medicine = new Medicine
                {
                    Id = _medicineId,
                    Code = _view.Code,
                    Name = _view.MedicineName,
                    Price = _view.Price,
                    GroupId = _view.GroupId,
                    UnitTypeId = _view.UnitTypeId,
                    Description = _view.Description,
                    Composition = _view.Composition,
                    Image = _view.MedicineImage
                };

                _medicineService.UpdateMedicine(_medicineId, medicine);
                MessageBox.Show("Cập nhật thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadData();
            }
        }

        private void OnLoadDataEvent(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var categories = _categoryService.GetAllCategories();
            var unitTypes = _unitTypeService.GetAllUnitTypes();
            var medicineBatches = _medicineService.GetMedicineBatchesById(_medicineId);
            var medicine = _medicineService.GetMedicineById(_medicineId);

            _view.LoadMedicineGroups(categories);
            _view.LoadUnitTypes(unitTypes);
            _view.DisplayMedicineBatches(medicineBatches);
            _view.DisplayMedicineDetails(medicine);
        }
    }
}
