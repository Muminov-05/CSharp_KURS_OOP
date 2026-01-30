using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public class LampServices : IDevice
    {
        public int Brightness { get; set; } 

        public LampServices(int brightness = 50)
        {
            Brightness = brightness;
        }

        public void TurnOn()
        {
            Console.WriteLine($"Lamp is ON with brightness {Brightness}%");
        }

        public void TurnOff()
        {
            Console.WriteLine("Lamp is OFF");
        }

        public void SetBrightness(int brightness)
        {
            Brightness = brightness;
            Console.WriteLine($"Lamp brightness is set to :  {Brightness}%");
        }
    }
}
