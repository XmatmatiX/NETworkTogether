using NETworkTogether.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETworkTogether.Domain.Interface
{
    public interface IUserRepository
    {
        public IQueryable<Post> GetUserPosts(string userId);
        public IQueryable<Project> GetUserProjects(string userId);
        public User GetUserData(string userId);
        public string UpdateUserData(User user);
        public void DeleteUser(string userId);

    }
}
