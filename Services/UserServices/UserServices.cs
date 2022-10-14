using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_test.Services.UserServices
{
    public class UserServices : IUserServices
    {
        

        public List<User> AddUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public User DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            return user.FirstOrDefault(c => c.Id == id);

        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}