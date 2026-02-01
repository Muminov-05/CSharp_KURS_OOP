using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Account
    {
        public string AccontName {  get; set; }
        public double Balance { get; set; }
        public Account() { }
        public Account(string accontName, double balance)
        {
            AccontName = accontName;
            Balance = balance;
        }
    }
}
