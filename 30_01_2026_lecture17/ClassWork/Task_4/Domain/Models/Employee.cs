using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int employeeId, string name, decimal salary)
        {
            EmployeeId = employeeId;
            Name = name;
            Salary = salary;
        }
        public abstract decimal CalculateBonus();
    }
}
