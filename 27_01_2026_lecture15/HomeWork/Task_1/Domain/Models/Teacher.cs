using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
        }

        //public void Explain()
        //{
        //    Console.WriteLine("Учитель объясняет");
        //}
    }
}
