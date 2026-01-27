using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Models;
namespace Infrastructure.Services
{
    public class AutoServices : TransportServices
    {
        public void PrintAutoInfo(Auto a)
        {
            PrintBaseInfo(a);
            Console.WriteLine($"Состояеие: {a.IsNew}");
        }
    }
}
