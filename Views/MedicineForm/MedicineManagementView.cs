using pharmacy_sys.Models;
using pharmacy_sys.Presenters.MedicineManagementPresenter;
using pharmacy_sys.Repositories.CategoryRepositories;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.MedicineRepositories;
using pharmacy_sys.Services.CategoryServices;
using pharmacy_sys.Services.LogServices;
using pharmacy_sys.Services.MedicineServices;
using pharmacy_sys.Views.BaseForm;
using pharmacy_sys.Views.UnitTypeForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_sys.Views.MedicineForm
{
    public partial class MedicineManagementView : BaseManagementForm, IMedicineManagementView
    {

        public MedicineManagementView()
        {
            InitializeComponent();
            var medicineRepository = new MedicineRepository();
            var medicineBatchRepository = new MedicineBatchRepository();
            var categoryRepository = new CategoryRepository();
            var logRepository = new LogRepository();

            var logService = new LogService(logRepository);
            var medicineService = new MedicineService(medicineRepository, medicineBatchRepository, logService);

            var categoryService = new CategoryService(categoryRepository, logService);
            new MedicineManagementsPresenter(this, medicineService, categoryService);
        }

        public event EventHandler AddUnitType;
        public event EventHandler LoadMedicines;
        public event EventHandler AddMedicine;
        public event EventHandler RefreshMedicines;
        public event EventHandler SearchMedicines;
        public event EventHandler FilterMedicines;
        public event EventHandler ViewMedicineDetails;
        public event EventHandler DeleteMedicine;

        public string SearchText { get => txtSearch.Text; set => txtSearch.Text = value; }
        public int CategoryId
        {
            get
            {
                if (int.TryParse(cbCategory.SelectedValue?.ToString(), out int result))
                {
                    return result;
                }
                return -1;
            }
            set
            {
                cbCategory.SelectedValue = value;
                cbCategory.Enabled = false;
            }
        }


        public void DisplayMedicines(List<Medicine> medicines)
        {
            dgvMedicines.AutoGenerateColumns = false;
            dgvMedicines.Columns["colId"].DataPropertyName = "Id";
            dgvMedicines.Columns["colCode"].DataPropertyName = "Code";
            dgvMedicines.Columns["colName"].DataPropertyName = "Name";
            dgvMedicines.Columns["colPrice"].DataPropertyName = "Price";
            dgvMedicines.Columns["colCategory"].DataPropertyName = "CategoryName";
            dgvMedicines.Columns["colUnitType"].DataPropertyName = "UnitTypeName";

            dgvMedicines.DataSource = null;
            dgvMedicines.DataSource = medicines;
        }



        private void btnAddUnitType_Click(object sender, EventArgs e)
        {
            AddUnitType?.Invoke(this, EventArgs.Empty);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMedicine?.Invoke(this, EventArgs.Empty);
        }

        private void MedicineManagementView_Load(object sender, EventArgs e)
        {
            LoadMedicines?.Invoke(this, EventArgs.Empty);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshMedicines?.Invoke(this, EventArgs.Empty);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchMedicines?.Invoke(this, EventArgs.Empty);
        }

        public void LoadMedicineGroups(List<MedicineGroup> medicineGroups)
        {
            var allOption = new MedicineGroup { Id = -1, Name = "Tất cả" };
            medicineGroups.Insert(0, allOption);

            cbCategory.DataSource = null;
            cbCategory.DataSource = medicineGroups;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.SelectedIndex = 0;
        }


        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMedicines?.Invoke(this, EventArgs.Empty);
        }

        private void dgvMedicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var cell = dgvMedicines.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var column = cell.OwningColumn;

            if (column == null || column.Name == null)
                return;

            if (column.Name == "colDetail")
            {
                ViewMedicineDetails?.Invoke(this, EventArgs.Empty);
            }
            else if (column.Name == "colDelete")
            {
                DeleteMedicine?.Invoke(this, EventArgs.Empty);
            }
        }

        public int GetSelectedMedicineId()
        {
            if (dgvMedicines.CurrentRow != null)
            {
                var row = dgvMedicines.CurrentRow;
                var cellValue = row.Cells["colId"]?.Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                {
                    return id;
                }
            }

            return -1;
        }

    }

}
