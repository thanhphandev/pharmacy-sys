using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.AuthServices
{
    public interface IAuthService
    {
        void SignUp(string email, string password, string fullName, string phone);
        void Login(string email, string password);
        void Logout();
        bool VerifyUserByConfirmPassword(string email, string password);
        void ChangePassword(string email, string oldPassword, string newPassword);
    }
}
