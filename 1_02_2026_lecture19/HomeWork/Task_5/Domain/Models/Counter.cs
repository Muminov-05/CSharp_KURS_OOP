using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Counter
    {
        public int Value { get; set; }
        public Counter(int value)
        {
            Value = value;
        }
       
    }
}
