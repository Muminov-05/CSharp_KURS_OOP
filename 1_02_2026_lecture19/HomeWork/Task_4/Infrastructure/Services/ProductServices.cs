using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
namespace Infrastructure.Services
{
    public class ProductServices : Product ,IProduct
    {
        public ProductServices(string name, double price, int quantity)
            : base(name, price, quantity) { }

        public void PrintProduct()
        {
            Console.WriteLine($"{Name} : Price = {Price} : {Quantity} pcs");
        }
    }
}
