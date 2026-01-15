
//  Создайте класс под названием `Person` со следующими свойствами: `FirstName`, `LastName` и `Age`.
//  Вам следует создать метод под названием `GetInfo()`. Метод должен возвращать информацию о человеке.

Person person = new Person();
Console.Write("Enter your FirstName : ");
person.FirstName = Console.ReadLine();
Console.Write("Enter your LastName :  ");
person.LastName = Console.ReadLine();
Console.Write("Enter your Age : ");
person.Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Output : ");
person.GetInfo();

class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public void GetInfo()
    {
        Console.WriteLine($" Firstname : {FirstName} ");
        Console.WriteLine($" LastName : {LastName} ");
        Console.WriteLine($" Age : {Age} ");
    }
}


