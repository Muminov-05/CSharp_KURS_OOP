using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TrainServices : TransportServices
    {
        public void PrintTrainInfo(Train  t)
        {
            PrintBaseInfo(t);
            Console.WriteLine($"Его длина: {t.Length}\n");
        }
    }
}
