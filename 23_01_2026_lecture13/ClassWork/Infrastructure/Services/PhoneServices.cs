
using Domain.Models;

namespace Infrastructure.Services
{
    public class PhoneServices
    {
        public void PrintInfo(Product p)
        {
            if (p is Phone phone)
            {
                Console.WriteLine($"Телефон: {phone.Name},  Цена: {phone.Price},  Бренд: {phone.BrandPhone},  Память: {phone.MemoryPhone}");
            }
        }
        public void printMemoryPhone(Product p)
        {
            if (p is Phone phone)
            {
                Console.WriteLine($"У телефона {phone.Name} ест {phone.MemoryPhone} пмяти ");
            }
        }
    }
}