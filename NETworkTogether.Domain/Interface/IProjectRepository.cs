using NETworkTogether.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETworkTogether.Domain.Interface
{
    public interface IProjectRepository
    {
        public IQueryable<Project> GetProjects();
        public IQueryable<Project> GetProjectsByTitle(string title);
        public IQueryable<ProjectEntry> GetProjectEntries(int projectId);
        public IQueryable<ProjectTask> GetProjectTasks(int projectId);

        public Project GetProject(int projectId);
        public int CreateProject(Project project);
        public int UpdateProject(Project project);
        public int DeleteProject(int projectId);

        public int AddUser(UserProject userProject);
        public int RemoveUser(UserProject userProject);
        public int ChangeUserRank(UserProject userProject);
        public int AddProjectEntry(ProjectEntry projectEntry);
        public int AddProjectTask(ProjectTask projectTask);
        public int DeleteProjectEntry(int projectEntryId);
        public int DeleteProjectTask(int projectTaskId);
        public int ChangeTaskState(ProjectTask projectTask);


    }
}
