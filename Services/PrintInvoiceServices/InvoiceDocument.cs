using pharmacy_sys.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;

namespace pharmacy_sys.Services.PrintInvoiceServices
{
    public class InvoiceDocument : IDocument
    {
        private readonly BillPrintDto _bill;
        private readonly List<BillDetailPrintDto> _details;
        private readonly byte[] _logoData;

        public InvoiceDocument(BillPrintDto bill, List<BillDetailPrintDto> details)
        {
            _bill = bill;
            _details = details;
            _logoData = LoadLogoFromResources();
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A5);
                page.Margin(30);

                page.Content().Column(col =>
                {
                    // Logo và tiêu đề
                    col.Item().MinHeight(100).Row(row =>
                    {
                        row.RelativeItem().AlignCenter().Column(headerCol =>
                        {
                            headerCol.Item()
                            .AlignCenter()
                            .Container()
                            .MaxHeight(40) // giới hạn ảnh nhỏ hơn
                            .Image(_logoData);

                            headerCol.Item().PaddingTop(5).AlignCenter().Text("HÓA ĐƠN BÁN HÀNG").FontSize(20).Bold();
                        });
                    });

                    col.Item().PaddingVertical(10).LineHorizontal(1f);

                    // Thông tin chung
                    col.Item().Row(row =>
                    {
                        row.RelativeItem().Text($"Mã HĐ: {_bill.Code}").FontSize(10).Bold();
                        row.RelativeItem().AlignRight().Text($"Ngày: {_bill.CreatedAt:dd/MM/yyyy HH:mm}").FontSize(10);
                    });

                    col.Item().PaddingTop(5).Text($"Nhân viên: {_bill.StaffName}").FontSize(10);
                    if (!string.IsNullOrWhiteSpace(_bill.Note))
                        col.Item().PaddingTop(2).Text($"Ghi chú: {_bill.Note}").FontSize(10);

                    col.Item().PaddingVertical(10).LineHorizontal(0.5f);

                    // Bảng chi tiết
                    col.Item().Table(table =>
                    {
                        // Định nghĩa cột với căn chỉnh tốt hơn
                        table.ColumnsDefinition(cols =>
                        {
                            cols.ConstantColumn(25); // STT
                            cols.RelativeColumn(4); // Tên
                            cols.ConstantColumn(30); // SL
                            cols.ConstantColumn(30); // Đơn vị
                            cols.RelativeColumn(2); // Đơn giá
                            cols.RelativeColumn(2); // Thành tiền
                        });

                        table.Header(header =>
                        {
                            header.Cell().AlignCenter().Text("#").Bold().FontSize(10);
                            header.Cell().Text("Tên thuốc").Bold().FontSize(10);
                            header.Cell().AlignCenter().Text("SL").Bold().FontSize(10);
                            header.Cell().AlignCenter().Text("ĐV").Bold().FontSize(10);
                            header.Cell().AlignRight().Text("Đơn giá").Bold().FontSize(10);
                            header.Cell().AlignRight().Text("Thành tiền").Bold().FontSize(10);

                            header.Cell().ColumnSpan(6).PaddingTop(2).LineHorizontal(0.5f);
                        });

                        for (int i = 0; i < _details.Count; i++)
                        {
                            var d = _details[i];
                            table.Cell().AlignCenter().Text((i + 1).ToString()).FontSize(10);
                            table.Cell().Text(d.MedicineName).FontSize(10);
                            table.Cell().AlignCenter().Text($"{d.Quantity}").FontSize(10);
                            table.Cell().AlignCenter().Text(d.UnitType).FontSize(10);
                            table.Cell().AlignRight().Text(d.UnitPrice).FontSize(10);
                            table.Cell().AlignRight().Text(d.Total).FontSize(10);
                        }
                    });

                    col.Item().PaddingVertical(10).LineHorizontal(0.5f);


                    // Thông tin tổng tiền và VAT
                    col.Item().AlignRight().PaddingTop(5).Text(text =>
                    {
                        text.Span("Tổng tiền hàng: ").Bold().FontSize(10);
                        text.Span(_bill.GrandAmount).FontSize(10);
                    });

                    col.Item().AlignRight().PaddingTop(2).Text(text =>
                    {
                        text.Span("VAT (8%): ").Bold().FontSize(10);
                        text.Span(_bill.VAT).FontSize(10);
                    });

                    col.Item().AlignRight().PaddingTop(5).Text(text =>
                    {
                        text.Span("Tổng cộng: ").Bold().FontSize(12);
                        text.Span(_bill.TotalPrice).FontSize(12);
                    });

                    // Chữ ký
                    col.Item().PaddingTop(25).Row(row =>
                    {
                        row.RelativeItem().AlignCenter().Text("Khách hàng").Italic();
                        row.RelativeItem().AlignCenter().Text("Nhân viên").Italic();
                    });

                    col.Item().PaddingTop(5).Row(row =>
                    {
                        row.RelativeItem().AlignCenter().Text("(Ký tên)").FontSize(10);
                        row.RelativeItem().AlignCenter().Text("(Ký tên)").FontSize(10);
                    });

                    // Thông tin thêm ở cuối hóa đơn
                    col.Item().PaddingTop(30).AlignCenter().Text("Cảm ơn Quý Khách đã sử dụng dịch vụ!").FontSize(10);
                });

                // Thêm chân trang
                page.Footer().AlignCenter().Text(text =>
                {
                    text.Span("Trang 1 / 1").FontSize(8);
                });
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