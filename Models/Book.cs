using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Book : BaseEntity
    {
        
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description{ get; set; }
        [Required]
        public DateTime PublishedAt { get; set; }
        public string Author { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public List<UserBook> UserBooks { get; set; }

        public Book()
        {
            UserBooks = new List<UserBook>();
        }
    }
}
