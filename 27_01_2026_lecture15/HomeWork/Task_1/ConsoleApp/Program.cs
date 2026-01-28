//### Наследование объектов

//Создайте программу на языке C#, которая запрашивает у пользователя три имени людей и сохраняет их в массив объектов типа `Person`.
//В массиве должно быть два объекта типа `Student` и один объект типа `Teacher`.

//Для выполнения задачи выполните следующие шаги:
//1.Создайте класс `Person` со следующими характеристиками:
//   -Свойство `Name` типа string
//   - Конструктор, принимающий имя в качестве параметра
//   - Переопределите метод `ToString()`
//2. Создайте еще два класса, которые наследуются от класса `Person`:
//   -Класс `Student`:
//     -Имеет метод `Study`, который выводит в консоль сообщение "Студент учится"
//     - Создайте конструктор в классе `Student`, вызывающий конструктор родительского класса `Person`
//   - Класс `Teacher`:
//     -Имеет метод `Explain`, который выводит в консоль сообщение "Учитель объясняет"
//     - Создайте конструктор в классе `Teacher`, вызывающий конструктор родительского класса `Person`
//3. В основной программе:
//   -Запросите у пользователя имена трех людей и сохраните их в массиве объектов типа `Person`
//   - Вызовите метод `Explain` для объекта `Teacher`
//   - Вызовите метод `Study` для объектов `Student`

using Domain.Models;
using Infrastructure.Services;

List<Person> people = new List<Person>();

Console.Write("Введите имя первого студента: ");
people.Add(new Student(Console.ReadLine()));

Console.Write("Введите имя второго студента: ");
people.Add(new Student(Console.ReadLine()));

Console.Write("Введите имя учителя: ");
people.Add(new Teacher(Console.ReadLine()));

var studentService = new StudentServices();
var teacherService = new TeacherServices();
var personService = new PersonServices();

Console.WriteLine("\nИмена людей:");
foreach (Person person in people)
{
    Console.WriteLine(personService.ToString(person));
}

Console.WriteLine("\nДействия:");
foreach (Person person in people)
{
    if (person is Student student)
    {
        studentService.Study();
    }
    else if (person is Teacher teacher)
    {
        teacherService.Explain();
    }
}
