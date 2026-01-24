using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Domain.Models;
namespace Infrastructure.Services
{
    public class PlaneServices : TransportServices
    {
        public void PrintPlaneInfo(Planes p)
        {
            PrintBaseInfo(p);
            Console.WriteLine($"тип самолёта: {p.TypePlane}");
        }
    }
}
