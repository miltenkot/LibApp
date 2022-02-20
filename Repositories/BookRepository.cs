using System;
using LibApp.Data;
using System.Collections.Generic;
using System.Text;
using LibApp.Models;
using LibApp.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibApp.Repositories
{
    public class BookRepository: IBookInterface
    {
        private ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        IEnumerable<Book> IBookInterface.GetBooks()
        {
            return _context.Books.Include(b => b.Genre);
        }
         
        Book IBookInterface.GetBookById(int bookId) => _context.Books.Find(bookId);

        void IBookInterface.addBook(Book book) => _context.Add(book);

        void IBookInterface.UpdateBook(IBookInterface book) => _context.Update(book);

        void IBookInterface.deleteBook(int bookId) => _context.Remove(bookId);

        void IBookInterface.Save() => _context.SaveChanges();
    }
}
