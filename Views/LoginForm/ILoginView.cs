using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.LoginForm
{
    public interface ILoginView
    {
        string Email { get; set; }
        string Password { get; set; }
        event EventHandler Login;
        event EventHandler NavigateToRegisterPage;
        void CloseForm();
    }
}
