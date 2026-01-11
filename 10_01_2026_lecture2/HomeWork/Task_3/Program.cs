
Console.WriteLine("Введите размер массива : ");
int n = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[n];
Console.WriteLine("Введите элементы массива (элементы массива вводится через enter ):");
for (int i = 0; i < n; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}

int maxElement = massiv[0];
int index = 0 ;
for (int i = 1; i < massiv.Length; i++)
{
    if ( massiv[i] > maxElement)
    {
        maxElement = massiv[i];
        index = i;
    }
}
Console.WriteLine($" Максималный элемент {maxElement} , его индекс {index}.");


