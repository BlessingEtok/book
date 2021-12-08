using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class User
    {
        public string Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
       
     
        [Required]
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public List<UserRole> UserRoles { get; set; }
        public List<UserBook> UserFavourites { get; set; }


        public User()
        {
            UserRoles = new List<UserRole>();
            UserFavourites = new List<UserBook>();

        }
    }
}
