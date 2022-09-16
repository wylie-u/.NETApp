using System;
using NewWebApp.Models;

namespace NewWebApp.Repositories
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetBooksAsync();
        public Task AddBookAsync(Book book);
    }
}

