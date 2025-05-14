using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Repositories.LogRepositories
{
    public interface ILogRepository
    {
        void CreateLog(Log log);
        List<Log> GetAllLogs();
        List<Log> GetLogsByFilter(DateTime? startDate, DateTime? endDate, string action);
    }
}
