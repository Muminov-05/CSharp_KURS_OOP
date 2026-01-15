
//Создайте класс с именем "Person" с атрибутами имени, фамилии, возраста и адреса.              
//Также добавьте метод, который возвращает полное имя человека (то есть имя и фамилию).          
//Затем создайте объект класса "Person" и установите его свойства.                            
//Наконец, вызовите метод, который возвращает полное имя человека и выведите его на консоль.               
//Также добавьте метод для получения года рождения человека на основе его возраста.  

Person person = new Person();
Console.Write("Enter your FirstName : ");
person.FirstName = Console.ReadLine();
Console.Write("Enter your LastName :  ");
person.LastName = Console.ReadLine();
Console.Write("Enter your Age : ");
person.Age = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your Adress :  ");
person.Adress = Console.ReadLine();
person.FullName();
person.Birthday();

class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Adress;

    public void FullName()
    {
        Console.WriteLine($" My name is {FirstName} {LastName}");
    }
    public void Birthday()
    {
        Console.WriteLine($" My birth year is {2026 - Age}.");
    }
}