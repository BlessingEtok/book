using System;
using System.Collections.Generic;
using System.Text;
using Models.Models;

namespace Services.Interfaces
{
    public interface IBookService
    {
        public List<Book> Users { get; }
       public IEnumerable<Book> Books { get; }
    }
}
