using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
namespace Infrastructure.Services
{
    public interface ILibrary
    {
        void AddBook(Book book);
        void RemoveBook(Book book);
        public List<Book> SearchBooksByAuthor(string author);
        public List<Book> SearchBooksByYear(int year);
        public List<Book> SearchBooksByGenre(string genre);
        int GetBookCount();
        void ShowAllBook();
    }
}
