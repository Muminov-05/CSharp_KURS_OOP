using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AccountServices : Account, IAccount
    {
        public AccountServices() { }
        public AccountServices(double balance) : base(balance) { }
        public void PrintBalance()
        {
            Console.WriteLine(" Balance = " + Balance);
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdrawal(double amount)
        {
            if( amount > Balance)
            {
                Console.WriteLine("Nedastatochno sredtv.");
                return;
            }
            Balance -= amount;
        }
    }
}
