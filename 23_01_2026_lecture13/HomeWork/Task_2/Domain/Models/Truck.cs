using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Truck : Auto
    {
        public string Brand { get; set; }
        public string Weight { get; set; }
        public Truck() { }
        public Truck(string name, int speed, string isNew, string brand, string weight) 
            : base(name, speed, isNew)
        {
            Brand = brand; Weight = weight;
        }
    }
}
