using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public List<Book> Books { get; set; }

        public Category()
        {
            Books = new List<Book>();
        }
    }
}
