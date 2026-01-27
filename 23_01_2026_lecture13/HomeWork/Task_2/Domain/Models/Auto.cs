using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Auto : Transport
    {
        public string IsNew { get; set; }
        public Auto() { }
        public Auto(string name, int speed, string isNew) : base(name, speed)
        {
            IsNew = isNew;
        }
    }
}
