
//(Определите метод** ChristmasTree(int height)**, который печатает правильную рождественскую елку.

//Елка состоит из треугольника заданной высоты и основания.

//Основание имеет высоту две звезды и ширину три звезды и расположено в центре нижней части треугольника.

//Дерево должно быть построено с использованием методов **PrintSpaces(int)** и **PrintStars(int)**.

//Вызов **ChristmasTree(4)** должен вывести следующее:)

void ChristmasTree(int height)
{
    for( int i = 1; i <= height; i++)
    {
        PrintSpaces(height - i);
        PrintStars(i * 2 - 1);
        Console.WriteLine();
    }
    for (int i = 1; i <= 2; i++)
    {
        PrintSpaces((height*2-4)/2);
        PrintStars(3);
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

ChristmasTree(6);