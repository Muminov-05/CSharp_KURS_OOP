using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

using Domain.Models;
namespace Infrastructure.Services
{
    public class TeacherServices : PersonServices
    {
        public void Explain()
        {
            Console.WriteLine("Учитель объясняет");
        }
    }
}
