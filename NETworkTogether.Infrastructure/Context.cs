using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NETworkTogether.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETworkTogether.Infrastructure
{
    public class Context : IdentityDbContext
    {

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectEntry> ProjectEntries { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProject> UserProject { get; set; }
        public Context(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserProject>()
                .HasKey(up => new { up.ProjectID, up.UserID });

            builder.Entity<UserProject>()
                .HasOne<User>(up => up.User)
                .WithMany(u => u.Projects)
                .HasForeignKey(up => up.UserID);

            builder.Entity<UserProject>()
                .HasOne<Project>(up => up.Project)
                .WithMany(p => p.Users)
                .HasForeignKey(up => up.ProjectID);
        }
    }
}
