using pharmacy_sys.Models;
using pharmacy_sys.Repositories.UnitTypeRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.UnitTypeServices
{
    public class UnitTypeService : IUnitTypeService
    {
        private readonly IUnitTypeRepository _unitTypeRepository;
        public UnitTypeService(IUnitTypeRepository unitTypeRepository) 
        {
            _unitTypeRepository = unitTypeRepository;
        }

        public void AddUnitType(string unitType)
        {
            _unitTypeRepository.AddUnitType(unitType);
        }

        public void DeleteUnitType(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("ID không hợp lệ");
            }
            _unitTypeRepository.DeleteUnitType(id);
        }

        public List<UnitType> GetAllUnitTypes()
        {
            var unitTypes = _unitTypeRepository.GetAllUnitTypes();
            if(unitTypes == null || unitTypes.Count == 0)
            {
                return new List<UnitType>();
            }
            return unitTypes;
        }

        public void UpdateUnitType(int id, string newName)
        {
            _unitTypeRepository.UpdateUnitType(id, newName);
        }
    }
}
