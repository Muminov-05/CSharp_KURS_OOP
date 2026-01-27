using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Laptop : Computer
    {
        public int Memory { get; set; }
        public string HardDrive { get; set; }
        public Laptop() { }

        public Laptop( string name , int prise, string isNew, int memory, string hardDrive)
            : base(name, prise, isNew)
        {
            Memory = memory;
            HardDrive = hardDrive;
        }
    }
}
