using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class Developer : Employee
    {
        public int Rayting { get; set; }
        public Developer(int employeeId, string name, decimal salary, int rayting) 
            : base(employeeId,name,salary)
        {
            Rayting = rayting;
        }
        public override decimal CalculateBonus()
        {
            return Salary * (0.03m * Rayting);
        }
    }
}
