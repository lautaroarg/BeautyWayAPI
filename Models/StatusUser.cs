using System;
using System.Collections.Generic;

namespace BeautyWayAPI.Models
{
    public partial class StatusUser
    {
        public StatusUser()
        {
            Users = new HashSet<User>();
        }

        public int IdStatusUser { get; set; }
        public string NameStatus { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
