using System;
using System.Collections.Generic;

#nullable disable

namespace Akiya.Models
{
    public partial class User
    {
        public User()
        {
            Properties = new HashSet<Property>();
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
