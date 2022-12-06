using Microsoft.EntityFrameworkCore;
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
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }

        public void DeleteUser(string userId)
        {
            var user = _context.Users.Where(u => u.Id == userId).FirstOrDefault();
            if (user == null)
            {
                return;
            }
            user.IsActive = false;
            _context.Attach(user);
            _context.Entry(user).Property("IsActive").IsModified = true;
            _context.SaveChanges();
        }

        public User GetUserData(string userId)
        {
            return _context.Users.Where(u => u.Id == userId).FirstOrDefault();
        }

        public IQueryable<Post> GetUserPosts(string userId)
        {
            var userPosts = _context.Posts.Where(p => p.UserID == userId);
            return userPosts;
        }

        public IQueryable<Project> GetUserProjects(string userId)
        {
            var projects = _context.UserProject.Where(up=>up.UserID == userId).Select(up=>up.Project);
            return projects;
        }

        public string UpdateUserData(User user)
        {
            var check = _context.Users.AsNoTracking().Where(u => u.Id == user.Id).FirstOrDefault();
            if (check == null)
            {
                return "";
            }
            _context.Attach(user);
            _context.Entry(user).Property("UserName").IsModified = true;
            _context.Entry(user).Property("Description").IsModified = true;
            _context.Entry(user).Property("PhoneNumber").IsModified = true;
            _context.SaveChanges();
            return user.Id;
        }
    }
}
