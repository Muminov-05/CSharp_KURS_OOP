
Student student = new Student();
Console.WriteLine("Введите имя студента ");
student.Name = Console.ReadLine();
student.Study();
Console.Write(" Введите новую оценку : ");
int mark = Convert.ToInt32(Console.ReadLine());
student.SetGrade(mark);
Console.WriteLine($" Оценка у {student.Name} {student.GetGrade()}");

class Student
{
    private string name ;
    private int age ;
    private int grade ;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Grade
    {
        get { return grade; }
        set { grade = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Student() {}
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Student(string name, int age, int grade)
    {
        this.name = name;
        this.age = age;
        this.grade = grade;
    }
    public void Study()
    {
        Console.WriteLine($" {name} учится ");
    }
    public void SetGrade(int newGrade)
    {
        grade = newGrade;
    }
    public int GetGrade()
    {
        return grade;
    }
}