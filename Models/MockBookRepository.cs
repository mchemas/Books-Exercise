using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public class MockBookRepository : IBookRepository
    {
        private List<Book> _books;

        //public MockBookRepository()
        //{
        //    if(_books == null)
        //    {
        //        initializeBooks();
        //    }
        //}

        //private void initializeBooks()
        //{
        //    _books = new List<Book>
        //    {
        //        new Book{ Id = 1, BookName = "Algorithms to Live By", AuthorName = "Mike", Price = 18.0M, Publisher = "Picador"},
        //        new Book{ Id = 2, BookName = "The Art of War", AuthorName = "Sean", Price = 20.0M, Publisher = "Queens Library"},
        //        new Book{ Id = 3, BookName = "The Prince", AuthorName = "Brandon", Price = 10.0M, Publisher = "Chicago Books"}
        //    };
        //}

        public Book GetBookById(int bookId)
        {
            return _books.FirstOrDefault(b => b.Id == bookId);

        }

        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }
    }
}
