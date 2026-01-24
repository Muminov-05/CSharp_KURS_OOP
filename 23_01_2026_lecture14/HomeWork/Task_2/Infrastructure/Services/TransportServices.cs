using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TransportServices
    {
        public virtual void PrintBaseInfo(Transport t)
        {
            Console.WriteLine($"Название: {t.Name}");
            Console.WriteLine($"Скорость: {t.Speed} км/ч");
        }
    }
}
