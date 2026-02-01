using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Debt
    {
        public double InitialBalance { get; set; }
        public double InitialInterestRate { get; set; }
        public Debt(double  initialBalance, double initialInterestRate)
        {
            InitialBalance = initialBalance; InitialInterestRate = initialInterestRate;                                                                                                             
        }
    }
}
