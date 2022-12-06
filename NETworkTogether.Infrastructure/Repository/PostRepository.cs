using NETworkTogether.Domain.Interface;
using NETworkTogether.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETworkTogether.Infrastructure.Repository
{
    public class PostRepository : IPostRepository
    {
        public int AddComment(int postId, Comment comment)
        {
            throw new NotImplementedException();
        }

        public int CreatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public void DeletePost(int postId)
        {
            throw new NotImplementedException();
        }

        public Post GetPost(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Post> GetPosts()
        {
            throw new NotImplementedException();
        }

        public int UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
