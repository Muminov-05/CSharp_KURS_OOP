
//Создайте класс с именем "Student" с атрибутами имени, уровня класса (1,2,3,…11) и списком оценок.            
//Включите метод, который вычисляет средний балл студента. Затем создайте массив из пяти объектов             
//Student с разными именами, уровнями класса и оценками. Наконец, переберите массив и напечатайте                 
//индивидуальное сообщение каждому студенту на основе его средней оценки. Если его средний балл выше 85,
//поздравьте его и поощрите продолжать в том же духе. Если его средний балл ниже 70, предложите               
//поддержку и посоветуйте обратиться за дополнительной помощью при необходимости. Для оценок                     
//между 70 и 85 дайте положительную обратную связь и мотивируйте его стремиться к улучшению.

Student[] student = new Student[5];
student[0] = new Student { Name = "Alex Alexis", GradeLevel = 5, TestScores = new double[] { 90, 85, 92 } };
student[1] = new Student { Name = "John Carter", GradeLevel = 10, TestScores = new double[] { 90, 75, 72 } };
student[2] = new Student { Name = "Sasha Aleksandr", GradeLevel = 9, TestScores = new double[] { 40, 55, 92 } };
student[3] = new Student { Name = "Villi Vonka", GradeLevel = 7, TestScores = new double[] { 40, 85, 90 } };
student[4] = new Student { Name = "Dmitriy Aleksey", GradeLevel = 11, TestScores = new double[] { 90, 95, 92 } };

for (int i = 0; i < student.Length; i++)
{             
    double avg = student[i].AverageTestScore();
    Console.Write(i+1 + ".");
    if (avg > 85)
    {
        Console.WriteLine($"Congratulations {student[i].Name} on achieving above average scores ({avg}) in grade {student[i].GradeLevel}!\r\n" +
                          "Keep up the good work!");
    }
    else if (avg < 70)
    {
        Console.WriteLine($"{student[i].Name}, if you're having difficulties with your studies, don't hesitate to\r\n" +
                          $"seek help. Your current average score is {avg} in grade {student[i].GradeLevel}.");
    }
    else
    {
        Console.WriteLine($"{student[i].Name}, good job! Your current average score is {avg} in grade {student[i].GradeLevel}.\r\n" +
                          "Keep striving to improve!");
    }
    Console.WriteLine("---------------------------------------------------------------------------------");
}



class Student
{
    public string Name;
    public int GradeLevel;
    public double[] TestScores;

    public double AverageTestScore()
    {
        if (TestScores.Length == 0)
            return 0;
        double sum = 0;
        for (int i = 0; i < TestScores.Length; i++)
        {
            sum += TestScores[i];
        }
        return sum / TestScores.Length;
    }

}