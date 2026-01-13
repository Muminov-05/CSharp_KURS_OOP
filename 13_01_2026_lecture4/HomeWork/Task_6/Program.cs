
// Напишите программу на C# для печати четных или нечетных чисел в заданном диапазоне с использованием рекурсии.  

void PrintDigitEven(int a, int b)
{
    if (a%2 == 0 && a <= b)
    {
        Console.Write(a + "  ");
    }
    if (a == b)
        return ;
    PrintDigitEven(a + 1, b);
}

void PrintDigitOdd(int a, int b)
{
    if (a % 2 == 1 && a <= b)
    {
        Console.Write(a + "  ");
    }
    if (a == b)
        return;
    PrintDigitOdd(a + 1, b);
}

Console.WriteLine(" Введите начало диапазона :");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите конец диапазона :");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" 1-Even   2-Odd :");
Console.WriteLine(" Ваш выбор : ");
int choise = Convert.ToInt32(Console.ReadLine());
switch ( choise)
{
    case 1:
        PrintDigitEven(a,b);
        break;
    case 2:
        PrintDigitOdd(a,b);
        break;
    default:
        Console.WriteLine("Neverniy vubor");
       break;
}
