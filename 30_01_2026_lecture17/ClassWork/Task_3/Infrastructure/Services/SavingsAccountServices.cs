using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class SavingsAccountServices : BankAccountServices 
    {
        public SavingsAccountServices(string owner, string accountNumber, decimal balance)
            : base(owner, accountNumber, balance)
        {
        }
        public override decimal CalculateInterest()
        {
            return Balance * 0.05m;
        }
    }
}
