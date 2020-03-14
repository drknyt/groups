using GroupServer.Data;
using GroupServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupServer.Services
{
    public class UserService : IUserService
    {

        private readonly ApplicationDbContext dbContext;

        public User DeleteUserFromGroup(int userId, int groupId)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            return dbContext.Users.Find(id);
        }

        public List<User> GetUsersByGroup(int groupId)
        {
            throw new NotImplementedException();
        }
    }
}
