using pharmacy_sys.Models;
using pharmacy_sys.Services.CategoryServices;
using pharmacy_sys.Services.MedicineServices;
using pharmacy_sys.Views.ConfirmPasswordForm;
using pharmacy_sys.Views.MedicineForm;
using pharmacy_sys.Views.UnitTypeForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.MedicineManagementPresenter
{
    public class MedicineManagementsPresenter
    {
        private readonly IMedicineManagementView _medicineManagementView;
        private readonly IMedicineService _medicineService;
        private readonly ICategoryService _categoryService;

        public MedicineManagementsPresenter(IMedicineManagementView medicineManagementView, IMedicineService medicineService, ICategoryService categoryService)
        {
            _medicineManagementView = medicineManagementView;
            _medicineService = medicineService;
            _categoryService = categoryService;
            _medicineManagementView.AddUnitType += OnAddUnitType;
            _medicineManagementView.AddMedicine += OnAddMedicine;
            _medicineManagementView.LoadMedicines += OnLoadMedicines;
            _medicineManagementView.RefreshMedicines += OnRefreshMedicines;
            _medicineManagementView.SearchMedicines += OnSearchMedicines;
            _medicineManagementView.FilterMedicines += OnFilterMedicines;
            _medicineManagementView.DeleteMedicine += OnDeleteMedicine;
            _medicineManagementView.ViewMedicineDetails += OnViewMedicineDetails;

        }

        private void OnViewMedicineDetails(object? sender, EventArgs e)
        {
            int selectedMedicine = _medicineManagementView.GetSelectedMedicineId();
            if (selectedMedicine < 0)
            {
                MessageBox.Show("Vui lòng chọn thuốc để xem chi tiết.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MedicineDetailsView medicineDetailsView = new MedicineDetailsView(selectedMedicine);
            medicineDetailsView.ShowDialog();
            LoadMedicines();
        }

        private void OnDeleteMedicine(object? sender, EventArgs e)
        {
            int selectedMedicine = _medicineManagementView.GetSelectedMedicineId();
            if (selectedMedicine == 0)
            {
                MessageBox.Show("Vui lòng chọn thuốc để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserSession.Role != UserRole.Admin)
            {
                MessageBox.Show("Bạn không đủ quyền hạn để thực hiện thao tác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            // ⚠️ Cảnh báo mạnh mẽ hơn
            var result = MessageBox.Show(
                "⚠️ Hành động này sẽ xóa thuốc và toàn bộ các lô thuốc liên quan.\n\nBạn có chắc chắn muốn tiếp tục?",
                "XÁC NHẬN XÓA DỮ LIỆU QUAN TRỌNG",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                using var confirmForm = new ConfirmPasswordView();
                confirmForm.ShowDialog();
                if (!confirmForm.IsPasswordConfirmed)
                {
                    MessageBox.Show("Hủy thao tác vì chưa xác nhận mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    _medicineService.DeleteMedicine(selectedMedicine);
                    MessageBox.Show("Đã xóa thuốc và toàn bộ các lô thuốc liên quan.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    LoadMedicines();
                }
            }
        }


        private void OnFilterMedicines(object? sender, EventArgs e)
        {
            int categoryId = _medicineManagementView.CategoryId;

            List<Medicine> medicines = categoryId == -1
                ? _medicineService.GetAllMedicines()
                : _medicineService.GetMedicinesByGroupId(categoryId);

            _medicineManagementView.DisplayMedicines(medicines);
        }


        private void OnSearchMedicines(object? sender, EventArgs e)
        {
            var search = _medicineManagementView.SearchText;
            if(string.IsNullOrWhiteSpace(search))
            {
                MessageBox.Show("Vui lòng nhập tên hoặc mã thuốc để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var medicines = _medicineService.SearchMedicineByNameOrCode(search);
            _medicineManagementView.DisplayMedicines(medicines);
        }

        private void OnRefreshMedicines(object? sender, EventArgs e)
        {
            LoadMedicines();
        }

        private void OnAddMedicine(object? sender, EventArgs e)
        {
            AddMedicineView addMedicineView = new AddMedicineView();
            addMedicineView.ShowDialog();
            LoadMedicines();
        }

        private void OnLoadMedicines(object? sender, EventArgs e)
        {
            LoadMedicines();
        }

        private void OnAddUnitType(object? sender, EventArgs e)
        {
            UnitTypeView unitTypeView = new UnitTypeView();
            unitTypeView.ShowDialog();
        }

        private void LoadMedicines()
        {
            _medicineManagementView.SearchText = string.Empty;
            var medicines = _medicineService.GetAllMedicines();
            var categories = _categoryService.GetAllCategories();
            _medicineManagementView.LoadMedicineGroups(categories);
            _medicineManagementView.DisplayMedicines(medicines);
        }
    }
}
