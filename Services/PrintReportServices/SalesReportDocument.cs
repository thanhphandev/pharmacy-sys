using pharmacy_sys.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;

namespace pharmacy_sys.Services.PrintReportServices
{
    public class SalesReportDocument : IDocument
    {
        private readonly List<SalesReport> _salesReports;
        private readonly string _groupBy;
        private readonly byte[] _logoData;
        public SalesReportDocument(List<SalesReport> salesReports, string groupBy)
        {
            _salesReports = salesReports;
            _groupBy = groupBy;
            _logoData = LoadLogoFromResources();
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(30);
                page.Size(PageSizes.A4);

                page.Content().Column(col =>
                {
                    col.Item().Row(row =>
                    {
                        row.RelativeItem().AlignCenter().Column(header =>
                        {
                            header.Item()
                           .AlignCenter()
                           .Container()
                           .MaxHeight(40)
                           .Image(_logoData);

                            header.Item().Text($"BÁO CÁO DOANH THU THEO {_groupBy.ToUpper()}")
                                .FontSize(20).Bold().AlignCenter();

                            header.Item().PaddingTop(5).Text($"Ngày tạo: {DateTime.Now:dd/MM/yyyy HH:mm}")
                                .FontSize(10).AlignCenter();
                            header.Item().Text($"Người lập: {UserSession.FullName}")
                                .FontSize(10).AlignCenter();
                        });
                    });

                    col.Item().PaddingVertical(10).LineHorizontal(1f);

                    // Table content
                    col.Item().Table(table =>
                    {
                        table.ColumnsDefinition(cols =>
                        {
                            cols.ConstantColumn(100); // Date
                            cols.RelativeColumn(2);   // Revenue
                            cols.RelativeColumn(1);   // Bills
                            cols.RelativeColumn(1);   // Quantity
                        });

                        // Header
                        table.Header(header =>
                        {
                            header.Cell().Text("Thời gian").Bold().FontSize(10);
                            header.Cell().AlignRight().Text("Doanh thu").Bold().FontSize(10);
                            header.Cell().AlignCenter().Text("HĐ").Bold().FontSize(10);
                            header.Cell().AlignCenter().Text("SL bán").Bold().FontSize(10);
                            header.Cell().ColumnSpan(4).PaddingTop(2).LineHorizontal(0.5f);
                        });

                        decimal totalRevenue = 0;
                        int totalBills = 0;
                        int totalQuantity = 0;

                        foreach (var report in _salesReports)
                        {
                            totalRevenue += report.TotalRevenue;
                            totalBills += report.TotalBills;
                            totalQuantity += report.TotalQuantitySold;

                            table.Cell().Text(report.Date.ToString(_groupBy switch
                            {
                                "Tháng" => "MM/yyyy",
                                "Năm" => "yyyy",
                                _ => "dd/MM/yyyy"
                            })).FontSize(10);

                            table.Cell().AlignRight().Text($"{report.TotalRevenue:N0} ₫").FontSize(10);
                            table.Cell().AlignCenter().Text(report.TotalBills.ToString()).FontSize(10);
                            table.Cell().AlignCenter().Text(report.TotalQuantitySold.ToString()).FontSize(10);
                        }
                    });

                    col.Item().PaddingVertical(10).LineHorizontal(1f);

                    // Tổng kết
                    col.Item().AlignRight().Text(txt =>
                    {
                        txt.Span("Tổng doanh thu: ").Bold().FontSize(11);
                        txt.Span($"{_salesReports.Sum(x => x.TotalRevenue):N0} ₫").FontSize(11);
                    });

                    col.Item().AlignRight().Text(txt =>
                    {
                        txt.Span("Tổng số hóa đơn: ").Bold().FontSize(10);
                        txt.Span($"{_salesReports.Sum(x => x.TotalBills)}").FontSize(10);
                    });

                    col.Item().AlignRight().Text(txt =>
                    {
                        txt.Span("Tổng số lượng bán: ").Bold().FontSize(10);
                        txt.Span($"{_salesReports.Sum(x => x.TotalQuantitySold)}").FontSize(10);
                    });

                    col.Item().PaddingTop(30).AlignCenter().Text("Báo cáo được tạo tự động bởi hệ thống.").FontSize(9).Italic();
                });

                // Footer
                page.Footer().AlignCenter().Text("Trang 1 / 1").FontSize(8);
            });
        }
        private byte[] LoadLogoFromResources()
        {
            using var ms = new MemoryStream();
            pharmacy_sys.Properties.Resources.logo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
    }

}
