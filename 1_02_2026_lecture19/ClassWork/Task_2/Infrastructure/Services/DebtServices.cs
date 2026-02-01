using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class DebtServices : Debt , IDebt
    {
        public DebtServices(double initialBalance, double initialInterestRate) 
            : base(initialBalance, initialInterestRate)
        {
        }
        public void PrintBalance()
        {
            Console.WriteLine(" Balance = " + InitialBalance);
        }
        public void WaitOneYear()
        {
            InitialBalance = InitialBalance + InitialBalance * InitialInterestRate;
        }
    }
}
