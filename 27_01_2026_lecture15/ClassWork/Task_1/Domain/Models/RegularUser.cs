using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models 
{
     public class RegularUser : User
    {
        public RegularUser(string name) : base(name) { }
        public override void ViewActivity()
        {
            Console.WriteLine($"{UserName} просматривают только свою собственную активность.");
        }
    }
}
