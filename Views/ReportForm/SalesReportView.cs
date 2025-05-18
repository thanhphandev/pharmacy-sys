using pharmacy_sys.Models;
using pharmacy_sys.Presenters.ReportPresenter;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.MedicineRepositories;
using pharmacy_sys.Repositories.POSRepositories;
using pharmacy_sys.Services.BillServices;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace pharmacy_sys.Views.ReportForm
{
    public partial class SalesReportView : Form, ISalesReportView
    {
        public SalesReportView()
        {
            InitializeComponent();
            var medicineRepository = new MedicineRepository();
            var medicineBatchRepository = new MedicineBatchRepository();
            var billRepository = new BillRepository();
            var logRepository = new LogRepository();

            var logService = new LogService(logRepository);
            var medicineService = new MedicineService(medicineRepository, medicineBatchRepository, logService);

            var billService = new BillService(billRepository, medicineService, logService);
            new SalesReportPresenter(this, billService);

        }

        public DateTime StartDate { get => dtpStartDate.Value; set => dtpStartDate.Value = value; }
        public DateTime EndDate { get => dtpEndDate.Value; set => dtpEndDate.Value = value; }

        public string GroupBy => cbGroupBy.SelectedItem as string ?? "Ngày";

        public event EventHandler LoadReport;
        public event EventHandler RefreshReport;
        public event EventHandler PrintReport;

        public void DisplaySalesReport(List<SalesReport> salesReports)
        {
            if (salesReports == null || salesReports.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu báo cáo để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSalesReport.DataSource = null;
                chartSales.Series["Revenue"].Points.Clear();
                return;
            }

            // Cấu hình DataGridView
            dgvSalesReport.AutoGenerateColumns = false;
            dgvSalesReport.Columns["colDate"].DataPropertyName = nameof(SalesReport.Date);
            dgvSalesReport.Columns["colTotalRevenue"].DataPropertyName = nameof(SalesReport.TotalRevenue);
            dgvSalesReport.Columns["colTotalBills"].DataPropertyName = nameof(SalesReport.TotalBills);
            dgvSalesReport.Columns["colQuantitySold"].DataPropertyName = nameof(SalesReport.TotalQuantitySold);
            dgvSalesReport.DataSource = null;
            dgvSalesReport.DataSource = salesReports;

            // Xác định định dạng ngày theo lựa chọn nhóm
            string groupBy = GroupBy ?? "Ngày";
            string dateFormat = groupBy switch
            {
                "Ngày" => "dd/MM/yyyy",
                "Tháng" => "MM/yyyy",
                "Năm" => "yyyy",
                _ => "dd/MM/yyyy"
            };

            // Reset biểu đồ
            var chartArea = chartSales.ChartAreas[0];
            var series = chartSales.Series["Revenue"];
            series.Points.Clear();

            // Thêm điểm dữ liệu theo thứ tự thời gian
            foreach (var report in salesReports.OrderBy(r => r.Date))
            {
                string label = report.Date.ToString(dateFormat);
                series.Points.AddXY(label, report.TotalRevenue);
            }

            // Cấu hình biểu đồ
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            chartArea.AxisX.Title = groupBy;
            chartArea.AxisY.Title = "Doanh thu (VNĐ)";
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisY.LabelStyle.Format = "#,##0₫";
            chartSales.Titles.Clear();
            chartSales.Titles.Add($"Biểu đồ doanh thu theo {groupBy.ToLower()}");
        }

        private void SalesReportView_Load(object sender, EventArgs e)
        {
            cbGroupBy.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadReport?.Invoke(this, EventArgs.Empty);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadReport?.Invoke(this, EventArgs.Empty);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbGroupBy.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            RefreshReport?.Invoke(this, EventArgs.Empty);
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            PrintReport?.Invoke(this, EventArgs.Empty);
        }
    }
}
