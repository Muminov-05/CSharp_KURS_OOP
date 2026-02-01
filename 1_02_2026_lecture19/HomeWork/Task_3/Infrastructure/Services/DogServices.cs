using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class DogServices : Dog , IDog
    {
        public DogServices() { }
        public DogServices(int id, string name, string breed, int age) 
            : base(id, name, breed, age) { }

        public List<Dog> DogList = new List<Dog>();

        public void AddDog(Dog dog)
        {
            DogList.Add(dog);
        }
        public void DeleteDog(int id)
        {
            bool flag = DogList.Exists(x => x.Id == id);
            if (flag)
            {
                DogList.RemoveAt(id);
                Console.WriteLine($" The dog with Id = {id + 1} was deleted");
            }
        }
        public void ShowDogs()
        {
            foreach(var dog in DogList)
            {
                Console.WriteLine($" {dog.Id} {dog.Name}  {dog.Breed}  {dog.Age}");
            }
        }
        public void UpdateDog(Dog newDog)
        {
            for (int i = 0; i < DogList.Count; i++)
            {
                if(DogList[i].Id == newDog.Id)
                {
                    DogList[i] = newDog;
                    Console.WriteLine($" The dog with Id = {newDog.Id} was updated");
                }
            }
        }
   }
}
