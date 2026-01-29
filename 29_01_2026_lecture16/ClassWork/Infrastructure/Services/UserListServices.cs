using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public class UserListServices : User , IUser
    {
        public UserListServices() { }
        public UserListServices(int id, string name, string lastName, string email, int age) 
            : base(id, name, lastName, email, age)
        {
        }
        List<User> users = new List<User>();
        public  void AddUser( User user)
        {
            users.Add(user);
        }
        public void ReadListUser()
        {
            foreach (var user in users)
            {
                Console.WriteLine($"Id = {user.Id}  Name = {user.Name}  LastName = {user.LastName}   Email = {user.Email}   Age = {user.Age}");
            }
        }
        public void DeleteUser( int id )
        {
            for(int i=0; i<users.Count;i++)
            {
                if( users[i].Id == id)
                {
                    users.Remove(users[i]);
                    Console.WriteLine($"The user with id = {i+1} was deleted.");
                }
            }
        }
        public void UpdateUser( User user )
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == user.Id)
                {
                    users[i].Name = user.Name;
                    users[i].LastName = user.LastName;
                    users[i].Email = user.Email;
                    users[i].Age = user.Age;
                    Console.WriteLine($"The user with id = {i+1} was updated.");
                }
            }
        }
    }
}
