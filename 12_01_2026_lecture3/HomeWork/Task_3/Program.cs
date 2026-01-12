
//Дано натуральное число N. Напишите Метод **int MinDigit (int n)** и **int MaxDigit (int n)** , которая задает наименьшую           
//и наибольшую цифры заданного числа. Выведите сумму наибольшей и наименьшей цифр.

int MinDigit(int n)
{
    int min_digit = 10;
    while (n > 0)
    {
        int digit = n % 10;
        if (min_digit > digit)
        {
            min_digit = digit;
        }
        n /= 10;
    }
    return min_digit;
}

int MaxDigit(int n)
{
    int max_digit = 0;
    while (n > 0)
    {
        int digit = n % 10;
        if (max_digit < digit)
        {
            max_digit = digit;
        }
        n /= 10;
    }
    return max_digit;
}

Console.WriteLine(" Input : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Output :");
Console.WriteLine($" {MinDigit(n)} + {MaxDigit(n)} = {MinDigit(n) + MaxDigit(n)} ");