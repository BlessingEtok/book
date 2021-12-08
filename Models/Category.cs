using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Category:BaseEntity
    {
        public string Genre { get; set; }
     
        public List<Book> Books { get; set; }

        public Category()
        {
            Books = new List<Book>();
        }
    }
}
