using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.ChangePasswordForm
{
    public interface IChangePasswordView
    {
        string OldPassword { get; }
        string NewPassword { get; }
        string ConfirmPassword { get; }
        event EventHandler ChangePasswordEvent;
        void ClearFields();

    }
}
