using pharmacy_sys.Common;
using pharmacy_sys.Models;
using pharmacy_sys.Presenters.BillPresenter;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.MedicineRepositories;
using pharmacy_sys.Repositories.POSRepositories;
using pharmacy_sys.Services.BillServices;
using pharmacy_sys.Services.LogServices;
using pharmacy_sys.Services.MedicineServices;
using pharmacy_sys.Services.PrintInvoiceServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_sys.Views.BillForm
{
    public partial class BillDetailsView : Form, IBillDetailsView
    {
        private int _billId;
        public BillDetailsView(int billId)
        {
            InitializeComponent();
            _billId = billId;
            var billRepository = new BillRepository();
            var medicineRepository = new MedicineRepository();
            var medicineBatchRepository = new MedicineBatchRepository();
            var logRepository = new LogRepository();

            var logService = new LogService(logRepository);
            var medicineService = new MedicineService(medicineRepository, medicineBatchRepository, logService);
            var printInvoiceService = new PrintInvoiceService(billRepository);

            var billService = new BillService(billRepository, medicineService, logService);
            
            new BillDetailsPresenter(this, billService, printInvoiceService);
        }

        public int BillId { get => _billId; set => _billId = value; }
        public string BillCode { get => txtCode.Text; set => txtCode.Text = value; }
        public string StaffName { get => txtStaffName.Text; set => txtStaffName.Text = value; }
        public DateTime CreatedAt { get => dtpCreatedAt.Value; set => dtpCreatedAt.Value = value; }
        public string Note { get => txtNote.Text; set => txtNote.Text = value; }

        public event EventHandler LoadBillDetails;
        public event EventHandler UpdateBillEvent;
        public event EventHandler PrintBillEvent;

        public void DisplayBillDetails(List<BillDetail> billDetails)
        {
            dgvBillDetails.AutoGenerateColumns = false;
            dgvBillDetails.Columns["colId"].DataPropertyName = "MedicineId";
            dgvBillDetails.Columns["colCode"].DataPropertyName = "MedicineCode";
            dgvBillDetails.Columns["colMedicineName"].DataPropertyName = "MedicineName";
            dgvBillDetails.Columns["colPrice"].DataPropertyName = "PriceFormatted";
            dgvBillDetails.Columns["colQuantity"].DataPropertyName = "Quantity";
            dgvBillDetails.Columns["colUnitType"].DataPropertyName = "UnitType";
            dgvBillDetails.Columns["colAmount"].DataPropertyName = "AmountFormatted";

            var billDetailList = new BindingList<BillDetail>(billDetails);
            dgvBillDetails.DataSource = billDetailList;
        }


        public void DisplayTotalPrice(decimal totalPrice, decimal vat)
        {
            var grandTotal = totalPrice + vat;
            lbAmount.Text = CurrencyFormatter.FormatVietnameseCurrency(totalPrice);
            lbVAT.Text = CurrencyFormatter.FormatVietnameseCurrency(vat);
            lbGrandAmount.Text = CurrencyFormatter.FormatVietnameseCurrency(grandTotal);
        }

        public List<BillDetail> GetCurrentBillDetails()
        {
            var billDetails = new List<BillDetail>();

            foreach (DataGridViewRow row in dgvBillDetails.Rows)
            {
                if (row.IsNewRow) continue;

                try
                {
                    var id = row.Cells["colId"].Value?.ToString();
                    var code = row.Cells["colCode"].Value?.ToString();
                    var name = row.Cells["colMedicineName"].Value?.ToString();
                    var quantityText = row.Cells["colQuantity"].Value?.ToString();
                    var priceText = row.Cells["colPrice"].Value?.ToString();

                    if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(quantityText) || string.IsNullOrWhiteSpace(priceText))
                        continue;

                    if (!int.TryParse(quantityText, out int quantity)) quantity = 1;

                    decimal price = CurrencyFormatter.ParseVietnameseCurrency(priceText);

                    billDetails.Add(new BillDetail
                    {
                        MedicineId = string.IsNullOrWhiteSpace(id) ? 0 : int.Parse(id),
                        BillId = _billId,
                        Quantity = quantity,
                        Price = price,
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lấy dữ liệu dòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return billDetails;
        }


        private void BillDetailsView_Load(object sender, EventArgs e)
        {
            LoadBillDetails?.Invoke(this, EventArgs.Empty);
        }

        private void dgvBillDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.RowIndex >= dgvBillDetails.Rows.Count)
            {
                return;
            }
            if (dgvBillDetails.CurrentCell.OwningColumn.Name == "colDelete")
            {
                var result = MessageBox.Show(
                    "Bạn có chắc muốn xóa? Thuốc đã xóa sẽ không thể thêm lại.",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                    return;
                dgvBillDetails.Rows.RemoveAt(e.RowIndex);

                GetTotal();
            }
        }

        private void dgvBillDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvBillDetails.Columns["colQuantity"].Index)
                return;

            var row = dgvBillDetails.Rows[e.RowIndex];

            var quantityCell = row.Cells["colQuantity"];
            var priceCell = row.Cells["colPrice"];

            if (quantityCell?.Value == null || priceCell?.Value == null)
                return;

            if (!int.TryParse(quantityCell.Value.ToString(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                quantity = 1;
                quantityCell.Value = 1;
            }

            decimal price = CurrencyFormatter.ParseVietnameseCurrency(priceCell.Value.ToString() ?? "");
            decimal amount = quantity * price;

            row.Cells["colAmount"].Value = amount;

            GetTotal();
        }

        private void GetTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvBillDetails.Rows)
            {
                if (!row.IsNewRow)
                {
                    string amountText = row.Cells["colAmount"].Value?.ToString() ?? "0";
                    total += CurrencyFormatter.ParseVietnameseCurrency(amountText);
                }
            }

            decimal vat = total * 0.08m; // 10% VAT (tuỳ chỉnh nếu khác)
            DisplayTotalPrice(total, vat);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateBillEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            PrintBillEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
