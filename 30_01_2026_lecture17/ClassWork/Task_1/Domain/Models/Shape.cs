using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public virtual void PrintDescription()
        {
            Console.WriteLine("Тут описание фигуры.");
        }
    }
}
