using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
namespace Infrastructure.Services
{
    public class LibraryServices : Book , ILibrary
    {
        public LibraryServices() { }
        public LibraryServices(string title, string author, int year, string genre) 
            :base(title, author, year, genre) { }

        public List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
            Console.WriteLine($"The book {book.Title} is removed.");
        }
        public List<Book> SearchBooksByAuthor(string author)
        {
            var ListByAuthor = new List<Book>();
            ListByAuthor = books.Where(book => book.Author == author).ToList();
            return ListByAuthor;
        }
        public List<Book> SearchBooksByYear(int year)
        {
            var ListByYear = new List<Book>();
            ListByYear = books.Where(book => book.Year > year).ToList();
            return ListByYear;
        }
        public List<Book> SearchBooksByGenre(string genre)
        {
            var ListByGenre = new List<Book>();
            ListByGenre = books.Where(book => book.Genre == genre).ToList();
            return ListByGenre;
        }
        public int GetBookCount()
        {
            return books.Count();
        }
        public void ShowAllBook()
        {
            foreach(var book in books)
            {
                Console.WriteLine($"{book.Title}  {book.Author}  {book.Year}  {book.Genre}");
            }
        }
    }
}
