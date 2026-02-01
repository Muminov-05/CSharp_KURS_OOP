using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string NameAuthor { get; set; }
        public int Pages { get; set; }
        public int PublicationYear { get; set; }
        public Book() { }
        public Book(string title, string nameAuthor, int pages, int publicationYear)
        {
            Title = title; NameAuthor = nameAuthor; Pages = pages; PublicationYear = publicationYear;
        }
    }
}
 