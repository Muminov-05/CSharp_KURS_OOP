
/*
Определите метод **PrintStars(int n)**, который печатает заданное количество звездочек и разрыва строки.
Напишите метод в следующем шаблоне.
 */

void PrintStars(int n)
{
    Console.WriteLine("Output : ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("*");
    }
}

PrintStars(6);