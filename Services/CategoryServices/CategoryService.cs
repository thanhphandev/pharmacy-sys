using pharmacy_sys.Models;
using pharmacy_sys.Repositories.CategoryRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
             _categoryRepository = categoryRepository;
        }

        public void AddCategory(string categoryName, string? description)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                throw new ArgumentException("Tên danh mục thuốc không được bỏ trống");
            }

            _categoryRepository.AddCategory(categoryName, description);
        }

        public void DeleteCategory(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("ID danh mục thuốc không hợp lệ");
            }
            _categoryRepository.DeleteCategory(id);
        }

        public List<MedicineGroup> GetAllCategories()
        {
            var categories = _categoryRepository.GetAllCategories();
            if (categories == null || categories.Count == 0)
            {
                return new List<MedicineGroup>();
            }
            return categories;
        }

        public void UpdateCategory(int id, string name, string? description)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID danh mục thuốc không hợp lệ");
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Tên danh mục thuốc không được bỏ trống");
            }

            _categoryRepository.UpdateCategory(id, name, description);
        }
    }
}
