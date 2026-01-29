using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public class CarServices : Car , IVehiculo
    {
        public CarServices(int gasolineLitr) : base(gasolineLitr)
        {
        }
        public void Drive()
        {
            if(GasolineLitr > 0)
            {
                Console.WriteLine("Вождение");
            }
            else
            {
                Console.WriteLine("Невозможно ехат, бензина нету.");
            }
        }
        public bool Refuel(int gasolineLitr)
        {
            GasolineLitr += gasolineLitr;
            Console.WriteLine($"Koличество добавленных бензина: {gasolineLitr} литр");
            Console.WriteLine($"Обшая кoличество бензина в баке: {GasolineLitr} литр");
            return true;
        }
    }
}
