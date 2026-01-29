using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public Animal() { }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Eat();
    }
}
