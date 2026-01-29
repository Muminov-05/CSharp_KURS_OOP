using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public User() { }
        public User(int id, string name, string lastName, string email, int age)
        {
            Id = id; Name = name; LastName = lastName; Email = email; Age = age;
        }
    }
}

