using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETworkTogether.Domain.Model
{
    public class ProjectEntry
    {
        public int ID { get; set; }
        public DateTime CreateTime { get; set; }
        public int Text { get; set; }
        public bool IsActive { get; set; }

        public string UserID { get; set; }
        public virtual User User { get; set; }

        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }

    }
}
