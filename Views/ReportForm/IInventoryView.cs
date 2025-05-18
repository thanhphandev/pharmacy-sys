using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.ReportForm
{
    public interface IInventoryView
    {
      
        void DisplayExpiringMedicines(List<MedicineReportItem> items);
        void DisplayLowStockMedicines(List<MedicineReportItem> items);
        void DisplaySummary(StockSummary summary);
        event EventHandler PrintReportEvent;
        event EventHandler LoadReportView;
        event EventHandler RefreshData;
    }
}
