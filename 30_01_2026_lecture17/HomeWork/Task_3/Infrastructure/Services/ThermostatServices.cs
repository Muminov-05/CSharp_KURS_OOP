using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    internal class ThermostatServices : IDevice
    {
        public double Temperature { get; set; }

        public ThermostatServices(double temperature = 22.0)
        {
            Temperature = temperature;
        }

        public void TurnOn()
        {
            Console.WriteLine($"Thermostat is ON at {Temperature} gradus");
        }

        public void TurnOff()
        {
            Console.WriteLine("Thermostat is OFF");
        }

        public void SetTemperature(double temperature)
        {
            Temperature = temperature;
            Console.WriteLine($"Temperature is set to {Temperature} gradus");
        }
    }
}
