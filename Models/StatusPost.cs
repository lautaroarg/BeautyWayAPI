using System;
using System.Collections.Generic;

namespace BeautyWayAPI.Models
{
    public partial class StatusPost
    {
        public StatusPost()
        {
            Posts = new HashSet<Post>();
        }

        public int IdStatusPost { get; set; }
        public string NameStatusPost { get; set; } = null!;

        public virtual ICollection<Post> Posts { get; set; }
    }
}
