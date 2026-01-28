using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using Domain.Models;
namespace Infrastructure.Services
{
    public class PersonServices
    {
        public virtual string ToString(Person person)
        {
            return $"Имя: {person.Name}";
        }
    }
}
