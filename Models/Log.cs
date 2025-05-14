using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Models
{
    public class Log
    {
        public int Id { get; set; }
        public int StaffId { get; set; }

        public required string Action { get; set; }               // Ex: "AddDrug", "DeleteInvoice"
        public string? TargetTable { get; set; }                  // Ex: "Drugs", "Invoices"
        public string? TargetId { get; set; }                     // Ex: "123", "INV-2025-0001"

        // Nội dung
        public string? Message { get; set; }                      // Chi tiết
        public string? OldValue { get; set; }                     // JSON object nếu chỉnh sửa
        public string? NewValue { get; set; }                     // JSON object nếu chỉnh sửa

        // Metadata
        public string? Device { get; set; }                       // Tên máy hoặc thiết bị
        public string? Source { get; set; }                       // "Web", "WinForms", "API", "MobileApp"

        public string? StaffName => Staff?.FullName;                // Tên nhân viên thực hiện hành động
        // Thời điểm
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation Properties
        public virtual User Staff { get; set; } = null!;


    }
}
