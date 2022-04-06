using System;
using System.Collections.Generic;

namespace BeautyWayAPI.Models
{
    public partial class Comment
    {
        public int IdComment { get; set; }
        public int IdUser { get; set; }
        public int IdPost { get; set; }
        public DateTime DateComment { get; set; }
        public byte[]? ImageComment { get; set; }
        public int StatusComment { get; set; }

        public virtual Post IdPostNavigation { get; set; } = null!;
        public virtual User IdUserNavigation { get; set; } = null!;
        public virtual StatusComment StatusCommentNavigation { get; set; } = null!;
    }
}
