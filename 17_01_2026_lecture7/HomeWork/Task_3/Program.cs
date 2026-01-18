//Создайте класс "Author" (Автор) с несколькими методами и несколькими конструкторами. 
//Класс должен иметь следующие характеристики:
//1.Поля класса:
//- `name` (имя автора) - строка,
//   - `age` (возраст автора) - целое число,
//   - `nationality` (национальность автора) - строка.
//2. Методы класса:
//   - `GetName()` -возвращает имя автора,
//   - `GetAge()` - возвращает возраст автора,
//   - `GetNationality()` - возвращает национальность автора,
//   - `Introduce()` - выводит сообщение в формате "Меня зовут {name}. Мне {age} лет. Я из {nationality}.",
//   - `CelebrateBirthday()` - увеличивает возраст автора на 1.
//3. Конструкторы:
//   -Конструктор по умолчанию, который не принимает аргументов и инициализирует поля класса значениями по умолчанию.
//   - Конструктор, принимающий аргументы `name` и `age` и инициализирующий соответствующие поля класса.
//   - Конструктор, принимающий аргументы `name`, `age` и `nationality` и инициализирующий соответствующие поля класса.

Author author = new Author("Александр Пушкин", 36, "Россия");
Console.WriteLine(author.GetName());
Console.WriteLine(author.GetAge());
Console.WriteLine(author.GetNationality());
author.Introduce();
author.CelebrateBirthday();
Console.WriteLine("Его возраст : " + author.GetAge());

class Author
{
    private string Name { get; set; }
    private int Age { get; set; }
    private string Nationality {  get; set; }

    public Author() {}
    public Author(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public Author(string name, int age, string nationality)
    {
        Name = name; 
        Age = age; 
        Nationality = nationality;
    }

    public string GetName()
    {
        return Name;
    }
    public int GetAge()
    {
        return Age;
    }
    public string GetNationality()
    {
        return Nationality;
    }
    public void Introduce()
    {
        Console.WriteLine($"Меня зовут {Name}. Мне {Age} лет. Я из {Nationality}.");
    }
    public void CelebrateBirthday()
    {
        Age++;
        Console.WriteLine("Возраст автора увиличен на 1 год ");
    }
}