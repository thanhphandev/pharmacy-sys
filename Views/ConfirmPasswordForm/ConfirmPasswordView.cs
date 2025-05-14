using pharmacy_sys.Presenters.AuthPresenters;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.UserRepositories;
using pharmacy_sys.Services.AuthServices;
using pharmacy_sys.Services.LogServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_sys.Views.ConfirmPasswordForm
{
    public partial class ConfirmPasswordView : Form, IConfirmPasswordView
    {
        private bool isPasswordConfirmed = false;
        public ConfirmPasswordView()
        {
            InitializeComponent();
            var userRepository = new UserRepository();
            var logRepository = new LogRepository();

            var logService = new LogService(logRepository);
            var authService = new AuthService(userRepository, logService);

            new ConfirmPasswordPresenter(this, authService);
        }

        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public bool IsPasswordConfirmed { get => isPasswordConfirmed; set => isPasswordConfirmed = value; }

        public event EventHandler ConfirmPassword;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmPassword?.Invoke(this, EventArgs.Empty);
            if (IsPasswordConfirmed)
            {
                this.Close();
            }
            else
            {
                txtPassword.Text = string.Empty;
            }
        }
    }
}
