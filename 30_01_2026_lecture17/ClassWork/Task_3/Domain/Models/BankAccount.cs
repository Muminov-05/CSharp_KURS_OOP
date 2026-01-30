using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class BankAccount
    {
        public string Owner { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public BankAccount() { }
        public BankAccount(string owner, string accountNumber, decimal balance)
        {
            Owner = owner; AccountNumber = accountNumber; Balance = balance;
        }
        public abstract decimal CalculateInterest();
    }
}

