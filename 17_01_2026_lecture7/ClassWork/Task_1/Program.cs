
Teacher teacher = new Teacher(" Владимер", "OOП",5);
Console.WriteLine(teacher.Teach());

Console.Write(" Cтаж учителя : ");
int staj = Convert.ToInt32(Console.ReadLine());
teacher.SetExperience(staj);
Console.WriteLine( $" Стаж Владимера {teacher.GetExperience()} лет.");

class Teacher
{
    private string name;
    private string subject;
    private int experience;

    public Teacher() {}
    public Teacher( string new_name , string new_subject)
    {
        name = new_name;
        subject = new_subject;
        experience = 0;
    }
    public Teacher(string new_name, string new_subject, int new_experience)
    {
        name = new_name;
        subject = new_subject;
        experience = new_experience;
    }

    public string Teach()
    {
        return $"{name} преподает { subject}";
    }

    public void SetExperience(int years)
    {
        experience = years;
    }
    public int GetExperience() 
    { 
        return experience;
    }
}