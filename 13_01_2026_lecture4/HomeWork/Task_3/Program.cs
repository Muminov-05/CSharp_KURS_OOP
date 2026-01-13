
//Напишите программу на C# Sharp, которая находит сумму первых n натуральных чисел с помощью рекурсии.

int SumDigit(int n , int sum = 0)
{
    if( n == 0 )
        return sum;
    sum += n;
    return SumDigit(--n, sum);
}

Console.WriteLine(" Введите число :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Output :");
Console.WriteLine(SumDigit(n));