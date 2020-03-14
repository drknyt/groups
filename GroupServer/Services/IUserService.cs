using GroupServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupServer.Services
{
    public interface IUserService
    {
        User GetUser(int id);

        List<User> GetUsersByGroup(int groupId);

        User DeleteUserFromGroup(int userId, int groupId);

    }
}
