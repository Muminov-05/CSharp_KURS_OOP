

Console.WriteLine("Введите размер массива : ");
int n = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[n];
Console.WriteLine("Введите элементы массива (элементы массива вводится через enter ):");
for (int i = 0; i < n; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = massiv.Length-1; i > 0 ; i--)
{
    if (massiv[i] == massiv[i - 1] )
    {
        Console.WriteLine("Output : ")
        Console.WriteLine(massiv[i] + "  " + massiv[i-1]);
        break;
    }
}


