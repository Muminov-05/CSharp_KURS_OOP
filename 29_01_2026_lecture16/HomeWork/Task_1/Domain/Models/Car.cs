using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Car
    {
        public int GasolineLitr { get; set; } = 0;
        public Car(int gasolineLitr)
        {
            GasolineLitr = gasolineLitr;
        }
    }
}
