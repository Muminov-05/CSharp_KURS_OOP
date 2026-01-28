using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Models;
namespace Infrastructure.Services
{
    public class StudentServices : PersonServices
    {
        public void Study()
        {
            Console.WriteLine($"Студент учится");
        }
    }
}
