
// Напишите программу на C# Sharp для печати первых n натуральных чисел с использованием рекурсии. 

int PrintNumber(int n , int digit=1 )
{
    if (n == 0)
        return 0;
    Console.WriteLine(digit);
    return PrintNumber(--n, ++digit);
}

Console.WriteLine(" Введите число :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Output :");
PrintNumber(n);

