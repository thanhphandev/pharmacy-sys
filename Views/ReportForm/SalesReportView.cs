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

        public void DisplaySalesReport(List<SalesReport> salesReports)
        {
            dgvSalesReport.AutoGenerateColumns = false;

            dgvSalesReport.Columns["colDate"].DataPropertyName = nameof(SalesReport.Date);
            dgvSalesReport.Columns["colTotalRevenue"].DataPropertyName = nameof(SalesReport.TotalRevenue);
            dgvSalesReport.Columns["colTotalBills"].DataPropertyName = nameof(SalesReport.TotalBills);
            dgvSalesReport.Columns["colQuantitySold"].DataPropertyName = nameof(SalesReport.TotalQuantitySold);
            dgvSalesReport.DataSource = null;
            dgvSalesReport.DataSource = salesReports;

            const string seriesName = "Revenue";

            var series = chartSales.Series.FindByName(seriesName);
            if (series == null)
            {
                series = new Series(seriesName)
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true,
                    LabelFormat = "C0"
                };
                chartSales.Series.Add(series);
            }
            else
            {
                series.Points.Clear();
            }

            foreach (var report in salesReports)
            {
                series.Points.AddXY(report.Date.ToString("dd/MM/yyyy"), report.TotalRevenue);
            }

            // Cấu hình biểu đồ
            chartSales.ChartAreas[0].AxisX.Title = "Ngày";
            chartSales.ChartAreas[0].AxisY.Title = "Doanh thu";
            chartSales.Titles.Clear();
            chartSales.Titles.Add("Biểu đồ doanh thu theo thời gian");
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
    }
}
