using Microsoft.EntityFrameworkCore;
using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Repositories.LogRepositories
{
    public class LogRepository : ILogRepository
    {
        public void CreateLog(Log log)
        {
            using (var context = new PharmacyDbContext())
            {
                context.Logs.Add(log);
                context.SaveChanges();
            }
        }

        public List<Log> GetAllLogs()
        {
            using var context = new PharmacyDbContext();
            var logs = context.Logs
                              .Include(log => log.Staff)
                              .ToList();
            return logs;
        }

        public List<Log> GetLogsByFilter(DateTime? startDate, DateTime? endDate, string action)
        {
            using var context = new PharmacyDbContext();

            var logs = context.Logs
                .Include(log => log.Staff)
                .ToList();

            if (startDate.HasValue)
            {
                logs = logs.Where(log => log.CreatedAt >= startDate.Value).ToList();
            }

            if (endDate.HasValue)
            {
                logs = logs.Where(log => log.CreatedAt <= endDate.Value).ToList();
            }

            if (!string.IsNullOrWhiteSpace(action))
            {
                var trimmedAction = action.Trim().ToLower();

                logs = logs
                    .Where(log => log.Action != null &&
                                  log.Action.Trim().ToLower() == trimmedAction)
                    .ToList();
            }

            return logs;
        }




    }
}
