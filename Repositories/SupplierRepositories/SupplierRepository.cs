using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacy_sys.Models;

namespace pharmacy_sys.Repositories.SupplierRepositories
{
    internal class SupplierRepository : ISupplierRepository
    {
        public int AddSupplier(Supplier supplier)
        {
            using (var context = new PharmacyDbContext())
            {
                context.Suppliers.Add(supplier);
                context.SaveChanges();
                return supplier.Id;
            }
        }


        public void DeleteSupplier(int id)
        {
            using (var context = new PharmacyDbContext())
            {
               
                var supplier = context.Suppliers.Find(id);

                if (supplier != null)
                {
                    context.Suppliers.Remove(supplier);
                    context.SaveChanges();
                }
            }
        }

        public List<Supplier> GetAllSuppliers()
        {
           using (var context = new PharmacyDbContext())
           {
                return context.Suppliers.ToList();
           }
        }

        public Supplier GetSupplierById(int id)
        {
            using (var context = new PharmacyDbContext())
            {
                var supplier = context.Suppliers.Find(id);
                if (supplier == null)
                {
                    throw new InvalidOperationException($"Không tìm thấy nhà cung cấp với ID = {id}");
                }
                return supplier;
            }

        }

        public List<Supplier> SearchSupplierByName(string searchText)
        {
            using var context = new PharmacyDbContext();

            var results = context.Suppliers
                .Where(s => s.Name.Contains(searchText))
                .ToList();
            return results;
        }

        public void UpdateSupplier(int id, Supplier supplier)
        {
            using var context = new PharmacyDbContext();

            var existingSupplier = context.Suppliers.Find(id);

            if (existingSupplier == null)
            {
                throw new InvalidOperationException($"Không tìm thấy nhà cung cấp với ID = {id}");
            }

            existingSupplier.Name = supplier.Name;
            existingSupplier.Phone = supplier.Phone;
            existingSupplier.Address = supplier.Address;

            context.SaveChanges();
        }

        public bool IsSupplierReferenced(int supplierId)
        {
            using var context = new PharmacyDbContext();

            return context.Medicines.Any(m => m.Id == supplierId);
        }


    }
}
