using pharmacy_sys.Common;
using pharmacy_sys.Models;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.UserRepositories;
using pharmacy_sys.Services.LogServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.AuthServices
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogService _logService;
        public AuthService(IUserRepository userRepository, ILogService logService)
        {
            _userRepository = userRepository;
            _logService = logService;
        }


        public void Login(string email, string password)
        {
            email = email.Trim().ToLower();
            password = password.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                throw new ArgumentException("Vui lòng nhập đầy đủ thông tin!");

            var user = _userRepository.GetUserByEmail(email);
            if (user == null)
                throw new InvalidOperationException("Người dùng không tồn tại!");

            if (!VerifyPassword(password, user.Password))
                throw new InvalidOperationException("Sai mật khẩu! vui lòng thử lại");

            // Set session
            UserSession.IsLoggedIn = true;
            UserSession.Id = user.Id;
            UserSession.FullName = user.FullName;
            UserSession.Email = user.Email;
            UserSession.Phone = user.Phone;
            UserSession.Role = user.Role;
            _logService.CreateLogAction(
                staffId: user.Id,
                action: "LOGIN",
                targetTable: "Users",
                targetId: user.Id.ToString(),
                message: $"{user.FullName} đã đăng nhập hệ thống."
            );
        }

        public void Logout()
        {
            _logService.CreateLogAction(
                staffId: UserSession.Id,
                action: "LOGOUT",
                targetTable: "Users",
                targetId: UserSession.Id.ToString(),
                message: $"{UserSession.FullName} đã đăng xuất hệ thống."
            );
            UserSession.ClearSession();          
        }

        public void ChangePassword(string email, string oldPassword, string newPassword)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword))
                throw new ArgumentException("Vui lòng nhập đầy đủ thông tin!");
            
            email = email.Trim().ToLower();
            oldPassword = oldPassword.Trim();
            newPassword = newPassword.Trim();
            
            var user = _userRepository.GetUserByEmail(email);
            if (user == null)
                throw new InvalidOperationException("Người dùng không tồn tại!");
            
            if (!VerifyPassword(oldPassword, user.Password))
                throw new InvalidOperationException("Sai mật khẩu! vui lòng thử lại");
            
            user.Password = HashPassword(newPassword);
            _userRepository.UpdateUser(user);
            _logService.CreateLogAction(
                staffId: user.Id,
                action: "CHANGE_PASSWORD",
                targetTable: "Users",
                targetId: user.Id.ToString(),
                message: $"{user.FullName} đã thay đổi mật khẩu."
            );
        }

        public void SignUp(string email, string password, string fullName, string phone)
        {
            email = email.Trim().ToLower();
            password = password.Trim();
            fullName = fullName.Trim();
            phone = phone.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phone))
                throw new ArgumentException("Vui lòng nhập đầy đủ thông tin!");

            if (!DataValidator.IsValidEmail(email))
                throw new ArgumentException("Email không hợp lệ!");

            if (!DataValidator.IsValidPhoneNumber(phone))
                throw new ArgumentException("Số điện thoại không hợp lệ!");

            var existingUser = _userRepository.GetUserByEmail(email);
            if (existingUser != null)
                throw new InvalidOperationException("Người dùng đã tồn tại! Vui lòng chọn email khác.");

            var newUser = new User
            {
                Email = email,
                Password = HashPassword(password),
                FullName = fullName,
                Phone = phone
            };

            _userRepository.CreateUser(newUser);
            _logService.CreateLogAction(
                staffId: newUser.Id,
                action: "SIGNUP",
                targetTable: "Users",
                targetId: newUser.Id.ToString(),
                message: $"{newUser.FullName} đã đăng ký tài khoản."
            );
        }

        public bool VerifyUserByConfirmPassword(string email, string password)
        {
            var user = _userRepository.GetUserByEmail(email);
            if (user == null)
                throw new InvalidOperationException("Người dùng không tồn tại!");
            if (!VerifyPassword(password, user.Password))
                return false;
            return true;
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

    }
}
