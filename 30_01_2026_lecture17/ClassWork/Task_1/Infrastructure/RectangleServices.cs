using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class RectangleServices : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public RectangleServices() { }
        public RectangleServices(double width, double height)
        {
            Width = width; Height = height;
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
        public override void PrintDescription()
        {
            Console.WriteLine("It is the Rectangle.");
        }
    }
}
