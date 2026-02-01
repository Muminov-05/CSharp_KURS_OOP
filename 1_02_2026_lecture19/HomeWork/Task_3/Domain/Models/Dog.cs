using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public Dog() { }
        public Dog(int id, string name, string breed, int age)
        {
            Id = id;
            Name = name;
            Breed = breed;
            Age = age;
        }
    }
}
