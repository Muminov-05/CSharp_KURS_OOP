using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public class SmartPhoneServices : ComputerServices
    {
        List<SmartPhone> smartPhones = new List<SmartPhone>();

        public void AddSmartPhone(SmartPhone smartPhone)
        {
            smartPhones.Add(smartPhone);
        }
       
        public override void PrintInfo()
        {
            foreach (var phone in smartPhones)
            {
                Console.WriteLine(
                    $"Имя: {phone.Name}, Цена: {phone.Price}, Состояние: {phone.IsNew}, " +
                    $"Бренд: {phone.Brand}, Батарея: {phone.Energy} mAh"
                );
            }
        }

        public void ThearchXiomi()
        {
            var listXiomi = smartPhones.FindAll(p => p.Brand == "Xiaomi");
            foreach (var phone in listXiomi)
            {
                Console.WriteLine(
                    $"Имя: {phone.Name}, Цена: {phone.Price}, Состояние: {phone.IsNew}, " +
                    $"Бренд: {phone.Brand}, Батарея: {phone.Energy} mAh"
                );
            }
        }
    }
}
