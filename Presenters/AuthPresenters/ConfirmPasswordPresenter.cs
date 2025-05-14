using pharmacy_sys.Models;
using pharmacy_sys.Services.AuthServices;
using pharmacy_sys.Views.ConfirmPasswordForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.AuthPresenters
{
    public class ConfirmPasswordPresenter
    {
        private readonly IConfirmPasswordView _view;
        private readonly IAuthService _authService;

        public ConfirmPasswordPresenter(IConfirmPasswordView view, IAuthService authService)
        {
            _view = view;
            _authService = authService;
            _view.ConfirmPassword += OnConfirmPassword;
        }

        private void OnConfirmPassword(object? sender, EventArgs e)
        {
            try
            {
                string password = _view.Password;
                string email = UserSession.Email;
                if(string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Vui lòng đăng nhập để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool result = _authService.VerifyUserByConfirmPassword(email, password);
                if(!result)
                {
                    MessageBox.Show("Mật khẩu không đúng. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Xác thực thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _view.IsPasswordConfirmed = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _view.Password = string.Empty;
            }
        }
    }
}
