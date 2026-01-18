//Напишите класс "Студент", который будет представлять студента с именем, возрастом и средней оценкой по предметам.
//### Инструкции
//1. Создайте публичный класс `Student`.
//2. Создайте конструктор, который принимает параметры `name`, `age` и `averageGrade` для инициализации свойств объекта.
//3. Добавьте метод `GetInfo()`, который будет выводить информацию о студенте в формате строки,
//    например: "Имя: Шахром, Возраст: 20, Средняя оценка: 4.5".
//4.Добавьте метод `IsExcellentStudent()`, который будет возвращать `true`, если средняя оценка студента     
//   выше 4.0, и `false` в противном случае. Этот метод поможет определить, является ли студент отличником.


Student student = new Student("Aleksey Ivanov" , 21 , 4.3);
student.GetInfo();
if(student.IsExcellentStudent())
{
    Console.WriteLine(" On otlichnik ");
} else
{
    Console.WriteLine(" On ne otlichnik ");
}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double AverageGrade { get; set; }

    public Student() {}
    public Student(string  name, int age, double averageGrade)
    {
        Name = name; Age = age; AverageGrade = averageGrade;
    }
    public void GetInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Средняя оценка: {AverageGrade}");
    }
    public bool IsExcellentStudent()
    {
        if (AverageGrade > 4)
            return true;
        return false;
    }
}