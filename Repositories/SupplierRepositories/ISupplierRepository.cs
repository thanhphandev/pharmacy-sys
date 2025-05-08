using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacy_sys.Models;

namespace pharmacy_sys.Repositories.SupplierRepositories
{
    public interface ISupplierRepository
    {
        public void AddSupplier(Supplier supplier);
        public void UpdateSupplier(int id, Supplier supplier);
        public void DeleteSupplier(int id);
        public List<Supplier> GetAllSuppliers();
        public List<Supplier> SearchSupplierByName(string searchText);
    }
}
