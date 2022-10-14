using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_test.Services.UserServices
{
    public interface IUserServices
    {
        User GetUserById(int id);
        List<User> AddUser(User newUser);
        User UpdateUser(User user);
        User DeleteUser(User user);
    }
}