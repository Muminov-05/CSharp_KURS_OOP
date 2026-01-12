
/*
 (Создайте метод **PrintRightTriangle(int size)**, который использует PrintSpaces и PrintStars для печати правильного треугольника.
Вызов метода **PrintRightTriangle(4)** должен напечатать следующее.)
*/

void PrintRightTriangle(int size)
{
    for( int i = 1; i <= size; i++)
    {
        PrintSpaces(si-i);
        PrintStars(i);
        Console.WriteLine();
    }
}

void PrintSpaces(int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write(" ");
    }
}
void PrintStars(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("*");
    }
}

PrintRightTriangle(4);