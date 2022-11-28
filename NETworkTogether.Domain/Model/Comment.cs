using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETworkTogether.Domain.Model
{
    public class Comment
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public bool IsActive { get; set; }

        public string UserID { get; set; }
        public virtual User User { get; set; }

        public int PostID { get; set; }
        public virtual Post Post { get; set; }
    }
}
