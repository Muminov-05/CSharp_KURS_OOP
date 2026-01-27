using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CargoPlane : Planes
    {
        public string Weight { get; set; }
        public string Length { get; set; }
        public CargoPlane() { }
        public CargoPlane(string name, int speed, string typePlane, string weight, string length)
            : base(name, speed, typePlane)
        {
            Weight = weight; Length = length;
        }
    }
}
