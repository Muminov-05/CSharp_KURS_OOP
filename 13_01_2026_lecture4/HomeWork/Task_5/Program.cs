
// Напишите программу на C# Sharp для подсчета количества цифр в числе с помощью рекурсии.  

int KolDigitNumber(int n , int kol = 1)
{
    if( n / 10 ==  0)
        return kol;
    kol= kol+1;
    return KolDigitNumber(n/10, kol);
}

Console.WriteLine(" Введите число :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Output :");
Console.WriteLine(KolDigitNumber(n));
