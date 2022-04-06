using System;
using System.Collections.Generic;

namespace BeautyWayAPI.Models
{
    public partial class ContactUser
    {
        public int IdUser { get; set; }
        public string PhoneUser { get; set; } = null!;

        public virtual User IdUserNavigation { get; set; } = null!;
    }
}
