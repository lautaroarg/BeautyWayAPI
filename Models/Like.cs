using System;
using System.Collections.Generic;

namespace BeautyWayAPI.Models
{
    public partial class Like
    {
        public int IdLike { get; set; }
        public int IdUser { get; set; }
        public int IdPost { get; set; }
        public DateTime Date { get; set; }
        public int TypeOfLike { get; set; }
        public int StatusLike { get; set; }

        public virtual Post IdPostNavigation { get; set; } = null!;
        public virtual User IdUserNavigation { get; set; } = null!;
        public virtual StatusLike StatusLikeNavigation { get; set; } = null!;
        public virtual TypeOfLike TypeOfLikeNavigation { get; set; } = null!;
    }
}
