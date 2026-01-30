using Domain.Models;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Infrastructure.Services
{
    public class LibraryServices : Library , ILibrary
    {
        public LibraryServices(string name) : base(name)
        {
        }
        List<Book> listBook = new List<Book>();
        public void AddBook(Book book)
        {
            listBook.Add(book);
        }
        public void RemoveBook(Book book)
        {
            listBook.Remove(book);
            Console.WriteLine($"The book whitm Title = {book.Title} was deleted");
        }
        public void SearchBook(string title)
        {
            for( int i = 0; i < listBook.Count; i++)
            {
                if (listBook[i].Title == title)
                {
                    Console.WriteLine($"Title : {listBook[i].Title}   Author : {listBook[i].Author}  PublicationYear:{listBook[i].PublicationYear}");
                }
            }
        }
        public void ShowBook()
        {
            foreach( Book book in listBook)
            {
                Console.WriteLine($"Title : {book.Title}   Author : {book.Author}  PublicationYear:{book.PublicationYear}");
            }
        }
    }
}
