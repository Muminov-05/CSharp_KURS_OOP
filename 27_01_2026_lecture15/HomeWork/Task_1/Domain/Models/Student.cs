using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
        }

        //public void Study()
        //{
        //    Console.WriteLine($"Студент учится");
        //}
    }
}
