
int CountEvenDigit(int n, int Count=0 )
{
    if (n / 10 == 0)
        return (n % 2 == 0 && n != 0) ? ++Count : Count;
    int a = n % 10;
    if (a % 2 == 0 && a != 0 )
        Count++;
    return CountEvenDigit(n / 10 , Count);
}

int CountOddDigit(int n, int Count = 0)
{
    if (n == 0)
        return Count;
    int a = n % 10;
    if (a % 2 == 1 && a != 0)
        Count++;
    return CountOddDigit(n / 10, Count);
}

int CountZeroDigit(int n, int Count = 0)
{
    if (n == 0)
        return  Count ;
    int a = n % 10;
    if (a == 0)
        Count++;
    return CountZeroDigit(n / 10, Count);
}

int CountDigitNumber(int n, int Count = 0)
{
    return CountZeroDigit(n) + CountEvenDigit(n) + CountOddDigit(n);
}

int MinEl(int n, int min = 10)
{
    if (n == 0)
        return min;
    int a = n % 10;
    if (a < min)
        min = a;
    return MinEl(n / 10, min);
}

int MaxEl(int n, int max = 0)
{
    if (n == 0)
        return max;
    int a = n % 10;
    if (a > max)
        max = a;
    return MaxEl(n / 10, max);
}

int SumDigitNumber(int n, int sum = 0)
{
    if (n == 0)
        return sum;
    int a = n % 10;
    sum+=a;
    return SumDigitNumber(n / 10, sum);
}

Console.Write(" N = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Even = " + CountEvenDigit(n));
Console.WriteLine(" Odd = " + CountOddDigit(n));
Console.WriteLine(" Zero = " + CountZeroDigit(n));
Console.WriteLine(" Digits = " + CountDigitNumber(n));
Console.WriteLine(" Min = " + MinEl(n));
Console.WriteLine(" Max = " + MaxEl(n));
Console.WriteLine(" Sum = " + SumDigitNumber(n));

