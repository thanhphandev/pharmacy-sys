using DocumentFormat.OpenXml.Wordprocessing;
using pharmacy_sys.Services.LogServices;
using pharmacy_sys.Views.LoginForm;
using pharmacy_sys.Views.LogsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.LogsPresenter
{
    public class LogsPresenter
    {
        private ILogsView _view;
        private ILogService _logService;

        public LogsPresenter(ILogsView logsView, ILogService logService)
        {
            _view = logsView;
            _logService = logService;
            _view.LoadLogs += OnLoadLogs;
            _view.FilterLogs += OnFilterLogs;
            _view.RefreshLogs += OnRefreshLogs;
        }

        private void OnRefreshLogs(object? sender, EventArgs e)
        {
            _view.StartDate = DateTime.Now.AddDays(-7);
            _view.EndDate = DateTime.Now;
            LoadData();
        }

        private void OnFilterLogs(object? sender, EventArgs e)
        {
            string action = _view.SelectedLogType;
            DateTime startDate = _view.StartDate;
            DateTime endDate = _view.EndDate;

            var logs = _logService.GetLogsByFilter(startDate, endDate, action); // Gọi service để lấy logs

            _view.DisplayLogs(logs);
        }

        private void OnLoadLogs(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var logs = _logService.GetAllLogs();
            _view.StartDate = DateTime.Now.AddDays(-7);
            List<string> actions = new List<string>
            {
                "CREATE",
                "UPDATE",
                "DELETE",
                "DEDUCT",
                "RESTOCK",
                "LOGIN",
                "SIGNUP",
                "LOGOUT"
            };
            _view.DisplayLogActions(actions);
            _view.DisplayLogs(logs);
        }
    }
}
