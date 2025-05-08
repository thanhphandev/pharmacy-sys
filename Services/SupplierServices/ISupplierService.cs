using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacy_sys.Models;

namespace pharmacy_sys.Services.SupplierServices
{
    public interface ISupplierService
    {
        void AddSupplier(string name, string phone, string address);
        void UpdateSupplier(int id, Supplier supplier);
        void DeleteSupplier(int id);
        List<Supplier> SearchSuppliers(string searchText);
        List<Supplier> GetAllSuppliers();
        void ExportToExcel(List<Supplier> suppliers, string filePath);
        void ExportToCsv(List<Supplier> suppliers, string filePath);
        List<Supplier> ImportFromExcel(string filePath);
        List<Supplier> ImportFromCsv(string filePath);
    }
}
