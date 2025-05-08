using pharmacy_sys.Services.CategoryServices;
using pharmacy_sys.Views.CategoryForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.CategoryPresenter
{
    public class CategoryPresenter
    {
        private readonly ICategoryView _view;
        private readonly ICategoryService _categoryService;

        public CategoryPresenter(ICategoryView view, ICategoryService categoryService)
        {
            _view = view;
            _categoryService = categoryService;
            _view.AddCategory += OnAddCategory;
            _view.LoadCategories += OnLoadCategories;
            _view.UpdateCategory += OnUpdateCategory;
            _view.DeleteCategory += OnDeleteCategory;
        }

        private void OnDeleteCategory(object? sender, EventArgs e)
        {
            var selectedCategory = _view.GetSelectedCategory();
            if (selectedCategory == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {   var result = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                _categoryService.DeleteCategory(selectedCategory.Id);
                MessageBox.Show("Xóa danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadCategories();
                _view.CategoryName = string.Empty;
                _view.Description = string.Empty;
            }
        }

        private void OnUpdateCategory(object? sender, EventArgs e)
        {
            var selectedCategory = _view.GetSelectedCategory();
            if (selectedCategory == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(_view.CategoryName))
                {
                    MessageBox.Show("Tên danh mục không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _categoryService.UpdateCategory(selectedCategory.Id, _view.CategoryName, _view.Description);
                MessageBox.Show("Cập nhật danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadCategories();
                _view.CategoryName = string.Empty;
                _view.Description = string.Empty;
            }
        }

        private void OnLoadCategories(object? sender, EventArgs e)
        {
            LoadCategories();
        }

        private void OnAddCategory(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_view.CategoryName))
                {
                    MessageBox.Show("Tên danh mục không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _categoryService.AddCategory(_view.CategoryName, _view.Description);
                MessageBox.Show("Thêm danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadCategories();
                _view.CategoryName = string.Empty;
                _view.Description = string.Empty;
            }
        }

        private void LoadCategories()
        {
            try
            {
                var categories = _categoryService.GetAllCategories();
                _view.DisplayCategories(categories);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
