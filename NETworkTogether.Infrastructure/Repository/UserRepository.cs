using NETworkTogether.Domain.Interface;
using NETworkTogether.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETworkTogether.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        public void DeleteUser(string userId)
        {
            throw new NotImplementedException();
        }

        public User GetUserData(string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Post> GetUserPosts(string userPosts)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Project> GetUserProjects(string userId)
        {
            throw new NotImplementedException();
        }

        public int UpdateUserData(User user)
        {
            throw new NotImplementedException();
        }
    }
}
