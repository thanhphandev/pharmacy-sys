using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacy_sys.Models;
using pharmacy_sys.Services.SupplierServices;
using pharmacy_sys.Views.SupplierForm;

namespace pharmacy_sys.Presenters.SupplierPresenter
{
    public class SupplierAddPresenter
    {
        private readonly ISupplierAddView _view;
        private readonly ISupplierService _supplierService;
        public SupplierAddPresenter(ISupplierAddView view, ISupplierService supplierService)
        {
            _view = view;
            _supplierService = supplierService;
            _view.AddSupplier += OnAddSupplier;
            _view.UpdateSupplier += OnUpdateSupplier;
        }

        private void OnUpdateSupplier(object? sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(_view.SupplierName) || string.IsNullOrEmpty(_view.SupplierPhone))
                {
                    MessageBox.Show("Tên và số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _supplierService.UpdateSupplier(_view.SupplierId, new Supplier
                {
                    Name = _view.SupplierName,
                    Phone = _view.SupplierPhone,
                    Address = _view.SupplierAddress
                });

                MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _view.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đã có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnAddSupplier(object? sender, EventArgs e)
        {
            try
            {
                _supplierService.AddSupplier(_view.SupplierName,_view.SupplierPhone, _view.SupplierAddress);
                _view.ClearFields();
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _view.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đã có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
