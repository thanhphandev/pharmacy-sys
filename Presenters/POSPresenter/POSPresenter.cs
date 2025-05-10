using pharmacy_sys.Models;
using pharmacy_sys.Services.CategoryServices;
using pharmacy_sys.Services.MedicineServices;
using pharmacy_sys.Services.POSServices;
using pharmacy_sys.Views.POSForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.POSPresenter
{
    public class POSPresenter
    {
        private readonly IPOSView _view;
        private readonly IMedicineService _medicineService;
        private readonly ICategoryService _categoryService;
        private readonly IPOSService _posService;

        public POSPresenter(IPOSView view, IMedicineService medicineService, ICategoryService categoryService, IPOSService posService)
        {
            _view = view;
            _medicineService = medicineService;
            _categoryService = categoryService;
            _posService = posService;
            _view.LoadMedicineProductsEvent += OnLoadMedicineProducts;
            _view.SearchMedicines += OnFilterOrSearchMedicines;
            _view.FilterMedicines += OnFilterOrSearchMedicines;
            _view.RefreshMedicineProductsEvent += OnRefreshMedicineProducts;
            _view.PurchaseMedicinesEvent += OnPurchaseMedicines;
        }

        private void OnPurchaseMedicines(object? sender, EventArgs e)
        {
            int currentStaffId = 1; // ID của nhân viên hiện tại, có thể thay đổi sau này
            string CustomerName = _view.CustomerName;
            List<MedicineProductModel> cartItems = _view.GetCartItems();
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống. Vui lòng thêm sản phẩm trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                _posService.PurchaseMedicine(1, cartItems, CustomerName); // 1 là ID của nhân viên hiện tại, có thể thay đổi sau này
                
                MessageBox.Show("Thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _view.ClearCartItems();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void OnRefreshMedicineProducts(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void OnFilterOrSearchMedicines(object? sender, EventArgs e)
        {
            var categoryId = _view.CategoryId;
            var searchText = _view.SearchText;
            var minPrice = _view.MinPrice;
            var maxPrice = _view.MaxPrice;

            // Gọi service filter tổng hợp
            var filteredMedicines = _medicineService.FilterMedicineProducts(
                groupId: categoryId == -1 ? null : categoryId,
                minPrice: minPrice,
                maxPrice: maxPrice,
                searchText: string.IsNullOrWhiteSpace(searchText) ? null : searchText
            );

            if (filteredMedicines.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào phù hợp.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _view.LoadMedicineProducts(filteredMedicines);
        }


        private void OnLoadMedicineProducts(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var medicineGroups = _categoryService.GetAllCategories();
            var medicineProducts = _medicineService.FilterMedicineProducts();
            _view.LoadPriceRanges();
            if (medicineProducts.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _view.LoadMedicineProducts(medicineProducts);
            _view.LoadMedicineGroups(medicineGroups);
        }
    }
}
