
namespace Domain.Models
{
    public class Car : Product
    {
        public string BrandCar {  get; set; }
        public int Year { get; set; }
        public int MaxSpeed { get; set; }

        public Car() {}
        public Car(string name, int price, string brandCar, int year, int maxSpeed  )
            : base(name, price)
        {
            BrandCar = brandCar;
            Year = year;
            MaxSpeed = maxSpeed;
        }
    }
}