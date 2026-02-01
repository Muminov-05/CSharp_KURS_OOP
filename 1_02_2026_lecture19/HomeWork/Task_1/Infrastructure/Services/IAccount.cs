using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IAccount
    {
        void PrintBalance();
        void Deposit(double amount);
        void Withdrawal(double amount);
        
    }
}
