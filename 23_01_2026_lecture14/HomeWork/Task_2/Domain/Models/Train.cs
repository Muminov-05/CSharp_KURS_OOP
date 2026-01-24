using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Train : Transport
    {
        public int Length { get; set; }
        public Train() { }
        public Train(string name, int speed, int length) : base(name, speed)
        {
            Length = length;
        }
    }
}
