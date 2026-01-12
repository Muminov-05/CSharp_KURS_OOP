
//Напишите метод **int[] IncrementElements(int[] arr, ref int n)**.Метод должен увеличивать все элементы массива на переданное значение.

int[] IncrementElements(int[] arr, ref int n)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] += n ;
    }
    return arr;
}

Console.WriteLine(" Введите размер массива :");
int size = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[size];
Console.WriteLine(" Введите значение массива :");
for (int i = 0; i < size; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" Введите значение для увиличения :");
int val = Convert.ToInt32(Console.ReadLine());
int[] new_mas = IncrementElements(massiv, ref val);

Console.WriteLine(" Резултат :");
for (int i = 0; i < size; i++)
{
    Console.Write(new_mas[i] + "  ");
}
