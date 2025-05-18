using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Repositories.UserRepositories
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser(User user)
        {
            using var context = new PharmacyDbContext();
            context.Users.Add(user);
            context.SaveChanges();
        }

        public User? GetUserByEmail(string email)
        {
            using var context = new PharmacyDbContext();
            var user = context.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
            {
                return null;
            }
            return user;
        }

        public User UpdateUser(User user)
        {
            using var context = new PharmacyDbContext();
            var existingUser = context.Users.Find(user.Id);
            if(existingUser == null)
                throw new InvalidOperationException("Không tìm thấy người dùng này.");
            existingUser.FullName = user.FullName;
            existingUser.Phone = user.Phone;
            existingUser.Password = user.Password;
            context.SaveChanges();
            return existingUser;
        }
    }
}
