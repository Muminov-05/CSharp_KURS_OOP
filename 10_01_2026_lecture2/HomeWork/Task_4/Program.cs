
Console.WriteLine("Введите размер массива : ");
int n = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[n];
Console.WriteLine("Введите элементы массива (элементы массива вводится через enter ):");
for (int i = 0; i < n; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Уникалные элементы мссива : ");
for (int i = 0; i < n; i++)
{
    bool d = true;
    for(int j = 0; j < n; j++)
    {
        if( massiv[i] == massiv[j] && i!=j )
        {
            d = false;
        }
    }
    if( d )
    {
       Console.Write(massiv[i] + "  ");
    }
}


