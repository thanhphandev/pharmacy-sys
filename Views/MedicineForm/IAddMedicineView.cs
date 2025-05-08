using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.MedicineForm
{
    public interface IAddMedicineView
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
        int SupplierId { get; set; }    
        int Quantity { get; set; }
        DateTime ExpirationDate { get; set; }
        DateTime ManufactureDate { get; set; }
        bool IsEditMode { get; set; }
        event EventHandler AddMedicineEvent;
        event EventHandler UpdateMedicineBatch;
        event EventHandler LoadDataEvent;
        event EventHandler LeaveCodeTextBoxEvent;
        void LoadMedicineGroups(List<MedicineGroup> medicineGroups);
        void LoadUnitTypes(List<UnitType> unitTypes);
        void LoadSuppliers(List<Supplier> suppliers);
        void SetAutoCompleteForCodeTextBox(List<string> code);
        void ClearFields();
        void CloseForm();
    }
}
