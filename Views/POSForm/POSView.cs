using pharmacy_sys.Common;
using pharmacy_sys.Models;
using pharmacy_sys.Presenters.POSPresenter;
using pharmacy_sys.Repositories.CategoryRepositories;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.MedicineRepositories;
using pharmacy_sys.Repositories.POSRepositories;
using pharmacy_sys.Services.CategoryServices;
using pharmacy_sys.Services.LogServices;
using pharmacy_sys.Services.MedicineServices;
using pharmacy_sys.Services.POSServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_sys.Views.POSForm
{
    public partial class POSView : Form, IPOSView
    {
        private bool _isInitialized = false;
        public POSView()
        {
            InitializeComponent();

            var medicineRepository = new MedicineRepository();
            var medicineBatchRepository = new MedicineBatchRepository();
            var categoryRepository = new CategoryRepository();
            var billRepository = new BillRepository();
            var logRepository = new LogRepository();

            var logService = new LogService(logRepository);
            var categoryService = new CategoryService(categoryRepository, logService);
            var medicineService = new MedicineService(medicineRepository, medicineBatchRepository, logService);
            var posService = new POSService(billRepository, medicineService, logService);
            
            new POSPresenter(this, medicineService, categoryService, posService);
        }

        public string SearchText { get => txtSearch.Text; set => txtSearch.Text = value; }
        public int CategoryId
        {
            get
            {
                if (int.TryParse(cbCategory.SelectedValue?.ToString(), out int result))
                {
                    return result;
                }
                return -1;
            }
            set
            {
                cbCategory.SelectedValue = value;
                cbCategory.Enabled = false;
            }
        }

        public decimal? MinPrice
        {
            get
            {
                if (cbFilterPrice.SelectedItem is PriceRange range)
                    return range.Min;
                return null;
            }
        }

        public decimal? MaxPrice
        {
            get
            {
                if (cbFilterPrice.SelectedItem is PriceRange range)
                    return range.Max;
                return null;
            }
        }

        public string Note { get => txtNote.Text; set => txtNote.Text = value; }
        public decimal TotalPrice { get => CurrencyFormatter.ParseVietnameseCurrency(txtTotalPrice.Text); set => txtTotalPrice.Text = CurrencyFormatter.FormatVietnameseCurrency(value); }

        public event EventHandler LoadMedicineProductsEvent;
        public event EventHandler SearchMedicines;
        public event EventHandler FilterMedicines;
        public event EventHandler RefreshMedicineProductsEvent;
        public event EventHandler PurchaseMedicinesEvent;

        public void LoadMedicineGroups(List<MedicineGroup> medicineGroups)
        {
            var allOption = new MedicineGroup { Id = -1, Name = "Tất cả" };
            medicineGroups.Insert(0, allOption);

            cbCategory.DataSource = null;
            cbCategory.DataSource = medicineGroups;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.SelectedIndex = 0;
            _isInitialized = true;
        }

        public void LoadMedicineProducts(List<MedicineProductModel> medicineProducts)
        {
            MedicineProductPanel.Controls.Clear();
            foreach (var product in medicineProducts)
            {
                AddMedicineProductToPanel(product);
            }
        }

        private void AddMedicineProductToPanel(MedicineProductModel medicine)
        {
            var medicineProduct = new MedicineProduct()
            {
                Code = medicine.Code,
                Id = medicine.Id,
                MedicineImage = medicine.MedicineImage,
                MedicineName = medicine.Name,
                Price = medicine.Price,
                UnitTypeName = medicine.UnitTypeName,
                Quantity = medicine.Quantity
            };

            MedicineProductPanel.Controls.Add((MedicineProduct)medicineProduct);
            medicineProduct.AddToCartClicked += (sender, e) =>
            {
                AddOrUpdateCartItem(product: (MedicineProduct)sender);
            };
        }

        private void AddOrUpdateCartItem(MedicineProduct product)
        {

            if (product.Quantity <= 0)
            {
                MessageBox.Show("Thuốc hiện đã hết hàng, không thể thêm vào giỏ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in CartItemsDataGrid.Rows)
            {
                if (string.Equals(row.Cells["dgvCode"].Value?.ToString(), product.Code, StringComparison.OrdinalIgnoreCase))
                {
                    int currentQuantity = Convert.ToInt32(row.Cells["dgvQuantity"].Value);
                    int newQuantity = currentQuantity + 1;

                    if (newQuantity > product.Quantity)
                    {
                        MessageBox.Show("Không đủ số lượng thuốc trong kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    row.Cells["dgvQuantity"].Value = newQuantity;
                    decimal price = CurrencyFormatter.ParseVietnameseCurrency(row.Cells["dgvPrice"].Value?.ToString() ?? "");

                    row.Cells["dgvAmount"].Value = CurrencyFormatter.FormatVietnameseCurrency(newQuantity * price);
                    GetTotal();
                    return;
                }
            }

            CartItemsDataGrid.Rows.Add(new object[]
            {
                CartItemsDataGrid.Rows.Count + 1,
                product.Id,
                product.Code,
                product.UnitTypeName,
                product.MedicineName,
                1, // Initial quantity
                CurrencyFormatter.FormatVietnameseCurrency(product.Price),
                CurrencyFormatter.FormatVietnameseCurrency(product.Price) // Amount
            });
            GetTotal();
        }

        private void GetTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in CartItemsDataGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    total += CurrencyFormatter.ParseVietnameseCurrency(row.Cells["dgvAmount"].Value?.ToString() ?? "");
                }
            }

            txtTotal.Text = CurrencyFormatter.FormatVietnameseCurrency(total);
            decimal vat = total * 0.08m; // 8%
            txtVAT.Text = CurrencyFormatter.FormatVietnameseCurrency(vat);
            txtTotalPrice.Text = CurrencyFormatter.FormatVietnameseCurrency(vat + total);
        }

        public void ClearCartItems()
        {
            CartItemsDataGrid.Rows.Clear();

            GetTotal();
        }

        private void POSView_Load(object sender, EventArgs e)
        {
            LoadMedicineProductsEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchMedicines?.Invoke(this, EventArgs.Empty);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isInitialized) return;
            FilterMedicines?.Invoke(this, EventArgs.Empty);
        }

        public void LoadPriceRanges()
        {
            var priceRanges = new List<PriceRange>
            {
                new PriceRange { Name = "Tất cả", Min = null, Max = null },
                new PriceRange { Name = "< 50.000", Min = null, Max = 50000 },
                new PriceRange { Name = "50.000 – 100.000", Min = 50000, Max = 100000 },
                new PriceRange { Name = "100.000 – 200.000", Min = 100000, Max = 200000 },
                new PriceRange { Name = "> 200.000", Min = 200000, Max = null },
            };

            cbFilterPrice.DataSource = priceRanges;
            cbFilterPrice.DisplayMember = "Name";
            cbFilterPrice.SelectedIndex = 0;
            _isInitialized = true;
        }

        private void cbFilterPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isInitialized) return;
            FilterMedicines?.Invoke(this, EventArgs.Empty);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshMedicineProductsEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearCartItems();
        }

        private void CartItemsDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo là cột số lượng và hàng hợp lệ
            if (e.RowIndex < 0 || e.ColumnIndex != CartItemsDataGrid.Columns["dgvQuantity"].Index)
                return;

            var row = CartItemsDataGrid.Rows[e.RowIndex];

            var quantityCell = row.Cells["dgvQuantity"];
            var priceCell = row.Cells["dgvPrice"];

            if (quantityCell?.Value == null || priceCell?.Value == null)
                return;

            if (!int.TryParse(quantityCell.Value.ToString(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                quantityCell.Value = 1;
                quantity = 1;
            }

            decimal price = CurrencyFormatter.ParseVietnameseCurrency(priceCell.Value.ToString() ?? "");
            row.Cells["dgvAmount"].Value = CurrencyFormatter.FormatVietnameseCurrency(quantity * price);

            GetTotal();
        }


        private void CartItemsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= CartItemsDataGrid.Rows.Count)
            {
                return;
            }
            if (CartItemsDataGrid.CurrentCell.OwningColumn.Name == "dgvDelete")
            {

                CartItemsDataGrid.Rows.RemoveAt(e.RowIndex);

                GetTotal();
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PurchaseMedicinesEvent?.Invoke(this, EventArgs.Empty);
        }

        public List<MedicineProductModel> GetCartItems()
        {
            var cartItems = new List<MedicineProductModel>();

            foreach (DataGridViewRow row in CartItemsDataGrid.Rows)
            {
                if (row.IsNewRow) continue;
                int id = Convert.ToInt32(row.Cells["dgvId"].Value);
                var code = row.Cells["dgvCode"].Value?.ToString() ?? "";
                var name = row.Cells["dgvName"].Value?.ToString() ?? "";
                var unit = row.Cells["dgvUnitType"].Value?.ToString() ?? "";
                int quantity = Convert.ToInt32(row.Cells["dgvQuantity"].Value);
                decimal price = CurrencyFormatter.ParseVietnameseCurrency(row.Cells["dgvPrice"].Value?.ToString() ?? "");
                cartItems.Add(new MedicineProductModel
                {
                    Id = id,
                    Code = code,
                    Name = name,
                    UnitTypeName = unit,
                    Quantity = quantity,
                    Price = price,
                    MedicineImage = ""
                });
            }

            return cartItems;
        }

    }
}
