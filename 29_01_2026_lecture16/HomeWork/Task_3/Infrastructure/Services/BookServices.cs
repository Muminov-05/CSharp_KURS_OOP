using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class BookServices : AbstractBook , IBorrowable
    {
        public BookServices(string author, string title) : base(author, title) { }
        public void Borrow()
        {
            Console.WriteLine($"Книга {Title} с автором {Author} было выдана на оренду.");
        }
        public void ReturnBook()
        {
            Console.WriteLine($"Книга {Title} с автором {Author} было возврашена.");
        }
    }
}
