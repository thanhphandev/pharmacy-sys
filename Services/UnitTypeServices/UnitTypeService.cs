using pharmacy_sys.Models;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.UnitTypeRepositories;
using pharmacy_sys.Services.LogServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.UnitTypeServices
{
    public class UnitTypeService : IUnitTypeService
    {
        private readonly IUnitTypeRepository _unitTypeRepository;
        private readonly ILogService _logService;

        public UnitTypeService(IUnitTypeRepository unitTypeRepository, ILogService logService) 
        {
            _unitTypeRepository = unitTypeRepository;
            _logService = logService;
        }

        public void AddUnitType(string unitType)
        {
            int id = _unitTypeRepository.AddUnitType(unitType);
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "CREATE",
                targetTable: "UnitTypes",
                targetId: id.ToString(),
                message: $"Đã thêm loại đơn vị {unitType}."
            );
        }

        public void DeleteUnitType(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("ID không hợp lệ");
            }
            if (_unitTypeRepository.IsUpdateUnitReferenced(id))
            {
                throw new InvalidOperationException($"Không thể xóa đơn vị với ID = {id} vì đang được sử dụng");
            }
            _unitTypeRepository.DeleteUnitType(id);
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "DELETE",
                targetTable: "UnitTypes",
                targetId: id.ToString(),
                message: $"Đã xóa loại đơn vị có ID {id}."
            );
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
            if(id <= 0)
            {
                throw new ArgumentException("ID không hợp lệ");
            }
            if(string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("Tên loại đơn vị không được để trống");
            }
            var existingUnitType = _unitTypeRepository.GetUnitTypeById(id);
            if(existingUnitType == null)
            {
                throw new ArgumentException("Loại đơn vị không tồn tại");
            }           

            _unitTypeRepository.UpdateUnitType(id, newName);
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "UPDATE",
                targetTable: "UnitTypes",
                targetId: id.ToString(),
                message: $"Đã cập nhật loại đơn vị có ID {id} từ {existingUnitType.Name} thành {newName}.",
                oldValue: JsonSerializer.Serialize(existingUnitType),
                newValue: JsonSerializer.Serialize(new UnitType { Id = id, Name = newName })
            );
        }
    }
}
