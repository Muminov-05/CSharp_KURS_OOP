using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class AbstractBook : IReadable 
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public AbstractBook(string title, string author)
        {
             Title = title; Author = author;
        }
        public void Read()
        {
            Console.WriteLine($"Он читает книгу {Title} с автором {Author}.");
        }
    }
}
