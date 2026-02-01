
//Класс Dog представляет собаку и имеет следующие свойства:
//- `name`: строка, представляющая имя собаки.
//- `breed`: строка, обозначающая породу собаки.
//- `age`: целое число, обозначающее возраст собаки.
//Диаграмма классов класса Dog выглядит следующим образом:
//```mermaid
//classDiagram
//    class Dog
//{
//        - name:string
//        - breed:string
//        - age : int
//}
//```
//На этой диаграмме классов класс Dog представлен прямоугольником с именем класса внутри.
//Три частные переменные: «имя», «порода» и «возраст» представлены линиями со знаком минус (-) перед ними.

using Domain.Models;
using Infrastructure.Services;

DogServices dogServices = new DogServices();
Dog dog1 = new Dog(1,"Rex", "Ovcharka",5);
Dog dog2 = new Dog(2,"Barsic", "Buldog", 4);
Dog dog3 = new Dog(3,"SD", "Alabai", 5);

dogServices.AddDog(dog1);
dogServices.AddDog(dog2);
dogServices.AddDog(dog3);

dogServices.ShowDogs();
Console.WriteLine();

Dog dog4 = new Dog(3, "SD2", "Alabai", 3);
dogServices.UpdateDog(dog4);
dogServices.DeleteDog(1);
Console.WriteLine();

dogServices.ShowDogs();