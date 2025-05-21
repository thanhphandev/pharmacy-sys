using pharmacy_sys.Models;
using pharmacy_sys.Services.SupplierServices;
using pharmacy_sys.Views.SupplierForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.SupplierPresenter
{
    public class SupplierPresenter
    {
        private readonly ISupplierView _view;
        private readonly ISupplierService _supplierService;
        public SupplierPresenter(ISupplierView view, ISupplierService supplierService)
        {
            _view = view;
            _supplierService = supplierService;
            _view.OpenAddSupplier += OnAddSupplier;
            _view.DeleteSupplier += OnDeleteSupplier;
            _view.OpenEditSupplier += OnEditSupplier;
            _view.SearchSupplier += OnSearchSupplier;
            _view.RefreshSupplier += OnRefreshSupplier;
            _view.LoadSuppliers += OnLoadSuppliers;
            _view.ExportSuppliers += OnExportSuppliers;
            _view.ImportSuppliers += OnImportSuppliers;
        }

        private void OnImportSuppliers(object? sender, EventArgs e)
        {
            var (filePath, fileType) = _view.PromptOpenFile();
            if (string.IsNullOrWhiteSpace(filePath)) return;

            try
            {
                List<Supplier> imported = fileType switch
                {
                    "excel" => _supplierService.ImportFromExcel(filePath),
                    "csv" => _supplierService.ImportFromCsv(filePath),
                    _ => throw new InvalidOperationException("Định dạng tệp không hợp lệ!")
                };

                if (imported.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu nào được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var existingSuppliers = _supplierService.GetAllSuppliers();
                var duplicates = new List<Supplier>();

                foreach (var supplier in imported)
                {
                    var match = existingSuppliers.FirstOrDefault(s => s.Name.Equals(supplier.Name, StringComparison.OrdinalIgnoreCase));
                    if (match != null)
                    {
                        duplicates.Add(supplier);
                    }
                }

                // Nếu có trùng, hỏi người dùng có muốn ghi đè không
                if (duplicates.Count > 0)
                {
                    var result = MessageBox.Show(
                        $"Phát hiện {duplicates.Count} nhà cung cấp trùng tên.\nBạn có muốn ghi đè dữ liệu cũ không?",
                        "Xác nhận ghi đè",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    bool overwrite = result == DialogResult.Yes;

                    foreach (var supplier in imported)
                    {
                        var match = existingSuppliers.FirstOrDefault(s => s.Name.Equals(supplier.Name, StringComparison.OrdinalIgnoreCase));
                        if (match != null)
                        {
                            if (overwrite)
                            {
                                match.Phone = supplier.Phone;
                                match.Address = supplier.Address ?? string.Empty;
                                _supplierService.UpdateSupplier(match.Id, match);
                            }
                            // else: bỏ qua nếu không ghi đè
                        }
                        else
                        {
                            _supplierService.AddSupplier(supplier.Name, supplier.Phone, supplier.Address ?? string.Empty);
                        }
                    }
                }
                else
                {
                    // Nếu không có trùng thì thêm tất cả
                    foreach (var supplier in imported)
                    {
                        _supplierService.AddSupplier(supplier.Name, supplier.Phone, supplier.Address ?? string.Empty);
                    }
                }

                MessageBox.Show("Nhập dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi nhập dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void OnExportSuppliers(object? sender, EventArgs e)
        {
            var suppliers = _supplierService.GetAllSuppliers();
            if (suppliers == null || !suppliers.Any())
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (selectedPath, fileType) = _view.PromptSaveFile();
            if (string.IsNullOrWhiteSpace(selectedPath)) return;

            try
            {
                switch (fileType)
                {
                    case "excel":
                        _supplierService.ExportToExcel(suppliers, selectedPath);
                        break;
                    case "csv":
                        _supplierService.ExportToCsv(suppliers, selectedPath);
                        break;
                    default:
                        MessageBox.Show("Định dạng tệp không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xuất dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void OnLoadSuppliers(object? sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void OnRefreshSupplier(object? sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void OnSearchSupplier(object? sender, EventArgs e)
        {
            string searchText = _view.SearchText;
            var suppliers = _supplierService.SearchSuppliers(searchText);
            _view.DisplaySuppliers(suppliers);
            if (suppliers.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _view.SearchText = string.Empty;
        }

        private void OnEditSupplier(object? sender, EventArgs e)
        {
            var currentSupplier = _view.GetSelectedSupplier();
            if(currentSupplier == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SupplierAddView view = new SupplierAddView
            {
                SupplierId = currentSupplier.Id,
                SupplierName = currentSupplier.Name,
                SupplierPhone = currentSupplier.Phone,
                SupplierAddress = currentSupplier.Address ?? "",
                IsEditMode = true,
                LabelHeader = "Cập nhật thông tin nhà cung cấp"
            };

            view.ShowDialog();
            LoadSuppliers();

        }

        private void OnDeleteSupplier(object? sender, EventArgs e)
        {
            try
            {
                var currentSupplier = _view.GetSelectedSupplier();
                if (currentSupplier != null)
                {
                    var result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa nhà cung cấp này không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        _supplierService.DeleteSupplier(currentSupplier.Id);
                        LoadSuppliers();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Vui lòng chọn nhà cung cấp để xóa!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Đã xảy ra lỗi khi xóa nhà cung cấp: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void OnAddSupplier(object? sender, EventArgs e)
        {
            var addForm = new SupplierAddView();
            addForm.ShowDialog();

            LoadSuppliers();

        }

        private void LoadSuppliers()
        {
            var suppliers = _supplierService.GetAllSuppliers();
            _view.DisplaySuppliers(suppliers);
        }
    }
}
