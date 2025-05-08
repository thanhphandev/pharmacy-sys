using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.SupplierForm
{
    public interface ISupplierAddView
    {
        int SupplierId { get; set; }
        string SupplierName { get; set; }
        string SupplierPhone { get; set; }
        string SupplierAddress { get; set; }
        string LabelHeader { get; set; }
        bool IsEditMode { get; set; }
        event EventHandler AddSupplier;
        event EventHandler UpdateSupplier;
        void ClearFields();
        void CloseForm();

    }
}
