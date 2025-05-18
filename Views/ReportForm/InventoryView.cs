using pharmacy_sys.Models;
using pharmacy_sys.Presenters.ReportPresenter;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.MedicineRepositories;
using pharmacy_sys.Services.LogServices;
using pharmacy_sys.Services.MedicineServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_sys.Views.ReportForm
{
    public partial class InventoryView : Form, IInventoryView
    {
        public InventoryView()
        {
            InitializeComponent();
            var batchRepository = new MedicineBatchRepository();
            new InventoryPresenter(this, batchRepository);
        }

        public event EventHandler LoadReportView;
        public event EventHandler RefreshData;
        public event EventHandler PrintReportEvent;

        public void DisplayExpiringMedicines(List<MedicineReportItem> items)
        {
            // Cấu hình DataGridView
            dgvExpiringMedicines.AutoGenerateColumns = false;
            dgvExpiringMedicines.Columns["colName"].DataPropertyName = nameof(MedicineReportItem.Name);
            dgvExpiringMedicines.Columns["colQuantity"].DataPropertyName = nameof(MedicineReportItem.Quantity);
            dgvExpiringMedicines.Columns["colExpiredDate"].DataPropertyName = nameof(MedicineReportItem.ExpirationDate);
            dgvExpiringMedicines.Columns["colCategory"].DataPropertyName = nameof(MedicineReportItem.Category);
            dgvExpiringMedicines.DataSource = null;
            dgvExpiringMedicines.DataSource = items;
        }

        public void DisplayLowStockMedicines(List<MedicineReportItem> items)
        {
            dgvLowStock.AutoGenerateColumns = false;
            dgvLowStock.Columns["colName2"].DataPropertyName = nameof(MedicineReportItem.Name);
            dgvLowStock.Columns["colQuantity2"].DataPropertyName = nameof(MedicineReportItem.Quantity);
            dgvLowStock.Columns["colCategory2"].DataPropertyName = nameof(MedicineReportItem.Category);
            dgvLowStock.DataSource = null;
            dgvLowStock.DataSource = items;
        }

        public void DisplaySummary(StockSummary summary)
        {
            txtMedicine.Text = summary.TotalMedicines.ToString();
            txtMedicineBatch.Text = summary.TotalMedicineBatch.ToString();
            txtExpired.Text = summary.ExpiringCount.ToString();
            txtLowStock.Text = summary.LowStockCount.ToString();
        }

        private void InventoryView_Load(object sender, EventArgs e)
        {
            LoadReportView?.Invoke(this, EventArgs.Empty);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData?.Invoke(this, EventArgs.Empty);
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            PrintReportEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
