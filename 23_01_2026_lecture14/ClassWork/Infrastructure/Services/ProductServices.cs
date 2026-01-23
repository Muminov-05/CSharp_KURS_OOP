
using Domain.Models;

namespace Infrastructure.Services
{
    public class ProductServices
    {
        public virtual void  PrintInfo(Product p)
        {
            Console.WriteLine($"Товар: {p.Name}, Цена: {p.Price}");
        }
    }
}