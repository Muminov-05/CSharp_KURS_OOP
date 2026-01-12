
//Напишите метод, который будет принимать два параметра типа int по ссылке и менять их значения местами.

void Swap( ref int x, ref int y)
{
    int a = x;
    x = y;
    y = a;
}

Console.WriteLine(" Input : ");
Console.Write(" x : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write(" y : ");
int y = Convert.ToInt32(Console.ReadLine());

Swap( ref x, ref y);

Console.WriteLine(" Output : ");
Console.WriteLine($" x : {x}");
Console.WriteLine($" y : {y}");
