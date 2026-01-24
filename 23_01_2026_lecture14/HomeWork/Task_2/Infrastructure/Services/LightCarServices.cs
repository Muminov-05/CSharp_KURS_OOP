using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class LightCarServices : AutoServices
    {
        public void PrintInfo(LightCar c)
        {
            PrintAutoInfo(c);
            Console.WriteLine($"Модел автомобиля:  {c.Brand}");
            Console.WriteLine($"Его цвет:  {c.Color}");
            Console.WriteLine();
        }
    }
}
