using pharmacy_sys.Models;
using pharmacy_sys.Presenters.MedicineManagementPresenter;
using pharmacy_sys.Repositories.CategoryRepositories;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.MedicineRepositories;
using pharmacy_sys.Repositories.UnitTypeRepositories;
using pharmacy_sys.Services.CategoryServices;
using pharmacy_sys.Services.LogServices;
using pharmacy_sys.Services.MedicineServices;
using pharmacy_sys.Services.UnitTypeServices;
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
    public partial class MedicineDetailsView : Form, IMedicineDetailsView
    {
        private int _medicineId;

        public MedicineDetailsView(int medicineId)
        {
            InitializeComponent();
            _medicineId = medicineId;
            var medicineRepository = new MedicineRepository();
            var medicineBatchRepository = new MedicineBatchRepository();
            var unitTypeRepository = new UnitTypeRepository();
            var categoryRepository = new CategoryRepository();
            var logRepository = new LogRepository();

            var logService = new LogService(logRepository);
            var medicineService = new MedicineService(medicineRepository, medicineBatchRepository, logService);
            var unitTypeService = new UnitTypeService(unitTypeRepository, logService);
            var categoryService = new CategoryService(categoryRepository, logService);

            new MedicineDetailsPresenter(medicineId, this, medicineService, categoryService, unitTypeService);

        }

        public string Code { get => txtCode.Text; set => txtCode.Text = value; }
        public string MedicineName { get => txtName.Text; set { txtName.Text = value; txtName.ReadOnly = true; } }
        public decimal Price
        {
            get => decimal.TryParse(txtPrice.Text, out var price) ? price : 0;
            set
            {
                txtPrice.Text = value.ToString("F2");
                txtPrice.ReadOnly = true;
            }
        }
        public string? Description { get => txtDescription.Text; set { txtDescription.Text = value; txtDescription.ReadOnly = true; } }
        public string? Composition { get => txtComposition.Text; set { txtComposition.Text = value; txtComposition.ReadOnly = true; } }

        public string MedicineImage
        {
            get => pbMedicineImage.ImageLocation;
            set
            {
                pbMedicineImage.ImageLocation = value;
            }
        }
        public int GroupId
        {
            get
            {
                if (int.TryParse(cbMedicineGroup.SelectedValue?.ToString(), out int result))
                {
                    return result;
                }
                return 0;
            }
            set
            {
                cbMedicineGroup.SelectedValue = value;
                cbMedicineGroup.Enabled = false;
            }
        }

        public int UnitTypeId
        {
            get
            {
                if (int.TryParse(cbUnitType.SelectedValue?.ToString(), out int result))
                {
                    return result;
                }
                return 0;
            }
            set
            {
                cbUnitType.SelectedValue = value;
                cbUnitType.Enabled = false;
            }
        }

        public int Id { get => _medicineId; set => _medicineId = value; }

        public event EventHandler LoadDataEvent;
        public event EventHandler UpdateMedicineEvent;
        public event EventHandler UpdateMedicineBatchEvent;
        public event EventHandler DeleteMedicineBatchEvent;

        public void DisplayMedicineDetails(Medicine medicine)
        {
            txtCode.Text = medicine.Code;
            txtName.Text = medicine.Name;
            txtPrice.Text = medicine.Price.ToString("0,0.##");
            cbMedicineGroup.SelectedValue = medicine.GroupId;
            cbUnitType.SelectedValue = medicine.UnitTypeId;
            txtDescription.Text = medicine.Description;
            txtComposition.Text = medicine.Composition;
            pbMedicineImage.ImageLocation = medicine.Image;
        }

        public void DisplayMedicineBatches(List<MedicineBatch> medicineBatches)
        {
            dgvMedicineBatches.AutoGenerateColumns = false;
            dgvMedicineBatches.Columns["colId"].DataPropertyName = "Id";
            dgvMedicineBatches.Columns["colQuantity"].DataPropertyName = "Quantity";
            dgvMedicineBatches.Columns["colManufactureDate"].DataPropertyName = "ManufactureDate";
            dgvMedicineBatches.Columns["colExpirationDate"].DataPropertyName = "ExpirationDate";
            dgvMedicineBatches.Columns["colSupplier"].DataPropertyName = "SupplierName";
            dgvMedicineBatches.DataSource = null;
            dgvMedicineBatches.DataSource = medicineBatches;
        }

        public void LoadMedicineGroups(List<MedicineGroup> medicineGroups)
        {
            cbMedicineGroup.DataSource = medicineGroups;
            cbMedicineGroup.DisplayMember = "Name";
            cbMedicineGroup.ValueMember = "Id";
        }

        public void LoadUnitTypes(List<UnitType> unitTypes)
        {
            cbUnitType.DataSource = unitTypes;
            cbUnitType.DisplayMember = "Name";
            cbUnitType.ValueMember = "Id";
        }

        private void MedicineDetailsView_Load(object sender, EventArgs e)
        {
            LoadDataEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateMedicineEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbMedicineImage.Image = Image.FromFile(openFileDialog.FileName);
                    pbMedicineImage.ImageLocation = openFileDialog.FileName;
                }
            }
        }


        private void dgvMedicineBatches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var cell = dgvMedicineBatches.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var column = cell.OwningColumn;

            if (column == null || column.Name == null)
                return;

            if (column.Name == "colEdit")
            {
                UpdateMedicineBatchEvent?.Invoke(this, EventArgs.Empty);
            }
            else if (column.Name == "colDelete")
            {
                DeleteMedicineBatchEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        public int GetSelectedMedicineBatchId()
        {
            if (dgvMedicineBatches.CurrentRow != null)
            {
                var row = dgvMedicineBatches.CurrentRow;
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
