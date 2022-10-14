using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_test.Models
{
    public class User
    {
        //UserType(Enum)
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public enum UserType{ };
        public string Email { get; set; } = string.Empty;
        public int Phone { get; set; }
    }
}