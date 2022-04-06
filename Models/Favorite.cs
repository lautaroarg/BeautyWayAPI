using System;
using System.Collections.Generic;

namespace BeautyWayAPI.Models
{
    public partial class Favorite
    {
        public int IdFavorite { get; set; }
        public int IdUserCustomer { get; set; }
        public int IdUserProfessional { get; set; }
        public int StatusFavorite { get; set; }

        public virtual UsersCustomer IdUserCustomerNavigation { get; set; } = null!;
        public virtual UsersProfessional IdUserProfessionalNavigation { get; set; } = null!;
        public virtual StatusFavorite StatusFavoriteNavigation { get; set; } = null!;
    }
}
