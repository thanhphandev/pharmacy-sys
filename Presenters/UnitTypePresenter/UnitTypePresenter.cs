using pharmacy_sys.Services.UnitTypeServices;
using pharmacy_sys.Views.UnitTypeForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.UnitTypePresenter
{
    public class UnitTypePresenter
    {
        private readonly IUnitTypeView _unitTypeView;
        private readonly IUnitTypeService _unitTypeService;
        public UnitTypePresenter(IUnitTypeView unitTypeView, IUnitTypeService unitTypeService)
        {
            _unitTypeView = unitTypeView;
            _unitTypeService = unitTypeService;
            _unitTypeView.AddUnitType += OnAddUnitType;
            _unitTypeView.LoadUnitTypes += OnLoadUnitTypes;
            _unitTypeView.DeleteUnitType += OnDeleteUnitType;
            _unitTypeView.UpdateUnitType += OnUpdateUnitType;
        }

        private void OnUpdateUnitType(object? sender, EventArgs e)
        {
            var selected = _unitTypeView.GetSelectedUnitType();
            if (selected == null)
            {
                MessageBox.Show("Vui lòng chọn đơn vị thuốc để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newName = _unitTypeView.UnitTypeName;
            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Tên không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _unitTypeService.UpdateUnitType(selected.Id, newName);
                _unitTypeView.UnitTypeName = string.Empty;
                LoadUnitTypes();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnDeleteUnitType(object? sender, EventArgs e)
        {
            var selected = _unitTypeView.GetSelectedUnitType();
            if (selected == null)
            {
                MessageBox.Show("Vui lòng chọn đơn vị thuốc để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn vị thuốc này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return;
                }

                _unitTypeService.DeleteUnitType(selected.Id);
                LoadUnitTypes();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OnLoadUnitTypes(object? sender, EventArgs e)
        {
            LoadUnitTypes();
        }

        private void LoadUnitTypes()
        {
            var unitTypes = _unitTypeService.GetAllUnitTypes();
            _unitTypeView.DisplayUnitType(unitTypes);
        }

        private void OnAddUnitType(object? sender, EventArgs e)
        {
            string unitTypeName = _unitTypeView.UnitTypeName;
            if (string.IsNullOrEmpty(unitTypeName))
            {
                MessageBox.Show("Vui lòng nhập tên đơn vị thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                _unitTypeService.AddUnitType(unitTypeName);
                _unitTypeView.UnitTypeName = string.Empty;
                LoadUnitTypes();
                MessageBox.Show($"Đơn vị thuốc '{unitTypeName}' đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đã có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
