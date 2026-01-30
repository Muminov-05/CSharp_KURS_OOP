using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Infrastructure
{
    public class CircleServices : Shape
    {
        public double Radius { get; set; }
        public const double Pi = 3.14;
        public CircleServices() { }
        public CircleServices(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
           return Pi * Radius * Radius;
           return Pi * Radius * Radius;
        }
        public override void PrintDescription()
        {
            Console.WriteLine("it is the Circle.");
        }
    }
}
