using FlagicApp.Server.Interfaces;
using FlagicApp.Server.Models;
using FlagicApp.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlagicApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        //private int _nextId = 1;

        private readonly ILogger<UserController> _logger;

        // Injecting the user service via constructor
        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }
        //public User GetUserById(int id)
        //{
        //    return _users.FirstOrDefault(u => u.Id == id);
        //}

        //public User CreateUser(User user)
        //{
        //    if (user == null)
        //        throw new ArgumentNullException(nameof(user));

        //    user.Id = _nextId++;
        //    _users.Add(user);
        //    return user;
        //}

        //public User UpdateUser(int id, User user)
        //{
        //    if (user == null)
        //        throw new ArgumentNullException(nameof(user));

        //    var existingUser = _users.FirstOrDefault(u => u.Id == id);
        //    if (existingUser == null)
        //    {
        //        // Optionally, you could throw an exception here
        //        return null;
        //    }

        //    // Update properties
        //    existingUser.FirstName = user.FirstName;
        //    existingUser.LastName = user.LastName;
        //    existingUser.Email = user.Email;

        //    return existingUser;
        //}

        //public bool DeleteUser(int id)
        //{
        //    var user = _users.FirstOrDefault(u => u.Id == id);
        //    if (user == null)
        //    {
        //        return false;
        //    }

        //    _users.Remove(user);
        //    return true;
        //}
    }
}
