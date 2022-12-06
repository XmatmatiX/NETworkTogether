using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETworkTogether.Domain.Model
{
    public class UserProject
    {

        public string UserID { get; set; }
        public virtual User User { get; set; }
        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }
        public string Rank { get; set; }
        public bool CanEdit { get; set; }
    }
}
