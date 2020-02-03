using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Models;
using Books.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IPublisherRepository _publisherRepository;

        public HomeController(IBookRepository bookRepository, IPublisherRepository publisherRepository)
        {
            _bookRepository = bookRepository;
            _publisherRepository = publisherRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var books = _bookRepository.GetBooks();

            foreach(var book in books)
            {
                book.PublisherName = _publisherRepository.GetPublisherById(book.PublisherId).Name;
            }

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Mike's Books",
                Books = books.ToList()
            };

            return View(homeViewModel);
        }

        [HttpGet("Home/Insert")]
        public IActionResult InsertBook()
        {

            return View();
        }

        [HttpPost("Home/Insert")]
        public IActionResult InsertBook(Book book)
        {
            if (ModelState.IsValid)
            {
                var books = _bookRepository.GetBooks();

                if (noDuplicate(book, books))
                {
                    _bookRepository.InsertBook(book); 
                    return RedirectToAction("Index");
                }

            }

            ViewBag.duplicate = "Duplicate Title";
            return View(book);
        }

        [HttpGet("Home/Update")]
        public IActionResult UpdateBook(int id)
        {
            var bookToUpdate = _bookRepository.GetBookById(id);

            if (bookToUpdate == null)
                return NotFound();


            return View(bookToUpdate);

        }

        [HttpPost("Home/Update")]
        public async Task<IActionResult> UpdateBook(Book bookToUpdate)
        {
            if (ModelState.IsValid)
            {
                var books = _bookRepository.GetBooks();

                if (noDuplicate(bookToUpdate, books))
                {
                    if (await TryUpdateModelAsync<Book>(
                        bookToUpdate,
                        "",
                        b => b.BookName, b => b.AuthorName, b => b.Price, b => b.PublisherId))
                    {
                        _bookRepository.UpdateBook(bookToUpdate);
                        return RedirectToAction("Index");

                    }
                }

            }

            ViewBag.duplicate = "Duplicate Title";
            return View(bookToUpdate);
        }

        [HttpGet("Home/Delete/{id?}")]
        public IActionResult DeleteBook(int id)
        {
            var book = _bookRepository.GetBookById(id);

            if (book == null)
                return NotFound();


            return View(book);
        }

        [HttpPost("Home/Delete/{id?}")]
        public IActionResult DeleteBookDb(int id)
        {
            var book = _bookRepository.GetBookById(id);


            if (book != null)
            {

                _bookRepository.DeleteBook(book);
                return RedirectToAction("Index");

            }

            return View(book);
        }

        static bool noDuplicate(Book book, IEnumerable<Book> books)
        {
            foreach (var check in books)
            {
                if (check.BookName == book.BookName)
                    return false;
            }

            return true;
        }

    }
}
