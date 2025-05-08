using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Repositories.CategoryRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public void AddCategory(string categoryName, string? description)
        {
            using var context = new PharmacyDbContext();
            var category = new MedicineGroup
            {
                Name = categoryName,
                Description = description
            };
            context.MedicineGroups.Add(category);
            context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            using var context = new PharmacyDbContext();
            var category = context.MedicineGroups.Find(id);

            if (category != null)
            {
                context.MedicineGroups.Remove(category);
                context.SaveChanges();
            }
            else
            {
                throw new Exception($"Không tìm thấy danh mục với ID = {id}");
            }
        }


        public List<MedicineGroup> GetAllCategories()
        {
            using var context = new PharmacyDbContext();
            return context.MedicineGroups.ToList();
        }

        public void UpdateCategory(int id, string name, string? description)
        {
            using var context = new PharmacyDbContext();
            var category = context.MedicineGroups.Find(id);

            if (category != null)
            {
                category.Name = name;
                category.Description = description;
                context.SaveChanges();
            }
            else
            {
                throw new Exception($"Không tìm thấy danh mục với ID = {id}");
            }
        }

    }
}
