using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle( string color, int radius) : base(color)
        {
            Radius = radius;
        }
    }
}
