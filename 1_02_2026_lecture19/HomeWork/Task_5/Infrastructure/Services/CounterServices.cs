using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CounterServices : Counter , ICounters
    {
        public CounterServices(int value) : base(value) { }

        public void Decrement()
        {
            if( Value > 0 )
            {
                Value--;
            }
        }
        public void Reset()
        {
            Value = 0;
        }
        public void PrintValue()
        {
            Console.WriteLine("Value = " + Value);
        }
    }
}
