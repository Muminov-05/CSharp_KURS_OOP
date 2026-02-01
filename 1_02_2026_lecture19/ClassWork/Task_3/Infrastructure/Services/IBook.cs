using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IBook
    {
        void AddBook();
        void ShowAllBooks();
        void ShowOnlyTitle();
        void ShowOnlyNameAuthor();
    }
}
