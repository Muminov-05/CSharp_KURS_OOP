using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class BookServices : Book , IBook
    {
        public BookServices() { }
        public BookServices(string title, string nameAuthor, int pages, int publicationYear)
            : base(title, nameAuthor, pages, publicationYear) { }

        public List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void ShawAllBooks()
        {
           foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}  {book.NameAuthor}  {book.Pages}  {book.PublicationYear}");
            } 
        }
        public void ShowOnlyTitle()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}");
            }
        }
        public void ShowOnlyNameAuthor()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.NameAuthor}");
            }
        }

        public void ShowAllBooks()
        {
            throw new NotImplementedException();
        }

        public void AddBook()
        {
            throw new NotImplementedException();
        }
    }
}
