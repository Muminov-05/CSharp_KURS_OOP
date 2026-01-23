
using Domain.Models;

namespace Infrastructure.Services
{
    public class CarServices
    {
        public void PrintInfo(Product p)
        {
            if (p is Car car)
            {
                Console.WriteLine($"Автомобиль: {car.Name},  Цена: {car.Price},  Марка: {car.BrandCar},  Год: {car.Year}");
            }
        }
        public void PrintMaxSpeed(Product p)
        {
            if( p is Car car)
            {
                Console.WriteLine($"Cкорост {car.Name} может достигат до {car.MaxSpeed} км/час");
            }
        }
    }
}