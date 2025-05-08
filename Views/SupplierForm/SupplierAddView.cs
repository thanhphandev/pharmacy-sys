using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pharmacy_sys.Presenters.SupplierPresenter;
using pharmacy_sys.Repositories.SupplierRepositories;
using pharmacy_sys.Services.SupplierServices;
using pharmacy_sys.Views.BaseForm;

namespace pharmacy_sys.Views.SupplierForm
{
    public partial class SupplierAddView : BaseAddForm, ISupplierAddView
    {
        private bool isEditMode = false;
        private int supplierId;
        public SupplierAddView()
        {
            InitializeComponent();
            var repository = new SupplierRepository();
            var service = new SupplierService(repository);
            new SupplierAddPresenter(this, service);
        }

        // Properties for ISupplierAddView interface
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public string SupplierName { get => txtSupplierName.Text; set => txtSupplierName.Text = value; }
        public string SupplierPhone { get => txtPhone.Text; set => txtPhone.Text = value; }
        public string SupplierAddress { get => txtAddress.Text; set => txtAddress.Text = value; }
        public bool IsEditMode { get => isEditMode; set => isEditMode = value; }
        public string LabelHeader { get => lbHeader.Text; set => lbHeader.Text = value; }

        public event EventHandler AddSupplier;
        public event EventHandler UpdateSupplier;

        public void ClearFields()
        {
            txtAddress.Clear();
            txtPhone.Clear();
            txtSupplierName.Clear();
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                UpdateSupplier?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                AddSupplier?.Invoke(this, EventArgs.Empty);
            }
        }

    }
}
