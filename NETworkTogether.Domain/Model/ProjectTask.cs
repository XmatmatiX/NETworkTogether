using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETworkTogether.Domain.Model
{
    public class ProjectTask
    {
        public int ID { get; set; }
        public DateTime CreateTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public State State { get; set; }
        public bool IsActive { get; set; }

        public string UserID { get; set; }
        public virtual User User { get; set; }

        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }
    }

    public enum State
    {
        Done,
        InProgress,
        Canceled,
        Delayed
    }
}
