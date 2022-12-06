using NETworkTogether.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETworkTogether.Domain.Interface
{
    public interface IPostRepository
    {
        public IQueryable<Post> GetPosts();

        public Post GetPost(int id);
        public int CreatePost(Post post);
        public int UpdatePost(Post post);
        public void DeletePost(int postId);

        public int AddComment(int postId, Comment comment);
        public void DeleteComment(int commentId);

    }
}
