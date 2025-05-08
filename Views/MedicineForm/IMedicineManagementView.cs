using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.MedicineForm
{
    public interface IMedicineManagementView
    {
        string SearchText { get; set; }
        int CategoryId { get; set; }
        int GetSelectedMedicineId();
        event EventHandler AddUnitType;
        event EventHandler AddMedicine;
        event EventHandler LoadMedicines;
        event EventHandler RefreshMedicines;
        event EventHandler SearchMedicines;
        event EventHandler FilterMedicines;
        event EventHandler ViewMedicineDetails;
        event EventHandler DeleteMedicine;
        void DisplayMedicines(List<Medicine> medicines);
        void LoadMedicineGroups(List<MedicineGroup> medicineGroups);
    }
}
