using NETworkTogether.Domain.Interface;
using NETworkTogether.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETworkTogether.Infrastructure.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly Context _context;

        public ProjectRepository(Context context)
        {
            _context = context;
        }

        public int AddProjectEntry(ProjectEntry projectEntry)
        {
            if (projectEntry == null)
            {
                return -1;
            }
            _context.ProjectEntries.Add(projectEntry);
            _context.SaveChanges();
            return projectEntry.ID;
        }

        public int AddProjectTask(ProjectTask projectTask)
        {
            if (projectTask == null)
            {
                return -1;
            }
            _context.ProjectTasks.Add(projectTask);
            _context.SaveChanges();
            return projectTask.ID;
        }

        public int AddUser(UserProject userProject)
        {
            if (userProject == null)
            {
                return -1;
            }
            _context.UserProject.Add(userProject);
            _context.SaveChanges();
            return userProject.ProjectID;
        }

        public int ChangeTaskState(ProjectTask projectTask)
        {
            var check = _context.ProjectTasks.Where(pt => pt.ID == projectTask.ID).FirstOrDefault();
            if (check == null)
            {
                return -1;
            }
            check.State = projectTask.State;
            _context.Attach(check);
            _context.Entry(check).Property("State").IsModified = true;
            _context.SaveChanges();
            return check.ID;
        }

        public int ChangeUserRank(UserProject userProject)
        {
            var check = _context.UserProject
                .Where(up => up.UserID == userProject.UserID && up.ProjectID == userProject.ProjectID).FirstOrDefault();
            if (check == null)
            {
                return -1;
            }
            check.Rank = userProject.Rank;
            _context.Attach(check);
            _context.Entry(check).Property("Rank").IsModified = true;
            _context.SaveChanges();
            return check.ProjectID;
        }

        public int CreateProject(Project project)
        {
            if (project == null)
            {
                return -1;
            }
            _context.Projects.Add(project);
            _context.SaveChanges();
            return project.ID;
        }

        public int DeleteProject(int projectId)
        {
            var check = _context.Projects.Where(p => p.ID == projectId).FirstOrDefault();
            if (check == null)
            {
                return -1;
            }

            check.IsActive = false;
            _context.Attach(check);
            _context.Entry(check).Property("IsActive").IsModified = true;
            _context.SaveChanges();
            return 0;
        }

        public int DeleteProjectEntry(int projectEntryId)
        {
            var check = _context.ProjectEntries.Where(pe => pe.ID == projectEntryId).FirstOrDefault();
            if (check == null)
            {
                return -1;
            }

            check.IsActive = false;
            _context.Attach(check);
            _context.Entry(check).Property("IsActive").IsModified = true;
            _context.SaveChanges();
            return 0;
        }

        public int DeleteProjectTask(int projectTaskId)
        {
            var check = _context.ProjectTasks.Where(pt => pt.ID == projectTaskId).FirstOrDefault();
            if (check == null)
            {
                return -1;
            }

            check.IsActive = false;
            _context.Attach(check);
            _context.Entry(check).Property("IsActive").IsModified = true;
            _context.SaveChanges();
            return 0;
        }

        public Project GetProject(int projectId)
        {
            return _context.Projects.Where(p => p.ID == projectId).FirstOrDefault();
        }

        public IQueryable<ProjectEntry> GetProjectEntries(int projectId)
        {
            return _context.ProjectEntries.Where(pe => pe.ProjectID == projectId);
        }

        public IQueryable<Project> GetProjects()
        {
            return _context.Projects;
        }

        public IQueryable<Project> GetProjectsByTitle(string title)
        {
            return _context.Projects.Where(p => p.Title.Contains(title));
        }

        public IQueryable<ProjectTask> GetProjectTasks(int projectId)
        {
            return _context.ProjectTasks.Where(pt => pt.ProjectID == projectId);
        }

        public int RemoveUser(UserProject userProject)
        {
            var check = _context.UserProject
                .Where(up => up.ProjectID == userProject.ProjectID && up.UserID == userProject.UserID).FirstOrDefault();
            if (check == null)
            {
                return -1;
            }

            _context.UserProject.Remove(check);
            _context.SaveChanges();
            return 0;
        }

        public int UpdateProject(Project project)
        {
            var check = _context.Projects.Where(p => p.ID == project.ID).FirstOrDefault();
            if (check == null)
            {
                return -1;
            }

            check.Title = project.Title;
            check.IsPublic = project.IsPublic;
            _context.Attach(check);
            _context.Entry(check).Property("Title").IsModified = true;
            _context.Entry(check).Property("IsPublic").IsModified = true;
            _context.SaveChanges();
            return 0;
        }
    }
}
