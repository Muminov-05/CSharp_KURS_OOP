
// Напишите программу на C# Sharp для отображения отдельных цифр заданного числа с помощью рекурсии.  

int PrintDigitNumber( int n)
{
    if (n / 10 == 0)
    {
        Console.WriteLine(n % 10);
        return 0;
    }
    int new_n = n;int kol = 0;
    while( n >= 10)
    {
        n/=10;kol++;
    }
    int del = Convert.ToInt32(Math.Pow(10, kol));
    Console.WriteLine(n);
    return PrintDigitNumber( new_n % del);
}


Console.WriteLine(" Введите число :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Output :");
PrintDigitNumber( n );
