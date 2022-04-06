using System;
using System.Collections.Generic;

namespace BeautyWayAPI.Models
{
    public partial class UsersCustomer
    {
        public int IdCustomer { get; set; }
        public int IdTypeOfUser { get; set; }
        public int IdUser { get; set; }
        public string NameCustomer { get; set; } = null!;
        public string LastnameCustomer { get; set; } = null!;
        public string NroIdentification { get; set; } = null!;
        public string GenereCustomer { get; set; } = null!;
        public byte[] PhotoCustomer { get; set; } = null!;

        public virtual TypeUser IdTypeOfUserNavigation { get; set; } = null!;
        public virtual User IdUserNavigation { get; set; } = null!;
    }
}
