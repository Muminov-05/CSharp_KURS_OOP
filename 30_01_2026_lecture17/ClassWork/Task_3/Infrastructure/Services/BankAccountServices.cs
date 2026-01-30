using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class BankAccountServices :BankAccount , IBankAccount
    {
        public BankAccountServices(string owner, string accountNumber, decimal balance)
            : base(owner, accountNumber, balance)
        {
        }
        public void Deposit(decimal sum)
        {
            Balance += sum;
        }
        public void Withdraw(decimal sum)
        {
            if (sum > Balance)
            {
                Console.WriteLine("Недостаточно средств.");
                return;
            }

            Balance -= sum;
        }
        public void PrintStatement()
        {
            Console.WriteLine();
            Console.WriteLine($"Владелец: {Owner}");
            Console.WriteLine($"Номер счета: {AccountNumber}");
            Console.WriteLine($"Баланс: {Balance}");
        }
        public override decimal CalculateInterest()
        {
            return Balance * 0.05m;
        }
    }
}
