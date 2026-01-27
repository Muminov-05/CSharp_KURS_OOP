using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PassengerPlane : Planes
    {
        public int Length { get; set; }
        public PassengerPlane() { }
        public PassengerPlane(string name, int speed, string typePlane, int length)
            : base(name, speed, typePlane)
        {
            Length = length;
        }
    }
}
