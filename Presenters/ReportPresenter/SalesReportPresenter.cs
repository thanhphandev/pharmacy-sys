using pharmacy_sys.Models;
using pharmacy_sys.Services.BillServices;
using pharmacy_sys.Views.ReportForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.ReportPresenter
{
    public class SalesReportPresenter
    {
        private readonly ISalesReportView _view;
        private readonly IBillService _billService;
        public SalesReportPresenter(ISalesReportView view, IBillService billService)
        {
            _view = view;
            _billService = billService;
            _view.LoadReport += OnLoadReport;
            _view.RefreshReport += OnRefreshReport;
        }

        private void OnRefreshReport(object? sender, EventArgs e)
        {
            LoadSalesReport();
        }

        private void OnLoadReport(object? sender, EventArgs e)
        {
            LoadSalesReport();
        }

        private void LoadSalesReport()
        {
            var bills = _billService.GetSalesReport(_view.StartDate, _view.EndDate);
            if(bills.Count <= 0)
            {
                MessageBox.Show("Không có hóa đơn nào trong khoảng thời gian này.");
            }
            var groupBy = _view.GroupBy;
            var groupedData = GroupData(bills, groupBy);
            _view.DisplaySalesReport(groupedData);
        }

        private List<SalesReport> GroupData(List<Bill> bills, string groupBy)
        {
            var groupedData = new List<SalesReport>();

            Func<Bill, object> groupKeySelector;

            if (groupBy == "Ngày")
                groupKeySelector = b => b.CreatedAt.Date;
            else if (groupBy == "Tháng")
                groupKeySelector = b => new DateTime(b.CreatedAt.Year, b.CreatedAt.Month, 1);
            else 
                groupKeySelector = b => new DateTime(b.CreatedAt.Year, 1, 1);

            groupedData = bills
                .GroupBy(groupKeySelector)
                .Select(g =>
                {
                    var allDetails = g.SelectMany(b => b.BillDetails).ToList();

                    var totalRevenue = g.Sum(b => b.TotalPrice);
                    var totalBills = g.Count();
                    var totalQuantitySold = allDetails.Sum(d => d.Quantity);

                    return new SalesReport
                    {
                        Date = (DateTime)g.Key,
                        TotalRevenue = totalRevenue,
                        TotalBills = totalBills,
                        TotalQuantitySold = totalQuantitySold
                    };
                })
                .ToList();

            return groupedData;
        }

    }
}
