using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.PrintInvoiceServices
{
    public interface IPrintInvoiceService
    {
        void PrintInvoice(int billId);
    }
}
