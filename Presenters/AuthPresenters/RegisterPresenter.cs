using pharmacy_sys.Services.AuthServices;
using pharmacy_sys.Views.LoginForm;
using pharmacy_sys.Views.RegisterForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.AuthPresenters
{
    public class RegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly IAuthService _authService;
        public RegisterPresenter(IRegisterView registerView, IAuthService authService)
        {
            _view = registerView;
            _authService = authService;
            _view.Signup += OnSignup;
            _view.NavigateToLoginPage += OnNavigateToLoginPage;
        }

        private void OnNavigateToLoginPage(object? sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            _view.CloseForm();
        }

        private void OnSignup(object? sender, EventArgs e)
        {
            try
            {
                string email = _view.Email;
                string password = _view.Password;
                string fullName = _view.FullName;
                string phone = _view.Phone;
                _authService.SignUp(email, password, fullName, phone);
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _view.FullName = string.Empty;
                _view.Email = string.Empty;
                _view.Password = string.Empty;
                _view.Phone = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi khi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
