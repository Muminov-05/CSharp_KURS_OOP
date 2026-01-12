/*
Дано положительное число n. Распечатать:
1.Количество четных чисел **int EvenCount(int n)**

2.	Количество нечетных чисел **int OddCount(int n)**
   
3.	Количество цифр **int DigitCount(int n)**

4.	Сумма цифр **int SumDigit(int n)**
*/

int EvenCount(int n)
{
    int kol = 0;
    while( n > 0)
    {
        int digit = n % 10;
        if ( digit % 2 == 0)
        {
            kol++;
        }
        n /= 10;
    }
    return kol;
}

int OddCount(int n)
{
    int kol = 0;
    while (n > 0)
    {
        int digit = n % 10;
        if (digit % 2 == 1)
        {
            kol++;
        }
        n /= 10;
    }
    return kol;
}

int DigitCount(int n)
{
    return  EvenCount(n) + OddCount(n);
}

int SumDigit(int n)
{
    int sum = 0;
    while (n > 0)
    {
        int digit = n % 10;
        sum += digit;
        n /= 10;
    }
    return sum;
}

Console.WriteLine(" Input : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Output :");
Console.WriteLine($" Even : {EvenCount(n)}");
Console.WriteLine($" Odd : {OddCount(n)}");
Console.WriteLine($" Digit : {DigitCount(n)}");
Console.WriteLine($" Sum : {SumDigit(n)}");