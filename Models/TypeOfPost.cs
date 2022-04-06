using System;
using System.Collections.Generic;

namespace BeautyWayAPI.Models
{
    public partial class TypeOfPost
    {
        public TypeOfPost()
        {
            Posts = new HashSet<Post>();
        }

        public int IdTypeOfPost { get; set; }
        public string NameTypeOfPost { get; set; } = null!;

        public virtual ICollection<Post> Posts { get; set; }
    }
}
