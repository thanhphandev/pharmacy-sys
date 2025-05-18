using pharmacy_sys.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.InventoryReportServices
{
    public class InventoryReportDocument : IDocument
    {
        private readonly List<MedicineReportItem> _expiringMedicines;
        private readonly List<MedicineReportItem> _lowStockMedicines;
        private readonly StockSummary _summary;
        private readonly byte[] _logoData;

        public InventoryReportDocument(List<MedicineReportItem> expiringMedicines,
                                       List<MedicineReportItem> lowStockMedicines,
                                       StockSummary summary)
        {
            _expiringMedicines = expiringMedicines;
            _lowStockMedicines = lowStockMedicines;
            _summary = summary;
            _logoData = LoadLogoFromResources();
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(40);

                page.Content().Column(col =>
                {
                    // Header with logo and title
                    col.Item().Row(row =>
                    {

                        row.RelativeItem().AlignCenter().Column(headerCol =>
                        {
                            headerCol.Item()
                            .AlignCenter()
                            .Container()
                            .MaxHeight(40)
                            .Image(_logoData);
                            headerCol.Item().Text("BÁO CÁO TỒN KHO").FontSize(20).Bold().AlignCenter();
                            headerCol.Item().Text($"Ngày lập: {DateTime.Now:dd/MM/yyyy}").FontSize(10).AlignCenter();
                            headerCol.Item().Text($"Người lập: {UserSession.FullName}").FontSize(10).AlignCenter();
                        });
                    });

                    col.Item().PaddingVertical(10).LineHorizontal(1f);

                    // Summary
                    col.Item().Text("Tổng quan").FontSize(14).Bold().Underline();
                    col.Item().Text($"Tổng số loại thuốc: {_summary.TotalMedicines}");
                    col.Item().Text($"Tổng số lô thuốc: {_summary.TotalMedicineBatch}");
                    col.Item().Text($"Sắp hết hạn: {_summary.ExpiringCount}");
                    col.Item().Text($"Sắp hết hàng: {_summary.LowStockCount}");

                    // Expiring Medicines Table
                    if (_expiringMedicines.Any())
                    {
                        col.Item().PaddingTop(20).Text("Danh sách thuốc sắp hết hạn").FontSize(14).Bold();
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(cols =>
                            {
                                cols.ConstantColumn(30);  // STT
                                cols.RelativeColumn();    // Tên thuốc
                                cols.ConstantColumn(60);  // Số lượng
                                cols.ConstantColumn(100); // Ngày hết hạn
                                cols.RelativeColumn();    // Nhóm thuốc
                            });

                            table.Header(header =>
                            {
                                header.Cell().Text("#").Bold();
                                header.Cell().Text("Tên thuốc").Bold();
                                header.Cell().Text("SL").Bold();
                                header.Cell().Text("Hết hạn").Bold();
                                header.Cell().Text("Nhóm").Bold();
                            });

                            for (int i = 0; i < _expiringMedicines.Count; i++)
                            {
                                var m = _expiringMedicines[i];
                                table.Cell().Text((i + 1).ToString());
                                table.Cell().Text(m.Name);
                                table.Cell().Text(m.Quantity.ToString());
                                table.Cell().Text(m.ExpirationDate?.ToString("dd/MM/yyyy") ?? "");
                                table.Cell().Text(m.Category);
                            }
                        });
                    }

                    // Low Stock Medicines Table
                    if (_lowStockMedicines.Any())
                    {
                        col.Item().PaddingTop(20).Text("Danh sách thuốc sắp hết hàng").FontSize(14).Bold();
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(cols =>
                            {
                                cols.ConstantColumn(30);  // STT
                                cols.RelativeColumn();    // Tên thuốc
                                cols.ConstantColumn(60);  // Số lượng
                                cols.RelativeColumn();    // Nhóm thuốc
                            });

                            table.Header(header =>
                            {
                                header.Cell().Text("#").Bold();
                                header.Cell().Text("Tên thuốc").Bold();
                                header.Cell().Text("SL").Bold();
                                header.Cell().Text("Nhóm").Bold();
                            });

                            for (int i = 0; i < _lowStockMedicines.Count; i++)
                            {
                                var m = _lowStockMedicines[i];
                                table.Cell().Text((i + 1).ToString());
                                table.Cell().Text(m.Name);
                                table.Cell().Text(m.Quantity.ToString());
                                table.Cell().Text(m.Category);
                            }
                        });
                    }

                    col.Item().PaddingTop(30).AlignCenter().Text("Báo cáo được tạo bởi hệ thống quản lý nhà thuốc.").FontSize(10);
                });

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
