using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class User
    {
        public string UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PassWord { get; set; }
        [Required]
        public string RepeatPassword {get;set;}

        public List<Book> Books { get; set; }

        public User()
        {
            UserId = Guid.NewGuid().ToString();
            Books = new List<Book>();
               
        }
    }
}
