using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CheckingAccountServices : BankAccountServices
    {
        public CheckingAccountServices(string owner, string accountNumber, decimal balance)
            : base(owner, accountNumber, balance)
        {
        }
        public override decimal CalculateInterest()
        {
            return Balance * 0.05m;
        }
    }
}
