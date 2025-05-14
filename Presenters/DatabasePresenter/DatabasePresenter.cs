using pharmacy_sys.Services.DatabaseServices;
using pharmacy_sys.Views.DatabaseForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.DatabasePresenter
{
    public class DatabasePresenter
    {
        private readonly IDatabaseService _databaseService;
        private readonly IDatabaseView _view;
        public DatabasePresenter(IDatabaseView view, IDatabaseService databaseService)
        {
            _databaseService = databaseService;
            _view = view;
            _view.BackupEvent += OnBackupEvent;
            _view.RestoreEvent += OnRestoreEvent;
        }

        private async void OnBackupEvent(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_view.BackupPath))
            {
                MessageBox.Show("Đường dẫn sao lưu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _view.StartProgress();
                await Task.Run(() => _databaseService.BackupDatabase(_view.BackupPath));
                MessageBox.Show("Sao lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sao lưu cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadData();
                _view.StopProgress();
            }
        }

        private async void OnRestoreEvent(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_view.RestorePath))
            {
                MessageBox.Show("Đường dẫn khôi phục không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var result = MessageBox.Show("Phục hồi sẽ xóa dữ liệu hiện tại và thay thế bằng dữ liệu cũ. Bạn có chắc không?",
                             "Cảnh báo",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }

                _view.StartProgress();
                await Task.Run(() => _databaseService.RestoreDatabase(_view.RestorePath));
                MessageBox.Show("Khôi phục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khôi phục cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadData();
                _view.StopProgress();
            }
        }

        private void LoadData()
        {
            _view.BackupPath = string.Empty;
            _view.RestorePath = string.Empty;   
        }

    }
}
