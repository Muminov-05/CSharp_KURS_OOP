using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class Account
    {
        public string UserName { get; set; }
        public string Email { get; set; } 
        public Account() { }
        public Account(string username, string email)
        {
            UserName = username; Email = email;
        }
        public void Login()
        {
            Console.WriteLine($"{UserName} вошёл в систему.");
        }

        public void Logout()
        {
            Console.WriteLine($"{UserName} вышел из системы.");
        }

        public abstract void DisplayProfile();
        
    }
}
