using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class PassengerPlaneServices : PlaneServices
    {
        public void PrintInfo(PassengerPlane cp)
        {
            PrintPlaneInfo(cp);
            Console.WriteLine($"Его длина: {cp.Length}");
            Console.WriteLine();
        }
    }
}
