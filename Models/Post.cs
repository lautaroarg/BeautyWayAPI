using System;
using System.Collections.Generic;

namespace BeautyWayAPI.Models
{
    public partial class Post
    {
        public int IdPost { get; set; }
        public int IdTypeOfPost { get; set; }
        public int IdProfessional { get; set; }
        public DateTime DatePost { get; set; }
        public string TextPost { get; set; } = null!;
        public byte[]? ImagePost { get; set; }
        public byte[]? VideoPost { get; set; }
        public byte[]? AudioPost { get; set; }
        public int StatusPost { get; set; }

        public virtual UsersProfessional IdProfessionalNavigation { get; set; } = null!;
        public virtual TypeOfPost IdTypeOfPostNavigation { get; set; } = null!;
        public virtual StatusPost StatusPostNavigation { get; set; } = null!;
    }
}
