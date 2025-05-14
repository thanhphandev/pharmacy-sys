using Newtonsoft.Json;
using pharmacy_sys.Models;
using pharmacy_sys.Presenters.LogsPresenter;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Services.LogServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_sys.Views.LogsForm
{
    public partial class LogsView : Form, ILogsView
    {
        public LogsView()
        {
            InitializeComponent();
            var logRepository = new LogRepository();
            var logService = new LogService(logRepository);
            new LogsPresenter(this, logService);
        }

        public DateTime StartDate { get => dtpStartDate.Value; set => dtpStartDate.Value = value; }
        public DateTime EndDate { get => dtpEndDate.Value; set => dtpStartDate.Value = value; }
        public string SelectedLogType
        {
            get
            {
                return cbAction.SelectedItem as string ?? string.Empty;
            }
            set
            {
                cbAction.SelectedItem = value;
            }
        }

        public event EventHandler ExportLogs;
        public event EventHandler LoadLogs;
        public event EventHandler FilterLogs;
        public event EventHandler RefreshLogs;

        public void DisplayLogs(List<Log> logs)
        {
            dgvLogs.AutoGenerateColumns = false;

            // Đảm bảo các cột của DataGridView khớp với các trường trong Log
            dgvLogs.Columns["colId"].DataPropertyName = "Id";
            dgvLogs.Columns["colStaff"].DataPropertyName = "StaffName";
            dgvLogs.Columns["colAction"].DataPropertyName = "Action";
            dgvLogs.Columns["colTable"].DataPropertyName = "TargetTable";
            dgvLogs.Columns["colTargetId"].DataPropertyName = "TargetId";
            dgvLogs.Columns["colMessage"].DataPropertyName = "Message";
            dgvLogs.Columns["colOldValue"].DataPropertyName = "OldValue";
            dgvLogs.Columns["colNewValue"].DataPropertyName = "NewValue";
            dgvLogs.Columns["colDevice"].DataPropertyName = "Device";
            dgvLogs.Columns["colSource"].DataPropertyName = "Source";
            dgvLogs.Columns["colCreatedAt"].DataPropertyName = "CreatedAt";

            foreach (var log in logs)
            {
                log.OldValue = DecodeUnicode(log.OldValue ?? "");
                log.NewValue = DecodeUnicode(log.NewValue ?? "");
            }

            dgvLogs.DataSource = null;
            dgvLogs.DataSource = logs;
        }

        private string DecodeUnicode(string value)
        {
            if (string.IsNullOrEmpty(value)) return value;

            // Biểu thức chính quy để tìm và thay thế các chuỗi Unicode escape (\uXXXX)
            string pattern = @"\\u([0-9A-Fa-f]{4})";
            string result = Regex.Replace(value, pattern, match =>
            {
                // Chuyển đổi chuỗi \uXXXX thành ký tự tương ứng
                return ((char)Convert.ToInt32(match.Groups[1].Value, 16)).ToString();
            });

            return result;
        }

        private void LogsView_Load(object sender, EventArgs e)
        {
            LoadLogs?.Invoke(this, EventArgs.Empty);
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            ExportLogs?.Invoke(this, EventArgs.Empty);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterLogs?.Invoke(this, EventArgs.Empty);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshLogs?.Invoke(this, EventArgs.Empty);
        }

        public void DisplayLogActions(List<string> logTypes)
        {            
            cbAction.DataSource = logTypes;
            cbAction.SelectedIndex = -1; // Đặt giá trị mặc định là không chọn gì
        }
    }
}

