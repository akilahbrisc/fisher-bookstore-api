using System.Collections.Generic;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Services
{

    public interface IBooksRepository 
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int bookId);
        int AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int bookId);
        bool BookExists(int bookId);

    }
}