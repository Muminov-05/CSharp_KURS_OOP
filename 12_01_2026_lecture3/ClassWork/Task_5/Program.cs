
/*
Напишите метод **PrintRectangle(int width, int height)**, который печатает правильный прямоугольник с помощью метода PrintStars(int).
Вызов метода PrintRectangle(17, 3) должен выдать следующий результат.
*/


void PrintRectangle(int width, int height)
{
    for (int i = 0; i < height; i++)
    {
        PrintStars(width);
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

PrintRectangle(17, 3);



