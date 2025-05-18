using pharmacy_sys.Models;
using pharmacy_sys.Services.AuthServices;
using pharmacy_sys.Views.ChangePasswordForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.AuthPresenters
{
    public class ChangePasswordPresenter
    {
        private readonly IChangePasswordView _view;
        private readonly IAuthService _authService;
        public ChangePasswordPresenter(IChangePasswordView view, IAuthService authService)
        {
            _view = view;
            _authService = authService;
            _view.ChangePasswordEvent += OnChangePasswordEvent;
        }

        private void OnChangePasswordEvent(object? sender, EventArgs e)
        {
            string oldPassword = _view.OldPassword;
            string newPassword = _view.NewPassword;
            string confirmPassword = _view.ConfirmPassword;

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _authService.ChangePassword(UserSession.Email, oldPassword, newPassword);
                if(MessageBox.Show("Thay đổi mật khẩu thành công. Bạn có muốn đăng nhập lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _authService.Logout();
                    Application.Restart();
                }
                else
                {
                    _view.ClearFields();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
