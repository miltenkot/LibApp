using System.Collections.Generic;
using LibApp.Models;

namespace LibApp.Interfaces
{
    public interface IBookInterface
    {
        IEnumerable<Book> GetBooks();

        Book GetBookById(int bookId);

        void addBook(Book book);

        void UpdateBook(IBookInterface book);

        void deleteBook(int bookId);

        void Save();
    }
}