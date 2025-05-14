using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Repositories.UnitTypeRepositories
{
    public class UnitTypeRepository : IUnitTypeRepository
    {
        public int AddUnitType(string unitType)
        {
            using var context = new PharmacyDbContext();
            var newUnitType = new UnitType { Name = unitType };

            context.UnitTypes.Add(newUnitType);

            context.SaveChanges();

            return newUnitType.Id;
        }


        public void DeleteUnitType(int id)
        {
            using var context = new PharmacyDbContext();
            var unitType = context.UnitTypes.Find(id);
            if(unitType == null)
            {
                throw new InvalidOperationException($"Không tìm thấy loại đơn vị với ID = {id}");
            }
            context.UnitTypes.Remove(unitType);
            context.SaveChanges();
        }

        public List<UnitType> GetAllUnitTypes()
        {
            using var context = new PharmacyDbContext();
            return context.UnitTypes.ToList();
        }

        public UnitType GetUnitTypeById(int id)
        {
            using var context = new PharmacyDbContext();
            var unitType = context.UnitTypes.Find(id);
            if (unitType == null)
            {
                throw new InvalidOperationException($"Không tìm thấy loại đơn vị với ID = {id}");
            }
            return unitType;
        }

        public void UpdateUnitType(int id, string newName)
        {
            using var context = new PharmacyDbContext();
            var unitType = context.UnitTypes.Find(id);
            if (unitType == null)
            {
                throw new InvalidOperationException($"Không tìm thấy loại đơn vị với ID = {id}");
            }
            unitType.Name = newName;
            context.SaveChanges();
        }
    }
}
