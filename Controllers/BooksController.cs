﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewWebApp.Data;
using NewWebApp.Models;
using NewWebApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewWebApp.Controllers
{ 
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IBookRepository _bookrepository;

        public BooksController(ApplicationDbContext db, IBookRepository bookRepository)
        {
            _db = db;
            _bookrepository = bookRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddBook()
        {
            return View();
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult GetBooks()
        { 
            return View("Index", _db.Books.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(Book book)
        {

            await _bookrepository.AddBookAsync(book);

            if(book == null)
            {
                return NotFound();
            }

            return View("Index", book);

        }


    }
}

