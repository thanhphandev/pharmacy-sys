using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.LogServices
{
    public interface ILogService
    {
        void CreateLogAction(int staffId, string action, string targetTable, string targetId, string message, string? oldValue = null, string? newValue = null, string? device = null, string? source = null);
        List<Log> GetAllLogs();
        List<Log> GetLogsByFilter(DateTime? startDate, DateTime? endDate, string action);
    }
}
