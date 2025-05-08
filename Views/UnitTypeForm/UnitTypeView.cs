using pharmacy_sys.Models;
using pharmacy_sys.Presenters.UnitTypePresenter;
using pharmacy_sys.Repositories.UnitTypeRepositories;
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

namespace pharmacy_sys.Views.UnitTypeForm
{
    public partial class UnitTypeView : Form, IUnitTypeView
    {
        public string UnitTypeName { get => txtUnitType.Text; set => txtUnitType.Text = value; }

        public UnitTypeView()
        {
            InitializeComponent();
            IUnitTypeRepository unitTypeRepository = new UnitTypeRepository();
            IUnitTypeService unitTypeService = new UnitTypeService(unitTypeRepository);
            new UnitTypePresenter(this, unitTypeService);
        }

        public event EventHandler AddUnitType;
        public event EventHandler LoadUnitTypes;
        public event EventHandler DeleteUnitType;
        public event EventHandler UpdateUnitType;

        public UnitType? GetSelectedUnitType()
        {
            if (lstUnitType.SelectedItems.Count == 0)
                return null;

            return lstUnitType.SelectedItems[0] as UnitType;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUnitType?.Invoke(this, EventArgs.Empty);
        }

        public void DisplayUnitType(List<UnitType> unitTypes)
        {
            lstUnitType.DataSource = null;
            lstUnitType.DataSource = unitTypes;
            lstUnitType.DisplayMember = "Name";
            lstUnitType.ValueMember = "Id";
            lstUnitType.SelectedIndex = -1;
        }


        private void UnitTypeView_Load(object sender, EventArgs e)
        {
            LoadUnitTypes?.Invoke(this, EventArgs.Empty);
        }

        public UnitType? GetSelectedUnitType(UnitType? unitType)
        {
            var selectedUnitType = lstUnitType.SelectedItem as UnitType;
            if (selectedUnitType == null)
                return null;
            UnitTypeName = selectedUnitType.Name;
            return selectedUnitType;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUnitType?.Invoke(this, EventArgs.Empty);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateUnitType?.Invoke(this, EventArgs.Empty);
        }
    }
}
