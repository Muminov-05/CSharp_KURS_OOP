using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface ICounters
    {
        void Decrement();
        void Reset();
        void PrintValue();
    }
}
