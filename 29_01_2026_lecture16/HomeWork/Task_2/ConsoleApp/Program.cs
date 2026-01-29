//### Абстрактные классы
//Создайте программу C#, реализующую абстрактный класс Animal, имеющий свойство Name текстового типа и                                
//три метода SetName (строковое имя), GetName и Eat. Метод Eat будет абстрактным методом типа void.                              

//Вам также потребуется создать класс Dog, реализующий указанный выше класс Animal, и метод Eat, который сообщает, что собака ест.

//Чтобы протестировать программу, запросите у пользователя имя собаки и создайте новый объект типа Dog из Main программы,
//дайте объекту Dog имя, а затем выполните методы GetName и Eat.                      

using Domain.Models;
using Infrastructure.Services;

DogServices dogServices = new DogServices();
dogServices.SetName("Rex");
dogServices.GetName();
dogServices.Eat();
