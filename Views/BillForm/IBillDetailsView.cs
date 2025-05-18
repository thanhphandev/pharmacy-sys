using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.BillForm
{
    public interface IBillDetailsView
    {
        int BillId { get; set; }
        string BillCode { get; set; }
        string StaffName { get; set; }
        DateTime CreatedAt { get; set; }
        string Note { get; set; }
        void DisplayBillDetails(List<BillDetail> billDetails);
        void DisplayTotalPrice(decimal totalPrice, decimal vat);
        List<BillDetail> GetCurrentBillDetails();
        event EventHandler LoadBillDetails;
        event EventHandler UpdateBillEvent;
        event EventHandler PrintBillEvent;

    }
}
