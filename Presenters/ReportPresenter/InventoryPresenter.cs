using pharmacy_sys.Models;
using pharmacy_sys.Repositories.MedicineRepositories;
using pharmacy_sys.Services.InventoryReportServices;
using pharmacy_sys.Services.MedicineServices;
using pharmacy_sys.Services.PrintInvoiceServices;
using pharmacy_sys.Views.ReportForm;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.ReportPresenter
{
    public class InventoryPresenter
    {
        private readonly IInventoryView _view;
        private readonly IMedicineBatchRepository _repo;
        public InventoryPresenter(IInventoryView view, IMedicineBatchRepository repo)
        {
            _view = view;
            _repo = repo;
            _view.LoadReportView += OnLoadInventory;
            _view.RefreshData += OnLoadInventory;
            _view.PrintReportEvent += OnPrintReport;
        }

        private void OnPrintReport(object? sender, EventArgs e)
        {
            var expiring = _repo.GetExpiringMedicines();
            var lowStock = _repo.GetLowStockMedicines();
            var summary = _repo.GetStockSummary();

            var document = new InventoryReportDocument(expiring, lowStock, summary);

            using var memoryStream = new MemoryStream();
            document.GeneratePdf(memoryStream);

            var tempFileName = $"Inventory_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            var tempFilePath = Path.Combine(Path.GetTempPath(), tempFileName);
            File.WriteAllBytes(tempFilePath, memoryStream.ToArray());

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = tempFilePath,
                UseShellExecute = true
            });

        }

        private void OnLoadInventory(object? sender, EventArgs e)
        {
            var expiring = _repo.GetExpiringMedicines();
            var lowStock = _repo.GetLowStockMedicines();
            var summary = _repo.GetStockSummary();
            
            _view.DisplayExpiringMedicines(expiring);
            _view.DisplayLowStockMedicines(lowStock);
            _view.DisplaySummary(summary);
        }
    }
}
