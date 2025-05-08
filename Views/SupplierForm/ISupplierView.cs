using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacy_sys.Models;

namespace pharmacy_sys.Views.SupplierForm
{
    public interface ISupplierView
    {
        public string SearchText { get; set; }
        void DisplaySuppliers(List<Supplier> suppliers);
        Supplier? GetSelectedSupplier();
        (string filePath, string fileType) PromptSaveFile();
        (string filePath, string fileType) PromptOpenFile();


        event EventHandler LoadSuppliers;
        event EventHandler OpenAddSupplier;
        event EventHandler OpenEditSupplier;
        event EventHandler DeleteSupplier;
        event EventHandler SearchSupplier;
        event EventHandler RefreshSupplier;
        event EventHandler ExportSuppliers;
        event EventHandler ImportSuppliers;

    }
}
