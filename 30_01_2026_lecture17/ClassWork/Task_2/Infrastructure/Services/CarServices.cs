

using System;
using Domain.Models;

namespace Infrastructure.Services
{
    public class CarServices : IMovable
    {
        public CarServices() { }
        public void MoveLeft()
        {
            Console.WriteLine("Машина движется влево.");
        }

        public void MoveRight()
        {
            Console.WriteLine("Машина движется вправо.");
        }
    }
}

