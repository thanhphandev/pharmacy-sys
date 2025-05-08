using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.MedicineForm
{
    public interface IMedicineDetailsView
    {
        int Id { get; set; }
        string Code { get; set; }
        string MedicineName { get; set; }
        decimal Price { get; set; }
        string? Description { get; set; }
        string? Composition { get; set; }
        string MedicineImage { get; set; }
        int GroupId { get; set; }
        int UnitTypeId { get; set; }
        void DisplayMedicineDetails(Medicine medicine);
        void LoadMedicineGroups(List<MedicineGroup> medicineGroups);
        void LoadUnitTypes(List<UnitType> unitTypes);
        void DisplayMedicineBatches(List<MedicineBatch> medicineBatches);
        int GetSelectedMedicineBatchId();

        event EventHandler LoadDataEvent;
        event EventHandler UpdateMedicineEvent;
        event EventHandler DeleteMedicineBatchEvent;
        event EventHandler UpdateMedicineBatchEvent;
    }
}
