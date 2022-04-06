using System;
using System.Collections.Generic;

namespace BeautyWayAPI.Models
{
    public partial class TypeUser
    {
        public TypeUser()
        {
            Users = new HashSet<User>();
            UsersCustomers = new HashSet<UsersCustomer>();
            UsersProfessionals = new HashSet<UsersProfessional>();
        }

        public int IdTypeOfUser { get; set; }
        public string? NameType { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<UsersCustomer> UsersCustomers { get; set; }
        public virtual ICollection<UsersProfessional> UsersProfessionals { get; set; }
    }
}
