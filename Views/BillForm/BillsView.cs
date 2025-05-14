using pharmacy_sys.Models;
using pharmacy_sys.Presenters.BillPresenter;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.MedicineRepositories;
using pharmacy_sys.Repositories.POSRepositories;
using pharmacy_sys.Services.BillServices;
using pharmacy_sys.Services.LogServices;
using pharmacy_sys.Services.MedicineServices;
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

namespace pharmacy_sys.Views.BillForm
{
    public partial class BillsView : BaseManagementForm, IBillsView
    {
        public BillsView()
        {
            InitializeComponent();
            var billRepository = new BillRepository();
            var medicineRepository = new MedicineRepository();
            var medicineBatchRepository = new MedicineBatchRepository();
            var logRepository = new LogRepository();

            var logService = new LogService(logRepository);
            var medicineService = new MedicineService(medicineRepository, medicineBatchRepository, logService);

            var billService = new BillService(billRepository, medicineService, logService);
            new BillPresenter(this, billService);
        }

        public string SearchText { get => txtSearch.Text; set => txtSearch.Text = value; }

        public event EventHandler LoadBills;
        public event EventHandler DeleteBill;
        public event EventHandler SearchBill;
        public event EventHandler RefreshBill;
        public event EventHandler ViewBill;

        public void DisplayBills(List<Bill> bills)
        {
            dgvBills.AutoGenerateColumns = false;
            dgvBills.Columns["colId"].DataPropertyName = "Id";
            dgvBills.Columns["colCode"].DataPropertyName = "Code";
            dgvBills.Columns["colCreatedAt"].DataPropertyName = "CreatedAt";
            dgvBills.Columns["colAmount"].DataPropertyName = "TotalPrice";
            dgvBills.Columns["colNote"].DataPropertyName = "Note";
            dgvBills.Columns["colStaff"].DataPropertyName = "StaffName";

            dgvBills.DataSource = null;
            dgvBills.DataSource = bills;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBill?.Invoke(this, EventArgs.Empty);
        }

        private void BillsView_Load(object sender, EventArgs e)
        {
            LoadBills?.Invoke(this, EventArgs.Empty);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshBill?.Invoke(this, EventArgs.Empty);
        }


        private void dgvBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var cell = dgvBills.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var column = cell.OwningColumn;

            if (column == null || column.Name == null)
                return;
            if(column.Name == "colView")
            {
                ViewBill?.Invoke(this, EventArgs.Empty);
            }
            else if (column.Name == "colDelete")
            {
                DeleteBill?.Invoke(this, EventArgs.Empty);
            }
        }

        public int GetSelectedBillId()
        {
            if (dgvBills.CurrentRow != null)
            {
                var row = dgvBills.CurrentRow;
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
