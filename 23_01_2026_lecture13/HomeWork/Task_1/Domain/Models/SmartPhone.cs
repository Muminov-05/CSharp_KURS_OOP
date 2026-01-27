using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SmartPhone : Computer
    {
        public string Brand {  get; set; }
        public int Energy { get; set; }
        public SmartPhone(string name, int price, string isNew,  string brand, int energy)
            : base(name, price, isNew)
        {
            Brand = brand;
            Energy = energy;
        }
    }
}
