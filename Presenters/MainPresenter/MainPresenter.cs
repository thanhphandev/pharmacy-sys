using pharmacy_sys.Models;
using pharmacy_sys.Services.AuthServices;
using pharmacy_sys.Views.MainForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.MainPresenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IAuthService _authService;
        public MainPresenter(IMainView view, IAuthService authService)
        {
            _view = view;
            _authService = authService;
            _view.LogOut += OnLogout;
        }

        private void OnLogout(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            _authService.Logout();
            _view.ShowLoginPage();
        }
    }
}
