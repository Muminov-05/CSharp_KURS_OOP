using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Computer
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string IsNew   { get; set; }

        public Computer() { }
        public Computer(string name, int price, string isNew)
        {
            Name = name; Price = price; IsNew = isNew;
        }
    }
}
