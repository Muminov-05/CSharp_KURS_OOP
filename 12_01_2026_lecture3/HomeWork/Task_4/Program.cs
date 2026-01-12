
//Напишите Метод **int Pow(int x, int y)**, который принимает два параметра и возвращает **x** в степени **y**. 

int Pow(int x, int y)
{
    int result = 1;
    for (int i = 0; i < y; i++)
    {
        result *= x;
    }
    return result;
}

Console.WriteLine(" Input : ");
Console.Write(" x : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write(" y : ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write(" Output : ");
Console.WriteLine(Pow(x,y));