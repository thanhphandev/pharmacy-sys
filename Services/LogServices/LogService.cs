using pharmacy_sys.Models;
using pharmacy_sys.Repositories.LogRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.LogServices
{
    internal class LogService : ILogService
    {
        private readonly ILogRepository _logRepository; 
        public LogService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }


        public List<Log> GetAllLogs()
        {
            var logs = _logRepository.GetAllLogs();
            return logs;
        }

        public void CreateLogAction(int staffId, string action, string targetTable, string targetId, string message, string? oldValue = null, string? newValue = null, string? device = null, string? source = null)
        {
            device = Environment.MachineName;
            source ??= "Desktop Application";
            var log = new Log
            {
                StaffId = staffId,
                Action = action,
                TargetTable = targetTable,
                TargetId = targetId,
                Message = message,
                OldValue = oldValue,
                NewValue = newValue,
                Device = device,
                Source = source,
                CreatedAt = DateTime.Now
            };
            _logRepository.CreateLog(log);
        }

        public List<Log> GetLogsByFilter(DateTime? startDate, DateTime? endDate, string action)
        {
            var logs = _logRepository.GetLogsByFilter(startDate, endDate, action);
            return logs;
        }
    }
}
