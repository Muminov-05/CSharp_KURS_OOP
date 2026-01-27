using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class LightCar : Auto
    {
        public string Brand {  get; set; }
        public string Color { get; set; }
        public LightCar() { }
        public LightCar(string name, int speed, string isNew, string brand, string color) 
            : base(name, speed, isNew)
        {
            Brand = brand; Color = color;
        }
    }
}
