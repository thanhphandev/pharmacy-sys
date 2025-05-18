using pharmacy_sys.Common;
using pharmacy_sys.Models;
using pharmacy_sys.Repositories.POSRepositories;
using pharmacy_sys.Services.BillServices;
using pharmacy_sys.Views.ReportForm;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.PrintInvoiceServices
{
    public class PrintInvoiceService : IPrintInvoiceService
    {
        private readonly IBillRepository _billRepository;
        public PrintInvoiceService(IBillRepository billRepository)
        {
            _billRepository = billRepository;
        }

        public void PrintInvoice(int billId)
        {
            if (billId <= 0)
                throw new ArgumentException("Mã hóa đơn không hợp lệ.");
            var bill = _billRepository.GetBillWithDetails(billId);
            var billDto = new BillPrintDto
            {
                Code = bill.Code,
                CreatedAt = bill.CreatedAt.ToString("dd/MM/yyyy HH:mm"),
                StaffName = bill.StaffName ?? "",
                Note = bill.Note ?? "",
                VAT = (bill.VAT * 100).ToString(),
                GrandAmount = CurrencyFormatter.FormatVietnameseCurrency(bill.GrandAmount),
                TotalPrice = CurrencyFormatter.FormatVietnameseCurrency(bill.TotalPrice)
            };

            var detailDtos = bill.BillDetails.Select(d => new BillDetailPrintDto
            {
                MedicineName = d.MedicineName ?? "",
                Quantity = d.Quantity,
                UnitType = d.UnitType ?? "N/A",
                UnitPrice = CurrencyFormatter.FormatVietnameseCurrency(d.Price),
                Total = CurrencyFormatter.FormatVietnameseCurrency(d.Amount)
            }).ToList();

            var document = new InvoiceDocument(billDto, detailDtos);

            using var memoryStream = new MemoryStream();
            document.GeneratePdf(memoryStream);

            var tempFileName = $"Invoice_{bill.Code}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            var tempFilePath = Path.Combine(Path.GetTempPath(), tempFileName);
            File.WriteAllBytes(tempFilePath, memoryStream.ToArray());

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = tempFilePath,
                UseShellExecute = true
            });
        }

    }
}
