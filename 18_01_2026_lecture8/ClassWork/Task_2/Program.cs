//Напишите программу на C#, которая запрашивает у пользователя имя пользователя и пароль. Оба значения должны быть введены пользователем.
//### Инструкции
//1. Создайте публичный класс `User` со следующими свойствами:
//   - `FirstName` (Имя)
//   - `LastName` (Фамилия)
//   - `UserName` (Имя пользователя)
//   - `Password` (Пароль)
//2. В классе `User` создайте следующие методы:
//   - `GetInfo()` (Получить информацию)
//   - `Login()` (Вход в систему)
//3. Создайте массив объектов `User` и заполните его 5 пользователями.
//4. Реализуйте бесконечный цикл, который запрашивает у пользователя имя пользователя и пароль через консоль.
//5. Проверьте, совпадают ли введенное имя пользователя и пароль с данными какого-либо пользователя в массиве.
//6. Если имя пользователя и пароль введены правильно, выведите сообщение: "Вход выполнен успешно! Добро пожаловать, г-н/г-жа [Имя] [Фамилия]".
//7.Если имя пользователя и пароль введены неправильно, выведите сообщение: "Ошибка входа".
//Убедитесь в том, что вы следуете инструкциям для создания программы на C# для управления доступом. 

User[] users = new User[5];
users[0] = new User { FirstName = "Абдулла", LastName = "Абдуллоев", UserName = "abdulla1990", Password = "123" };
users[1] = new User { FirstName = "Макс", LastName = "Тихомиров", UserName = "макс1972", Password = "147" };
users[2] = new User { FirstName = "Джон", LastName = "Константин", UserName = "Джон1980", Password = "963" };
users[3] = new User { FirstName = "Лекс", LastName = "Константин", UserName = "Лекс200", Password = "250" };
users[4] = new User { FirstName = "Аслам", LastName = "Акбей", UserName = "Аслам1589", Password = "9546" };

while (true)
{
    Console.Write(" Username : "); 
    string Username = Console.ReadLine();
    Console.Write(" Password : ");
    string Password = Console.ReadLine();
    bool d = false;
    for( int i=0; i<users.Length; i++)
    {
        if (users[i].Login(Username, Password))
        {
            Console.WriteLine($"Вход выполнен успешно! Добро пожаловать, г-н/г-жа {users[i].FirstName} {users[i].LastName}");
            d = true;
            break;
        }
    }
    if (!d)
        Console.WriteLine("Ошибка входа. Попробуйте сного");
    Console.WriteLine();
}

class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public User() {}

    public void GetInfo()
    {
        Console.WriteLine($" {FirstName} {LastName}");
    }
    public bool Login( string userName, string password)
    {
        if(userName == UserName && password == Password)
            return true;
        return false;
    }
}