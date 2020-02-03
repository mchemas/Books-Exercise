using System;
using System.Collections.Generic;

namespace Books.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;

        public BookRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        public Book GetBookById(int bookId)
        {
            return _appDbContext.Books.Find(bookId);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _appDbContext.Books;
        }

        public void InsertBook(Book book)
        {
            _appDbContext.Books.Add(book);
            _appDbContext.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _appDbContext.SaveChangesAsync();
        }

        public void DeleteBook(Book book)
        {
            _appDbContext.Books.Remove(book);
            _appDbContext.SaveChanges();
        }


    }
}
 