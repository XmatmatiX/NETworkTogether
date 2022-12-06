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

        public int AddProjectEntry(ProjectEntry projectEntry)
        {
            throw new NotImplementedException();
        }

        public int AddProjectTask(ProjectTask projectTask)
        {
            throw new NotImplementedException();
        }

        public int AddUser(UserProject userProject)
        {
            throw new NotImplementedException();
        }

        public int ChangeTaskState(ProjectTask projectTask)
        {
            throw new NotImplementedException();
        }

        public int ChangeUserRank(UserProject userProject)
        {
            throw new NotImplementedException();
        }

        public int CreateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public int DeleteProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public void DeleteProjectEntry(int projectEntryId)
        {
            throw new NotImplementedException();
        }

        public void DeleteProjectTask(int projectTaskId)
        {
            throw new NotImplementedException();
        }

        public Project GetProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProjectEntry> GetProjectEntries(int projectId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Project> GetProjects()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Project> GetProjectsByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProjectTask> GetProjectTasks(int projectId)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(UserProject userProject)
        {
            throw new NotImplementedException();
        }

        public int UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
