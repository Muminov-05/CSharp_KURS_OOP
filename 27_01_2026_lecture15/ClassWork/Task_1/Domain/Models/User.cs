using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class User
    {
        public string UserName { get; set; }
        public User(string name)
        {
            UserName = name;
        }
        public abstract void ViewActivity();
    }
}
