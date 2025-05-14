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

namespace pharmacy_sys.Views.LoginForm
{
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
            var userRepository = new UserRepository();
            var logRepository = new LogRepository();
            var logService = new LogService(logRepository);
            var authService = new AuthService(userRepository, logService);

            new LoginPresenter(this, authService);
        }

        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }

        public event EventHandler Login;
        public event EventHandler NavigateToRegisterPage;

        public void CloseForm()
        {
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkDisplayPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDisplayPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login?.Invoke(this, EventArgs.Empty);
        }

        private void lkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigateToRegisterPage?.Invoke(this, EventArgs.Empty);
        }
    }
}
