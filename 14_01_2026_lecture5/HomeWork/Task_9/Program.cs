
// Напишите программу на C# Sharp для вычисления степени любого числа с помощью рекурсии.  

int Pow(int a, int b)
{
    if (b == 0)
        return 1;
    return a * Pow(a, --b);
}

Console.Write(" a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(" b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" {a} ^ {b} = {Pow(a, b)}");


