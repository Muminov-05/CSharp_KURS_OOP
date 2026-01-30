using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class LockServices : IDevices
    {
        public bool IsLocked { get;  set; }

        public void TurnOn()   
        {
            IsLocked = true;
            Console.WriteLine("Door is LOCKED");
        }

        public void TurnOff()  
        {
            IsLocked = false;
            Console.WriteLine("Door is UNLOCKED");
        }
    }
}
