using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class GaugeServices : Gauge , IGauge
    {
        public GaugeServices(int value) : base(value)
        {
        }
        public void Enhance()
        {
            if (Value < 5)
                Value++;
        }
        public void Decrease()
        {
            if (Value > 0)
                Value--;
        }
        public bool Full()
        {
            if (Value == 5)
                return true;
            return false;
        }
    }
}
