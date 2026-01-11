
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[n];
int result_um = 1;

Console.WriteLine("Введите элементы массива (элементы массива вводится через enter ):");
for (int i = 0; i < n; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
    result_um *= massiv[i];
}

for (int i = 0; i < n; i++)
{
    if (i < n - 1)
        if (massiv[i] < 0)
        {
            Console.Write($"({massiv[i]}) * ");
        }
        else
        {
            Console.Write($"{massiv[i]} * ");
        }
    else
    {
        if (massiv[i] < 0)
        {
            Console.Write($"({massiv[i]}) = ");
        }
        else
        {
            Console.Write($"{massiv[i]} = ");
        }
    }
}

Console.WriteLine(result_um);


