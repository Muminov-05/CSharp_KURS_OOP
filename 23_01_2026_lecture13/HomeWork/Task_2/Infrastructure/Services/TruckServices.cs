using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TruckServices : AutoServices
    {
        public void PrintInfo( Truck t)
        {
            PrintAutoInfo(t);
            Console.WriteLine($"Модел грузовика: {t.Brand}");
            Console.WriteLine($"Грузоподъемность: {t.Weight}");
            Console.WriteLine();
        }
    }
}
