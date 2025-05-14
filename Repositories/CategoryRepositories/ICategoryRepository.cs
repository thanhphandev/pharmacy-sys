using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Repositories.CategoryRepositories
{
    public interface ICategoryRepository
    {
        int AddCategory(string categoryName, string? description);
        List<MedicineGroup> GetAllCategories();
        void DeleteCategory(int id);
        void UpdateCategory(int id, string name, string? description);
        MedicineGroup GetCategoryById(int id);
    }
}
