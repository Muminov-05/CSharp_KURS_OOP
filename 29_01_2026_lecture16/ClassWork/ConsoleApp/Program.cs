//### Task 1 (Russian)
//### Задачи для создания CRUD интерфейса без использования базы данных и с использованием ООП. 

//Задача: Создать CRUD интерфейс для управления списком пользователей с использованием ООП, без использования базы данных.

//### Описание задачи:
//- Необходимо создать программу, которая позволяет управлять списком пользователей. 
//- Для этого нужно создать класс User, который будет содержать следующие поля: имя, фамилия, email, возраст. 

//- Далее, необходимо создать класс UserList, который будет содержать список объектов класса User. 
//- В этом классе должны быть реализованы методы для добавления, удаления, изменения и просмотра пользователей в списке. 

//Для создания интерфейса можно использовать любую технологию, например, консольное приложение или графический интерфейс. 

//Необходимо обеспечить возможность добавления, удаления, изменения и просмотра пользователей в списке через интерфейс. 

//При реализации задачи необходимо использовать принципы ООП, такие как инкапсуляция, наследование и полиморфизм. 

//Удачи в выполнении задачи! Если у вас есть какие-либо вопросы, не стесняйтесь задавать их.
using Domain.Models;
using Infrastructure.Services;

UserListServices userListServices = new UserListServices();
User user1 = new User(1, "Alex", "Sanches", "alex@.com", 30);
User user2 = new User(2, "John", "Constantin", "John@.com", 38);
User user3 = new User(3, "Ali", "Aliev", "aliev@.com", 30);
User user4 = new User(4, "Karim", "Karimov", "karim@.com", 20);

userListServices.AddUser(user1);
userListServices.AddUser(user2);
userListServices.AddUser(user3);
userListServices.AddUser(user4);

userListServices.ReadListUser();

Console.WriteLine();
User newUser = new User(3, "Karimjon", "Salimov", "karimjon@.com", 26);
userListServices.UpdateUser(newUser);
userListServices.DeleteUser(1);

Console.WriteLine("\n Spisok polzovateley posle udaleniye i izmineniye:");
userListServices.ReadListUser();


