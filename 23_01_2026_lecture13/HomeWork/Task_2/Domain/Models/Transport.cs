using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Transport
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Transport() { }
        public Transport(string name, int speed)
        {
            Name = name; Speed = speed;
        }
    }
}
