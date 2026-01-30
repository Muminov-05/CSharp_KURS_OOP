using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface ILibrary
    {
        public void AddBook(Book book);
        public void RemoveBook(Book book);
        public void SearchBook(string title);
        public void ShowBook();
    }
}
