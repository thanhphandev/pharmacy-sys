using pharmacy_sys.Services.AuthServices;
using pharmacy_sys.Views.LoginForm;
using pharmacy_sys.Views.MainForm;
using pharmacy_sys.Views.RegisterForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.AuthPresenters
{
    public class LoginPresenter
    {
        public ILoginView _view;
        public IAuthService _authService;
        public LoginPresenter(ILoginView view, IAuthService authService)
        {
            _view = view;
            _authService = authService;
            _view.Login += OnLogin;
            _view.NavigateToRegisterPage += OnNavigateToRegisterPage;
        }

        private void OnLogin(object? sender, EventArgs e)
        {
            try
            {
                string email = _view.Email;
                string password = _view.Password;
                _authService.Login(email, password);

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _view.Email = string.Empty;
                _view.Password = string.Empty;

                MainForm mainView = new MainForm();
                mainView.Show();
                _view.CloseForm();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _view.Password = string.Empty;
            }
            
        }

        private void OnNavigateToRegisterPage(object? sender, EventArgs e)
        {
            RegisterView registerView = new RegisterView();
            registerView.Show();
            _view.CloseForm();
        }
    }
}
