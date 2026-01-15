
// Напишите программу на C# Sharp для вычисления степени любого числа с помощью рекурсии.

int Pow(int a ,int n)
{
    if(n==0)
        return 1;
    return a*Pow(a,--n);
}

Console.Write(" Vvedite chislo = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(" Vvedite stepen = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} ^ {n} = {Pow(a, n)}");