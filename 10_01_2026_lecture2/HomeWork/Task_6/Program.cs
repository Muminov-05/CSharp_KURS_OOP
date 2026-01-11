
Console.WriteLine("Введите размер массива : ");
int n = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[n];
Console.WriteLine("Введите элементы массива (элементы массива вводится через enter ):");
for (int i = 0; i < n; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}

int kol = 0;

for (int i = 1; i < n - 1; i++)
{
    if (massiv[i] > massiv[i - 1] && massiv[i] > massiv[i + 1])
    {
        kol++;
    }
}
Console.WriteLine($"Количество элементов больше обоих своих соседей : {kol}");
