using pharmacy_sys.Models;
using pharmacy_sys.Presenters.MedicineManagementPresenter;
using pharmacy_sys.Repositories.CategoryRepositories;
using pharmacy_sys.Repositories.MedicineRepositories;
using pharmacy_sys.Repositories.SupplierRepositories;
using pharmacy_sys.Repositories.UnitTypeRepositories;
using pharmacy_sys.Services.CategoryServices;
using pharmacy_sys.Services.MedicineServices;
using pharmacy_sys.Services.SupplierServices;
using pharmacy_sys.Services.UnitTypeServices;
using pharmacy_sys.Views.BaseForm;
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
    public partial class AddMedicineView : BaseAddForm, IAddMedicineView
    {
        private string selectedImagePath;
        private int medicineId;
        private bool isEditMode = false;
        public AddMedicineView()
        {
            InitializeComponent();
            var medicineRepository = new MedicineRepository();
            var medicineBatchRepository = new MedicineBatchRepository();
            var unitTypeRepository = new UnitTypeRepository();
            var supplierRepository = new SupplierRepository();
            var medicineGroupRepository = new CategoryRepository();

            var medicineService = new MedicineService(medicineRepository, medicineBatchRepository);
            var unitTypeService = new UnitTypeService(unitTypeRepository);
            var supplierService = new SupplierService(supplierRepository);
            var medicineGroupService = new CategoryService(medicineGroupRepository);

            new AddMedicinePresenter(this, medicineService, medicineGroupService, unitTypeService, supplierService);

        }

        public string Code { get => txtCode.Text; set => txtCode.Text = value; }
        public string MedicineName { get => txtName.Text; set { txtName.Text = value; txtName.ReadOnly = true;  } }
        public decimal Price
        {
            get => decimal.TryParse(txtPrice.Text, out var price) ? price : 0;
            set
            {
                txtPrice.Text = value.ToString("F2");
                txtPrice.ReadOnly = true;
            }
        }
        public string? Description { get => txtDescription.Text; set { txtDescription.Text = value; txtDescription.ReadOnly = true;  } }
        public string? Composition { get => txtComposition.Text; set { txtComposition.Text = value; txtComposition.ReadOnly = true; } }

        public string MedicineImage
        {
            get => selectedImagePath;
            set
            {
                selectedImagePath = value;
                pbMedicineImage.ImageLocation = selectedImagePath;
                btnBrowse.Hide();
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

        public int SupplierId
        {
            get
            {
                if (int.TryParse(cbSupplier.SelectedValue?.ToString(), out int result))
                {
                    return result;
                }
                return 0;
            }
            set
            {
                cbSupplier.SelectedValue = value;
            }
        }

        public int Quantity
        {
            get => int.TryParse(txtQuantity.Text, out var quantity) ? quantity : 0; set => txtQuantity.Text = value.ToString();

        }

        public DateTime ExpirationDate
        {
            get => dtpExpirationDate.Value; set => dtpExpirationDate.Value = value;
        }
        public DateTime ManufactureDate
        {
            get => dtpManufactureDate.Value; set => dtpManufactureDate.Value = value;
        }
        public bool IsEditMode { get => isEditMode; set => isEditMode = value; }
        public int Id { get => medicineId; set => medicineId = value; }

        public event EventHandler AddMedicineEvent;
        public event EventHandler LoadDataEvent;
        public event EventHandler LeaveCodeTextBoxEvent;
        public event EventHandler UpdateMedicineBatch;

        public void LoadMedicineGroups(List<MedicineGroup> medicineGroups)
        {
            cbMedicineGroup.DataSource = medicineGroups;
            cbMedicineGroup.DisplayMember = "Name";
            cbMedicineGroup.ValueMember = "Id";
        }

        public void LoadSuppliers(List<Supplier> suppliers)
        {
            cbSupplier.DataSource = suppliers;
            cbSupplier.DisplayMember = "Name";
            cbSupplier.ValueMember = "Id";
        }

        public void LoadUnitTypes(List<UnitType> unitTypes)
        {
            cbUnitType.DataSource = unitTypes;
            cbUnitType.DisplayMember = "Name";
            cbUnitType.ValueMember = "Id";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    pbMedicineImage.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                UpdateMedicineBatch?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                AddMedicineEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        private void AddMedicineView_Load(object sender, EventArgs e)
        {
            LoadDataEvent?.Invoke(this, EventArgs.Empty);
        }

        public void SetAutoCompleteForCodeTextBox(List<string> codes)
        {
            if (codes == null || codes.Count == 0)
                return;

            var autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(codes.ToArray());

            txtCode.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCode.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            LeaveCodeTextBoxEvent?.Invoke(this, EventArgs.Empty);
        }

        public void ClearFields()
        {
            txtCode.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
            txtComposition.Clear();
            txtQuantity.Clear();
            dtpExpirationDate.Value = DateTime.Now;
            dtpManufactureDate.Value = DateTime.Now;
            cbMedicineGroup.SelectedIndex = -1;
            cbUnitType.SelectedIndex = -1;
            cbSupplier.SelectedIndex = -1;
            pbMedicineImage.Image = null;
            selectedImagePath = string.Empty;
        }

        public void CloseForm()
        {
            this.Close();
        }
    }
}
