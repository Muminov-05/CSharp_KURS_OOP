using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Planes : Transport
    {
        public string TypePlane { get; set; }
        public Planes() { }
        public Planes(string name, int speed ,string typePlane) : base(name, speed)
        {
            TypePlane = typePlane;
        }
        
    }
}
