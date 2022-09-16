using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            var books = await _db.Books.ToListAsync();

            return books;
        }

        public Task AddBookAsync(Book book)
        {
            _db.Add(book);
            _db.SaveChanges();
            return Task.CompletedTask;
        }

        
    }
}

