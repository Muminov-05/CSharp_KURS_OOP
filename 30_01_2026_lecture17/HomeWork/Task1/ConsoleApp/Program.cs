//### Task 1 

//# Class Person, Student, and Teacher
//Create a new C# project with three classes plus another class to test the logic in your code.                                   
//The main classes of the program are the following classes:      
//Создайте новый проект C# с тремя классами и еще одним классом для проверки логики вашего кода.
//Основными классами программы являются следующие классы:
//## Person
//`Person.cs` 
//The base class for both Student and Teacher.
//### Public Methods
//- `Greet()` 🌟: Writes "Hello!" on the screen.
//- `SetAge(int age)` 📅: Assigns the age of the person.
//## Student 
//`Student.cs`
//A class that inherits from Person.
//### Public Methods
//- `Study()` 📚: Writes "I'm studying" on the screen.
//- `ShowAge()` 🔢: Writes "My age is: x years old" on the screen.
//## Teacher
//`Teacher.cs`
//A class that inherits from Person.
//### Public Methods
//- `Explain()` 📝: Writes "I'm explaining" on the screen.

using Domain.Models;
using Infrastructure.Services;

Student student = new Student();
student.Greet();
student.SetAge(21);
student.Study();
student.ShowAge();

Teacher teacher = new Teacher();
teacher.Greet();
teacher.Explain();