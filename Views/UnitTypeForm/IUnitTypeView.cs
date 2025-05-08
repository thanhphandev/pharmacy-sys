using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.UnitTypeForm
{
    public interface IUnitTypeView
    {
        string UnitTypeName { get; set; }
        UnitType? GetSelectedUnitType();
        void DisplayUnitType(List<UnitType> unitTypes);
        UnitType? GetSelectedUnitType(UnitType? unitType);

        event EventHandler AddUnitType;
        event EventHandler LoadUnitTypes;
        event EventHandler DeleteUnitType;
        event EventHandler UpdateUnitType;

    }
}
