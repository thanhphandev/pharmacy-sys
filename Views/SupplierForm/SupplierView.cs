using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pharmacy_sys.Models;
using pharmacy_sys.Presenters.SupplierPresenter;
using pharmacy_sys.Repositories.SupplierRepositories;
using pharmacy_sys.Services.SupplierServices;
using pharmacy_sys.Views.BaseForm;

namespace pharmacy_sys.Views.SupplierForm
{
    public partial class SupplierView : BaseManagementForm, ISupplierView
    {
        private readonly ISupplierView _view;


        public SupplierView()
        {
            InitializeComponent();
            var repository = new SupplierRepository();
            var service = new SupplierService(repository);
            new SupplierPresenter(this, service);
        }

        public event EventHandler OpenAddSupplier;
        public event EventHandler OpenEditSupplier;
        public event EventHandler DeleteSupplier;
        public event EventHandler SearchSupplier;
        public event EventHandler RefreshSupplier;
        public event EventHandler LoadSuppliers;
        public event EventHandler ExportSuppliers;
        public event EventHandler ImportSuppliers;

        public void DisplaySuppliers(List<Supplier> suppliers)
        {
            dgvSuppliers.AutoGenerateColumns = false;

            dgvSuppliers.Columns["supplierId"].DataPropertyName = "Id";
            dgvSuppliers.Columns["SupplierName"].DataPropertyName = "Name";
            dgvSuppliers.Columns["Phone"].DataPropertyName = "Phone";
            dgvSuppliers.Columns["Address"].DataPropertyName = "Address";

            dgvSuppliers.DataSource = null;
            dgvSuppliers.DataSource = suppliers;
        }


        public string SearchText { get => txtSearch.Text; set => txtSearch.Text = value; }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenAddSupplier?.Invoke(this, EventArgs.Empty);
        }

        public Supplier? GetSelectedSupplier()
        {
            if (dgvSuppliers.CurrentRow != null)
            {
                var row = dgvSuppliers.CurrentRow;

                var idValue = row.Cells["supplierId"]?.Value;
                var nameValue = row.Cells["SupplierName"]?.Value;
                var phoneValue = row.Cells["Phone"]?.Value;
                var addressValue = row.Cells["Address"]?.Value;

                return new Supplier
                {
                    Id = idValue != null ? Convert.ToInt32(idValue) : 0,
                    Name = nameValue?.ToString() ?? string.Empty,
                    Phone = phoneValue?.ToString() ?? string.Empty,
                    Address = addressValue?.ToString() ?? string.Empty
                };
            }
            return null;
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var cell = dgvSuppliers.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var column = cell.OwningColumn;

            if (column == null || column.Name == null)
                return;

            if (column.Name == "dgvEdit")
            {
                OpenEditSupplier?.Invoke(this, EventArgs.Empty);
            }
            else if (column.Name == "dgvDelete")
            {
                DeleteSupplier?.Invoke(this, EventArgs.Empty);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchSupplier?.Invoke(this, EventArgs.Empty);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshSupplier?.Invoke(this, EventArgs.Empty);
        }

        private void SupplierView_Load(object sender, EventArgs e)
        {
            LoadSuppliers?.Invoke(this, EventArgs.Empty);
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            ExportSuppliers?.Invoke(this, EventArgs.Empty);
        }

        public (string filePath, string fileType) PromptSaveFile()
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "Excel File (*.xlsx)|*.xlsx|CSV File (*.csv)|*.csv",
                Title = "Xuất dữ liệu nhà cung cấp"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var ext = Path.GetExtension(sfd.FileName)?.ToLower();
                string fileType = ext == ".xlsx" ? "excel" : ext == ".csv" ? "csv" : "";
                return (sfd.FileName, fileType);
            }

            return (string.Empty, string.Empty);
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            ImportSuppliers?.Invoke(this, EventArgs.Empty);
        }

        public (string filePath, string fileType) PromptOpenFile()
        {
            using var ofd = new OpenFileDialog
            {
                Filter = "Excel File (*.xlsx)|*.xlsx|CSV File (*.csv)|*.csv",
                Title = "Chọn file để nhập"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var ext = Path.GetExtension(ofd.FileName)?.ToLower();
                string fileType = ext == ".xlsx" ? "excel" : ext == ".csv" ? "csv" : "";
                return (ofd.FileName, fileType);
            }

            return (string.Empty, string.Empty);
        }
    }
}
