using pharmacy_sys.Models;
using pharmacy_sys.Presenters.CategoryPresenter;
using pharmacy_sys.Repositories.CategoryRepositories;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Services.CategoryServices;
using pharmacy_sys.Services.LogServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_sys.Views.CategoryForm
{
    public partial class CategoryView : Form, ICategoryView
    {
        public CategoryView()
        {
            InitializeComponent();
            ICategoryRepository categoryRepository = new CategoryRepository();
            var logRepository = new LogRepository();
            var logService = new LogService(logRepository);
            ICategoryService categoryService = new CategoryService(categoryRepository, logService);
            new CategoryPresenter(this, categoryService);
        }

        public string CategoryName { get => txtCategoryName.Text; set => txtCategoryName.Text = value; }
        public string? Description { get => txtDescription.Text; set => txtDescription.Text = value; }

        public event EventHandler AddCategory;
        public event EventHandler LoadCategories;
        public event EventHandler DeleteCategory;
        public event EventHandler UpdateCategory;

        public void DisplayCategories(List<MedicineGroup> categories)
        {
            dgvCategories.AutoGenerateColumns = false;

            dgvCategories.Columns["colId"].DataPropertyName = "Id";
            dgvCategories.Columns["colCategoryName"].DataPropertyName = "Name";
            dgvCategories.Columns["colDescription"].DataPropertyName = "Description";

            dgvCategories.DataSource = null;
            dgvCategories.DataSource = categories;
        }

        public MedicineGroup? GetSelectedCategory()
        {
            if (dgvCategories.CurrentRow?.DataBoundItem is MedicineGroup selectedCategory)
            {
                return selectedCategory;
            }

            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCategory?.Invoke(this, EventArgs.Empty);
        }

        private void CategoryView_Load(object sender, EventArgs e)
        {
            LoadCategories?.Invoke(this, EventArgs.Empty);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCategory?.Invoke(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCategory?.Invoke(this, EventArgs.Empty);
        }
    }
}
