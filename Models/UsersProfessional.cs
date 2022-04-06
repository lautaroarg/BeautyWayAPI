using System;
using System.Collections.Generic;

namespace BeautyWayAPI.Models
{
    public partial class UsersProfessional
    {
        public UsersProfessional()
        {
            Posts = new HashSet<Post>();
        }

        public int IdProfessional { get; set; }
        public int IdTypeOfUser { get; set; }
        public int IdUser { get; set; }
        public string NameCompany { get; set; } = null!;
        public string NameProfessional { get; set; } = null!;
        public string LastnameProfessional { get; set; } = null!;
        public string GenereProfessional { get; set; } = null!;
        public string Modality { get; set; } = null!;
        public string WorkingDay { get; set; } = null!;
        public string WorkingHours { get; set; } = null!;
        public byte[] PhotoProfessional { get; set; } = null!;

        public virtual TypeUser IdTypeOfUserNavigation { get; set; } = null!;
        public virtual User IdUserNavigation { get; set; } = null!;
        public virtual ICollection<Post> Posts { get; set; }
    }
}
