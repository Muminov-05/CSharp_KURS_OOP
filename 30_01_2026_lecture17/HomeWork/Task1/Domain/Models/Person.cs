using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Person
    {
        protected int Age;

        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
