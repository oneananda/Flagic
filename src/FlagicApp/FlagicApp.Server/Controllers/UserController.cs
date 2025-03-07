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
        public User GetUserById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public User CreateUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            user.Id = _nextId++;
            _users.Add(user);
            return user;
        }

        public User UpdateUser(int id, User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            var existingUser = _users.FirstOrDefault(u => u.Id == id);
            if (existingUser == null)
            {
                // Optionally, you could throw an exception here
                return null;
            }

            // Update properties
            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;
            existingUser.Email = user.Email;

            return existingUser;
        }

        public bool DeleteUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return false;
            }

            _users.Remove(user);
            return true;
        }
    }
}
