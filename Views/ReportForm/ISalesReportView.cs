using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.ReportForm
{
    public interface ISalesReportView
    {
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        string GroupBy { get; }


        //event EventHandler GenerateReport;
        event EventHandler LoadReport;
        event EventHandler RefreshReport;
        event EventHandler PrintReport;

        void DisplaySalesReport(List<SalesReport> salesReports);
    }
}
