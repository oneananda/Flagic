using FlagicApp.Server.Interfaces;
using FlagicApp.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlagicApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly List<User> _users = new List<User>();
        private int _nextId = 1;

        // Injecting the user service via constructor
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }
    }
}
