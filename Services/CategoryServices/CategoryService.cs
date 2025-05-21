using pharmacy_sys.Models;
using pharmacy_sys.Repositories.CategoryRepositories;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Services.LogServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ILogService _logService;
        public CategoryService(ICategoryRepository categoryRepository, ILogService logService)
        {
             _categoryRepository = categoryRepository;
            _logService = logService;
        }

        public void AddCategory(string categoryName, string? description)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                throw new ArgumentException("Tên danh mục thuốc không được bỏ trống");
            }

            int id = _categoryRepository.AddCategory(categoryName, description);
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "CREATE",
                targetTable: "MedicineGroups",
                targetId: id.ToString(),
                message: $"Đã thêm danh mục thuốc {categoryName}"
            );
        }

        public void DeleteCategory(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("ID danh mục thuốc không hợp lệ");
            }
            if (_categoryRepository.IsCategoryReferenced(id))
            {
                throw new Exception($"Không thể xóa danh mục có ID = {id} vì đang được sử dụng.");
            }
            _categoryRepository.DeleteCategory(id);
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "DELETE",
                targetTable: "MedicineGroups",
                targetId: id.ToString(),
                message: $"Đã xóa danh mục thuốc có ID {id}"
            );
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

            var existingCategory = _categoryRepository.GetCategoryById(id);
            if (existingCategory == null)
            {
                throw new InvalidOperationException("Danh mục không tồn tại.");
            }

            _categoryRepository.UpdateCategory(id, name, description);

            var oldValue = JsonSerializer.Serialize(new
            {
                existingCategory.Id,
                existingCategory.Name,
                existingCategory.Description
            });

            var newValue = JsonSerializer.Serialize(new
            {
                Id = id,
                Name = name,
                Description = description
            });

            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "UPDATE",
                targetTable: "MedicineGroups",
                targetId: id.ToString(),
                message: $"Đã cập nhật danh mục thuốc có ID {id}",
                oldValue: oldValue,
                newValue: newValue
            );
        }

    }
}
