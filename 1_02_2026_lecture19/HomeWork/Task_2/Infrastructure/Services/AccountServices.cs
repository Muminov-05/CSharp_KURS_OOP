using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public class AccountServices : Account , IAccount
    {
        public AccountServices() { }
        public AccountServices(string accountName, double balance) 
            : base(accountName, balance) { }

        public void PrintAccount()
        {
            Console.WriteLine($"{AccontName}'s account balance : {Balance}");
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdrawel(double amount)
        {
            if( amount > Balance)
            {
                Console.WriteLine("Nedostatochno sredstvo na balance.");
                return;
            }
            Balance -= amount;
        }
    }
}
