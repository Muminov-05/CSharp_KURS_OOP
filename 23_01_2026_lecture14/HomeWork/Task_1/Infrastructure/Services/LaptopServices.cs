using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public class LaptopServices : ComputerServices
    {
        List<Laptop> laptops = new List<Laptop>();

        public void AddLaptops(Laptop laptop)
        {
            laptops.Add(laptop);
        }

        public override void PrintInfo()
        {
            foreach (var l in laptops)
            {
                Console.WriteLine(
                    $"Имя: {l.Name}, Цена: {l.Price}, Состояние: {l.IsNew}, " +
                    $"Памят: {l.Memory},  Жёский диск: {l.HardDrive} mAh"
                );
            }
        }

        public void TypeHardDrive(Laptop l)
        {
            Console.WriteLine($"У ноутбука {l.Name} жёский диск {l.HardDrive} с памятью {l.Memory} гб");
        }

        public void DeleteLaptop( Laptop l)
        {
            laptops.Remove(l);
        }
    }
}
