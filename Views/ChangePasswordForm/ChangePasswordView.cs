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

namespace pharmacy_sys.Views.ChangePasswordForm
{
    public partial class ChangePasswordView : Form, IChangePasswordView
    {
        public string OldPassword => txtOldPassword.Text;

        public string NewPassword => txtNewPassword.Text;

        public string ConfirmPassword => txtConfirmPassword.Text;

        public ChangePasswordView()
        {
            InitializeComponent();
            var userRepository = new UserRepository();
            var logRepository = new LogRepository();
            var logService = new LogService(logRepository);

            var authService = new AuthService(userRepository, logService);
            new ChangePasswordPresenter(this, authService);
        }

        public event EventHandler ChangePasswordEvent;

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void ClearFields()
        {
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void chkDisplayPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDisplayPassword.Checked)
            {
                txtOldPassword.PasswordChar = '\0';
                txtNewPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtOldPassword.PasswordChar = '●';
                txtNewPassword.PasswordChar = '●';
                txtConfirmPassword.PasswordChar = '●';
            }
        }
    }
}
