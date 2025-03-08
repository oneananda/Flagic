using FlagicApp.Server.Interfaces;
using FlagicApp.Server.Models;

namespace FlagicApp.Server.Services
{
    public class UserService : IUserService
    {
        public User CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            User user = new User() { Id = 1 };
            return new List<User> { user };
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(int id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
