using System;
using System.Linq;
using NewWebApp.Data;
using NewWebApp.Models;

namespace NewWebApp.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _db;

        public BookRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        //public Task<IEnumerable<Book>> GetBooksAsync()
        //{
        //   var books = _db.Books.
        //}

        public Task AddBookAsync(Book book)
        {
            _db.Add(book);
            _db.SaveChanges();
            return Task.CompletedTask;
        }

        
    }
}

