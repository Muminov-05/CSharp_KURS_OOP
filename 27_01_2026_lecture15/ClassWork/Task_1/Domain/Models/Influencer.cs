using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Influencer : User
    {
        public Influencer(string name ) : base( name ) { }
        public override void ViewActivity()
        {
            Console.WriteLine($"{UserName} может просматривать активность своих подписчиков.");
        }
    }
}

