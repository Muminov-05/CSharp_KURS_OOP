/*
Создайте метод **PrintTriangle(int size)**, который печатает треугольник с помощью метода **PrintStars(int).**
Вызов **PrintTriangle(4)** должен напечатать следующее.
*/

void PrintTriangle(int size)
{
    for (int i = 1; i <= size; i++)
    {
        PrintStars(i);
        Console.WriteLine();
    }
}

void PrintStars(int n )
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("*");
    }
}

PrintTriangle(4);

