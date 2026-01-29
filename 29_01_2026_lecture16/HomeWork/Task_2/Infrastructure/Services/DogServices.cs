using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public class DogServices : Animal , IAnimal
    {
        public DogServices() { }
        public DogServices(string name) : base(name)
        {
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void GetName()
        {
            Console.WriteLine($"Имя собаки :{Name}");
        }
        public override void Eat()
        {
            Console.WriteLine("Собака ест корм.");
        }
    }
}
