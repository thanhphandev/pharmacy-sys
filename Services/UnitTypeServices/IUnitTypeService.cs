﻿using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.UnitTypeServices
{
    public interface IUnitTypeService
    {
        void AddUnitType(string unitType);
        void DeleteUnitType(int id);
        List<UnitType> GetAllUnitTypes();
        void UpdateUnitType(int id, string newName);
    }
}
