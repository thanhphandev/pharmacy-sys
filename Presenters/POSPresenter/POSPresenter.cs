using pharmacy_sys.Common;
using pharmacy_sys.Models;
using pharmacy_sys.Services.CategoryServices;
using pharmacy_sys.Services.MedicineServices;
using pharmacy_sys.Services.POSServices;
using pharmacy_sys.Services.PrintInvoiceServices;
using pharmacy_sys.Views.POSForm;
using pharmacy_sys.Views.ReportForm;
using QuestPDF.Fluent;
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
        private readonly IPrintInvoiceService _printInvoiceService;

        public POSPresenter(IPOSView view, IMedicineService medicineService, ICategoryService categoryService, IPOSService posService, IPrintInvoiceService printInvoiceService)
        {
            _view = view;
            _medicineService = medicineService;
            _categoryService = categoryService;
            _posService = posService;
            _printInvoiceService = printInvoiceService;
            _view.LoadMedicineProductsEvent += OnLoadMedicineProducts;
            _view.SearchMedicines += OnFilterOrSearchMedicines;
            _view.FilterMedicines += OnFilterOrSearchMedicines;
            _view.RefreshMedicineProductsEvent += OnRefreshMedicineProducts;
            _view.PurchaseMedicinesEvent += OnPurchaseMedicines;
        }

        private void OnPurchaseMedicines(object? sender, EventArgs e)
        {
            int currentStaffId = UserSession.Id;
            decimal grandAmount = _view.GrandAmount;
            decimal totalPrice = _view.TotalPrice;

            string Note = _view.Note;
            List<MedicineProductModel> cartItems = _view.GetCartItems();
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống. Vui lòng thêm sản phẩm trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn thanh toán không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.No)
                {
                    return;
                }
                Bill bill = _posService.PurchaseMedicine(currentStaffId, cartItems, grandAmount, totalPrice, Note);
                
                var askPrint = MessageBox.Show("Thanh toán thành công! Bạn có muốn xuất hóa đơn không?.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (askPrint == DialogResult.Yes)
                {
                    _printInvoiceService.PrintInvoice(bill.Id);
                }

                _view.ClearCartItems();
                _view.Note = string.Empty;
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
