using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
namespace Infrastructure.Services
{
    public class Student : Person ,IPerson
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is {Age} years old");
        }
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
