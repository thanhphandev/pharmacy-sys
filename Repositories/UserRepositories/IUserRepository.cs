using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Repositories.UserRepositories
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        User? GetUserByEmail(string email);
        User UpdateUser(User user);

    }
}
