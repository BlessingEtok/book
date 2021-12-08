using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class Role:BaseEntity
    {

        public int id { get; set; }
        public string Name { get; set; }

        public List<UserRole> UserRoles { get; set; }

        public Role()
        {
            UserRoles = new List<UserRole>();
        }
    }
}
