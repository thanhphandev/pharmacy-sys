using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.LogsForm
{
    public interface ILogsView
    {
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        string SelectedLogType { get; set; }
        event EventHandler ExportLogs;
        event EventHandler LoadLogs;
        event EventHandler FilterLogs;
        event EventHandler RefreshLogs;

        void DisplayLogs(List<Log> logs);
        void DisplayLogActions(List<string> logTypes);
    }
}
