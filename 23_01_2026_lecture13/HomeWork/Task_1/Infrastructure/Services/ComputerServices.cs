using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public class ComputerServices 
    {
        List<Computer> computers = new List<Computer>();

        public void AddComputer(Computer computer)
        {
            computers.Add(computer);
        }

        public virtual void PrintInfo()
        {
            foreach (Computer computer in computers)
            {
                Console.WriteLine($"Имя: {computer.Name},   Стоимост: {computer.Price},   Состояние: {computer.IsNew}");
            }
        }

    }
}
