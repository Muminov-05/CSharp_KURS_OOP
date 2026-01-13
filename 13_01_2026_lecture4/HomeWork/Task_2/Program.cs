
// Напишите программу на C# Sharp для печати чисел от n до 1 с использованием рекурсии.

//int PrintDigitNumberReverse(int n, int digit = 1)
//{
//    if (n == 0)
//        return 0;
//    Console.WriteLine(n);
//    return PrintDigitNumberReverse(--n, ++digit);
//}

void PrintDigitNumberReverse(int n)
{
    if (n == 0)
        return;
    Console.WriteLine(n);
    PrintDigitNumberReverse(n-1);
}

Console.WriteLine(" Введите число :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Output :");
PrintDigitNumberReverse(n);