using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.POSForm
{
    public interface IPOSView
    {
        string SearchText { get; set; }
        int CategoryId { get; set; }
        decimal? MinPrice { get; }
        decimal? MaxPrice { get; }
        string Note { get; set; }
        decimal TotalPrice { get; set; }
        decimal GrandAmount { get; set; }

        void LoadMedicineGroups(List<MedicineGroup> medicineGroups);
        void LoadMedicineProducts(List<MedicineProductModel> medicineProducts);
        void LoadPriceRanges();
        List<MedicineProductModel> GetCartItems();
        void ClearCartItems();


        event EventHandler LoadMedicineProductsEvent;
        event EventHandler RefreshMedicineProductsEvent;
        event EventHandler SearchMedicines;
        event EventHandler FilterMedicines;
        event EventHandler PurchaseMedicinesEvent;
    }
}
