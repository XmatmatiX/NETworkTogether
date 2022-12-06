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
        private readonly Context _context;

        public PostRepository(Context context)
        {
            _context = context;
        }


        public int AddComment(Comment comment)
        {
            if (comment == null)
            {
                return -1;
            }
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return comment.ID;
        }

        public int CreatePost(Post post)
        {
            if (post == null)
            {
                return -1;
            }
            _context.Posts.Add(post);
            _context.SaveChanges();
            return post.ID;
        }

        public void DeleteComment(int commentId)
        {
            var check = _context.Comments.Where(c => c.ID == commentId).FirstOrDefault();
            if (check == null)
            {
                return;
            }
            check.IsActive = false;
            _context.Attach(check);
            _context.Entry(check).Property("IsActive").IsModified = true;
            _context.SaveChanges();
        }

        public void DeletePost(int postId)
        {
            var check = _context.Posts.Where(p => p.ID == postId).FirstOrDefault();
            if (check == null)
            {
                return;
            }
            check.IsActive = false;
            _context.Attach(check);
            _context.Entry(check).Property("IsActive").IsModified = true;
            _context.SaveChanges();
        }

        public Post GetPost(int id)
        {
            return _context.Posts.Where(p => p.ID == id).FirstOrDefault();
        }

        public IQueryable<Post> GetPosts()
        {
            return _context.Posts;
        }

        public int UpdatePost(Post post)
        {
            var check = _context.Posts.Where(p => p.ID == post.ID).FirstOrDefault();
            if (check == null)
            {
                return -1;
            }
            check.Text = post.Text;
            check.Title = post.Title;
            _context.Attach(check);
            _context.Entry(check).Property("Text").IsModified = true;
            _context.Entry(check).Property("Title").IsModified = true;
            _context.SaveChanges();
            return post.ID;
        }
    }
}
