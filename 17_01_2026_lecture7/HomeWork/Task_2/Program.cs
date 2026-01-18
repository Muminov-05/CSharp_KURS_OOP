//Класс: User(Пользователь)
//Свойства:
//-FirstName(string) - Имя пользователя.
//- LastName(string) - Фамилия пользователя.
//- Username(string) - Имя пользователя(логин).
//- Password(string) - Пароль пользователя.
//- IsLoggedIn(bool) - Флаг указывающий, вошел ли пользователь в систему.

//Методы:
//- `void Login(string username, string password)` -Если пароль и имя пользователя совпадают,
//- выводится сообщение "Пользователь успешно зарегистрирован", и устанавливается значение IsLoggedIn в true.
//- В противном случае выводится сообщение "Ваш пароль или имя пользователя неверны".
//- `void Logout()` - Изменяет значение IsLoggedIn на false.
//- `string GetFullInfo()` - Возвращает информацию о пользователе в формате "[FirstName] [LastName] - [IsLoggedIn]".
//- пример: Абдулла Абдуллоев - true

User user = new User("John", "Wick", "John2002", "John123", false);
user.Login("John2002", "John123");
Console.WriteLine(user.GetFullInfo());
user.Logout();

class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool IsLoggedIn { get; set; }

    public User() {}
    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
    public User(string firstName , string lastName , string username , string password , bool isLoggeIn)
    {
        FirstName = firstName; LastName = lastName; Username = username; Password = password; IsLoggedIn = isLoggeIn;
    }
    
    public void Login(string username, string password)
    {
        if( Username == username && Password == password )
        {
            Console.WriteLine("Пользователь успешно зарегистрирован");
            IsLoggedIn = true;
        } else
        {
            Console.WriteLine("Ваш пароль или имя пользователя неверны");
        }
    }
    public void Logout()
    {
        IsLoggedIn = false;
    }
    public string GetFullInfo()
    {
        return $" {FirstName} {LastName} - {IsLoggedIn}";
    }

}