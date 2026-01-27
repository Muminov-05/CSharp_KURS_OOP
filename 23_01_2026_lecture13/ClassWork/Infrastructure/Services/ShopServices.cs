
using Domain.Models;
using System.Numerics;

namespace Infrastructure.Services
{
    public class ShopServices
    {
        List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
        public void PrintProductList()
        {
            Console.WriteLine("Список товаров в магазине:");
            foreach (var product in products)
            {
                if (product is Phone phone)
                    new PhoneServices().PrintInfo(phone);
                else if (product is Car car)
                    new CarServices().PrintInfo(car);
                else
                    new ProductServices().PrintInfo(product);
            }
        }
    }
}