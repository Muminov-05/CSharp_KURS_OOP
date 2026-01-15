
// (Дан массив целых чисел. Нумерация элементов начинается с 0. Вывести все элементы массива с четными индексами (A[0], A[2], A[4], ...).)       

void PrintEvenIndex(int[] arr)
{
    for (int i = 0; i < arr.Length; i+=2)
    {
        Console.Write(arr[i] + "  ");
    }
}

Console.Write(" Vvedite razmer massiva : ");
int n = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[n];
Console.WriteLine($"Vvedite elementu massiva : ");
for (int i = 0; i < n; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}
PrintEvenIndex(massiv);