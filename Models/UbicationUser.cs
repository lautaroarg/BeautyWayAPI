using System;
using System.Collections.Generic;

namespace BeautyWayAPI.Models
{
    public partial class UbicationUser
    {
        public int IdUser { get; set; }
        public string Street { get; set; } = null!;
        public string? Numeration { get; set; }
        public string? Flat { get; set; }
        public string Apartment { get; set; } = null!;
        public string Neighborhood { get; set; } = null!;

        public virtual User IdUserNavigation { get; set; } = null!;
    }
}
