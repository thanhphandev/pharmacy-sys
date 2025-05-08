using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.CategoryForm
{
    public interface ICategoryView
    {
        string CategoryName { get; set; }
        string? Description { get; set; }
        void DisplayCategories(List<MedicineGroup> categories);
        MedicineGroup? GetSelectedCategory();
        event EventHandler AddCategory;
        event EventHandler LoadCategories;
        event EventHandler DeleteCategory;
        event EventHandler UpdateCategory;
    }
}
