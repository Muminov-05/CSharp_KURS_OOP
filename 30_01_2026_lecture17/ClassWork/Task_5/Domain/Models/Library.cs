using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Domain.Models
{
    public class Library
    {
        public string Name { get; set; }
        public List<Book> listBook = new List<Book>();
        public Library(string name)
        {
            Name = name;
            listBook = new List<Book>();
        }
    }
}
