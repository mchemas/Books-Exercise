using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Books.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        // GET: /<controller>/
        public IActionResult Insert()
        {
            return View();
        }

        // GET: /<controller>/
        public IActionResult Update(int id)
        {
            return View();
        }


        // GET: /<controller>/
        public IActionResult Delete(int id)
        {
            return View();
        }

    }
}
