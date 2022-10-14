using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using net_test.Services.UserServices;

namespace net_test.Controllers
{
    [Authorize]
    [ApiController]
    [Route("API/[controller]")]

    public class UserController : ControllerBase
    {
        private static User user = new User{};
        private readonly IUserServices _userService;

        public UserController(IUserServices userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetSingle(int id)
        {
            return Ok(_userService.GetUserById(id));
        }

        [HttpPost] //añadir usuario
        public ActionResult<User> AddUser(User user)
        {
            return Ok(_userService.AddUser(user));
        }

        [HttpDelete] //Borrar Usuario
        public ActionResult<User> DeleteUser(User user)
        {
            return Ok(_userService.DeleteUser(user));
        }

        [HttpPut] //Modificar Usuario
        public ActionResult<User> UpdateUser(User user)
        {
            return Ok(_userService.UpdateUser(user));
        }
    }
}