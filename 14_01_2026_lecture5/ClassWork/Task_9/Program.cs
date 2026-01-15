
// Напишите программу на C# Sharp, чтобы найти числа Фибоначчи для ряда из n чисел, используя рекурсию. 

int Fibonachi(int n)
{
    if (n == 0)
        return 0;
    if (n == 1)
        return 1;
    return Fibonachi(n - 1) + Fibonachi(n - 2);
}

Console.Write(" N = ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    Console.WriteLine(Fibonachi(i));
}
