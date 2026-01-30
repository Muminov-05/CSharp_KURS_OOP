using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IBankAccount 
    {
        public void Deposit(decimal  sum);
        public void Withdraw(decimal sum);
        public void PrintStatement();
    }
}
