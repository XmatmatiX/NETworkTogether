using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETworkTogether.Domain.Model
{
    public class Project
    {
        public int ID { get; set; }
        public bool IsPublic { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<UserProject> Users { get; set; }

        public virtual ICollection<ProjectEntry> ProjectEntries { get; set; }
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}
