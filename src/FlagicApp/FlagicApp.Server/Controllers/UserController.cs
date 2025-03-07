using FlagicApp.Server.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlagicApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        // Injecting the user service via constructor
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
    }
}
