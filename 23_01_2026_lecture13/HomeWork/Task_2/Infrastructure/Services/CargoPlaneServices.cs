using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Models;
namespace Infrastructure.Services
{
    public class CargoPlaneServices : PlaneServices
    {
        public void PrintInfo(CargoPlane cp)
        {
            PrintPlaneInfo(cp);
            Console.WriteLine($"Его вес: {cp.Weight}");
            Console.WriteLine($"Его длина: {cp.Length}");
            Console.WriteLine();
        }
    }
}
