
/*
Определите метод **PrintSquare(int size)**, который печатает подходящий квадрат с помощью метода **PrintStars(int).**
Вызов метода **PrintSquare(4)** приводит к следующему выводу.
*/

void PrintSquare(int size)
{
    for (int i = 0; i < size; i++)
    {
        PrintStars(size);
        Console.WriteLine();
    }
}

void PrintStars(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("*");
    }
}

PrintSquare(5);
