using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Book
    {
        public string Id { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public string Author { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
        
    }
}
