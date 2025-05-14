using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.BillForm
{
    public interface IBillsView
    {
        string SearchText { get; set; }
        void DisplayBills(List<Bill> bills);
        int GetSelectedBillId();

        event EventHandler LoadBills;
        event EventHandler DeleteBill;
        event EventHandler SearchBill;
        event EventHandler RefreshBill;
        event EventHandler ViewBill;
    }
}
