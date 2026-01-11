
Console.WriteLine("Введите размер массива : ");
int n = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[n];
Console.WriteLine("Введите элементы массива (элементы массива вводится через enter ):");
for (int i = 0; i < n; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Output : ");
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i] % 2 == 1 )
    {
        Console.Write( i + "  ");
    }
}
