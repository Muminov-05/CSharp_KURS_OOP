using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public class Meneger : Employee
    {
        public int YearsOfWorking { get; set; }
        public Meneger(int employeeId, string name, decimal salary, int yearOfWork)
            : base(employeeId, name, salary)
        {
            YearsOfWorking = yearOfWork;
        }
        public override decimal CalculateBonus()
        {
            return Salary * (0.05m * YearsOfWorking);
        }
    }
}
