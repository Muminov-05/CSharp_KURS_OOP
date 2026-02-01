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
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public Book() { }
        public Book(string title, string author, int year, string genre)
        {
            Title = title; Author = author; Year = year; Genre = genre;
        }
    }
}

