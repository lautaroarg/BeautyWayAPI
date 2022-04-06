using System;
using System.Collections.Generic;

namespace BeautyWayAPI.Models
{
    public partial class User
    {
        public User()
        {
            UsersCustomers = new HashSet<UsersCustomer>();
            UsersProfessionals = new HashSet<UsersProfessional>();
        }

        public int IdUser { get; set; }
        public string EmailUser { get; set; } = null!;
        public string PasswordUser { get; set; } = null!;
        public int TypeOfUser { get; set; }
        public int StatusUser { get; set; }

        public virtual StatusUser StatusUserNavigation { get; set; } = null!;
        public virtual TypeUser TypeOfUserNavigation { get; set; } = null!;
        public virtual ICollection<UsersCustomer> UsersCustomers { get; set; }
        public virtual ICollection<UsersProfessional> UsersProfessionals { get; set; }
    }
}
