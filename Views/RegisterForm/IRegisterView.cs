using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.RegisterForm
{
    public interface IRegisterView
    {
        string Email { get; set; }
        string Password { get; set; }
        string FullName { get; set; }
        string Phone { get; set; }
        event EventHandler Signup;
        event EventHandler NavigateToLoginPage;
        void CloseForm();
    }
}
