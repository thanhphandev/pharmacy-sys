using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.ConfirmPasswordForm
{
    public interface IConfirmPasswordView
    {
        string Password { get; set; }
        bool IsPasswordConfirmed { get; set; }
        event EventHandler ConfirmPassword;
    }
}
