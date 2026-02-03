
// Напишите программу, которая запрашивает у пользователя название цвета (красный, зеленый, синий) 
// и выводит его код в формате RGB с помощью перечисления (enum).


Color color = Color.Green;
Console.WriteLine((int)color);

enum Color
{
    Red = 1,
    Green,
    Blue
}

