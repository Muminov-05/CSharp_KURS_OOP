//### Задача 3:
//1.Создайте библиотеку классов под названием «Инфраструктура».
//2. Добавьте в решение проект библиотеки классов с именем «Инфраструктура».
//3. Реализация методов CRUD
//4. Внутри класса Student реализуйте методы для операций CRUD, таких как создание, чтение, обновление и удаление.
//5. Каждый метод должен обрабатывать соответствующую операцию с записями учащихся.

var studSer = new StudentSer();

var student1 = new Student(1, "Aleksandr", "Artyom" , 22);
var student2 = new Student(2, "John", "Wick", 20);
var student3 = new Student(3, "Sasha", "Sergey", 21);
var student4 = new Student(4, "Alijon", "Davlatov", 20);

studSer.CreateStudent(student1);
studSer.CreateStudent(student2);
studSer.CreateStudent(student3);
studSer.CreateStudent(student4);


foreach (var s in studSer.ReadStudent())
{
    Console.WriteLine($"{s.Id}.{s.FirstName} {s.LastName}, Age: {s.Age}");
}

Console.WriteLine("\nПосле удаления:");
studSer.DeleteStudent(1);

foreach (var s in studSer.ReadStudent())
{
    Console.WriteLine($"{s.FirstName} {s.LastName}, Age: {s.Age}");
}

var updatedStudent = new Student(2, "John", "Snow", 25);
studSer.UpdateStudent(updatedStudent);
Console.WriteLine("\nПосле изменения:");
foreach (var s in studSer.ReadStudent())
{
    Console.WriteLine($"{s.Id}: {s.FirstName} {s.LastName}, {s.Age}");
}