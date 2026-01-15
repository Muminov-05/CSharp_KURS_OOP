
// Напишите рекурсивную функцию для вычисления суммы цифр заданного числа. in C#.Если число меньше 10, покажите само число.

int Sum(int n)
{
    if (n <= 0)
        return 0;
    return (n%10) + Sum(n/10);
}

Console.Write(" N = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sum(n));