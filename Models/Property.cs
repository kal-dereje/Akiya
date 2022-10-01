using System;
using System.Collections.Generic;

#nullable disable

namespace Akiya.Models
{
    public partial class Property
    {
        public int PropertyId { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public decimal Price { get; set; }
        public string Purpose { get; set; }
        public string Descr { get; set; }
        public string PropType { get; set; }
        public int? FkUser { get; set; }

        public virtual User FkUserNavigation { get; set; }
    }
}
