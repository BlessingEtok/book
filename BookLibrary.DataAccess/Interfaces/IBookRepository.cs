using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data;
using Models.Models;

namespace Repositories.Interfaces
{
    public interface IBookRepository : ICRUDRepository
    {
        Task<List<Book>> GetBooks();
    }
}
